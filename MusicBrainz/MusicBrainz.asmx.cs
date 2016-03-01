using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services;

namespace MusicBrainz
{
    /// <summary>
    /// Summary description for MusicBrainz
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // To allow this Web Service to be called from script, using ASP.NET AJAX, uncomment the following line. 
    // [System.Web.Script.Services.ScriptService]
    public class MusicBrainz : System.Web.Services.WebService
    {
        /// <summary>
        /// This method gets a list of Artists when given a name parameter
        /// </summary>
        /// <param name="Name"></param>
        /// <returns></returns>
        [WebMethod]
        public List<Artists> getArtistList(string Name)
        {
            using (var db = new MusicEntities())
            {
                return (from a in db.Artists.Where(a => a.ArtistName.Contains(Name))
                        select new Artists
                        {
                            ID = (int)a.Id,
                            ArtistName = a.ArtistName,
                            Country = a.Country,
                            Aliases = a.Aliases,
                            Favourites = (bool?)a.Favourites ?? false
                        }).ToList<Artists>();
            }
        }
        /// <summary>
        /// This method updates favourites on releases
        /// </summary>
        /// <param name="ID"></param>
        /// <param name="bFavourites"></param>
        [WebMethod]
        public void UpdateFavouriteReleases(int ID, bool bFavourites)
        {
            using (var db = new MusicEntities())
            {
                Release tb = (from a in db.Releases.Where(a => a.ReleaseID == ID)
                              select a).SingleOrDefault();
                tb.bFavourites = bFavourites;
                db.SaveChanges();
            }
        }
        /// <summary>
        /// this method gets an artist release per artist
        /// </summary>
        /// <param name="ID"></param>
        /// <returns></returns>
        [WebMethod]
        public List<Releases> getArtistReleases(int ID)
        {
            using (var db = new MusicEntities())
            {
                return (from a in db.Artists.Where(a => a.Id == ID)
                        from b in db.Releases.Where(b => a.Id == b.ArtistID)
                        select new Releases
                        {
                            ID = (int)b.ReleaseID,
                            Title = b.Title,
                            Status = b.Status,
                            Label = b.Label,
                            NumberOfTracks = (int)b.NumberOfTracks,
                            OtherArtists = b.OtherArtists,
                            YearRelease = b.YearRelease,
                            bFavourite = (bool?)b.bFavourites ?? false
                        }).ToList<Releases>();
            }
        }
        /// <summary>
        /// this method returns a list of favourite releases
        /// </summary>
        /// <returns></returns>
        [WebMethod]
        public List<Releases> getFavouriteReleases()
        {
            using (var db = new MusicEntities())
            {
                return (
                        from b in db.Releases.Where(b => b.bFavourites == true)
                        select new Releases
                        {
                            ID = (int)b.ReleaseID,
                            Title = b.Title,
                            Status = b.Status,
                            Label = b.Label,
                            NumberOfTracks = (int)b.NumberOfTracks,
                            OtherArtists = b.OtherArtists,
                            YearRelease = b.YearRelease,
                            bFavourite = (bool?)b.bFavourites ?? false
                        }).ToList<Releases>();
            }
        }

    }

    public class Artists
    {
        public int ID { get; set; }
        public string ArtistName { get; set; }
        public string Country { get; set; }
        public string Aliases { get; set; }
        public Nullable<bool> Favourites { get; set; }
        public Nullable<bool> ShortList { get; set; }
    }

    public class Releases
    {
        public int ID { get; set; }
        public string Title { get; set; }
        public string Status { get; set; }
        public string Label { get; set; }
        public int NumberOfTracks { get; set; }
        public string OtherArtists { get; set; }
        public string YearRelease { get; set; }
        public bool? bFavourite { get; set; }

    }

}
