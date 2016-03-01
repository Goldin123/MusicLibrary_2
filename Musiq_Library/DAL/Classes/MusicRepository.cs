using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Musiq_Library.Models;

namespace Musiq_Library.DAL.Classes
{
    public class MusicRepository : Musiq_Library.DAL.Interface.IMusic
    {
        //Get artist list
        wsMusicBrainz.MusicBrainzSoapClient _MusicBrainz = new wsMusicBrainz.MusicBrainzSoapClient();
        public List<Musiq_Library.Models.Artist> getArtists(string Name)
        {
            try
            {
                using (var db = new MusicEntities())
                {
                    return (from a in db.Artists.Where(a => a.ArtistName.Contains(Name))
                            select new Musiq_Library.Models.Artist
                            {
                                ID = (int)a.Id,
                                ArtistName = a.ArtistName,
                                Country = a.Country,
                                Aliases = a.Aliases,
                                ShortList = a.ShortList
                            }).ToList<Musiq_Library.Models.Artist>();
                }
            }
            catch
            {
                return null;
            }
        }

        //Get artist shortlist list
        public List<Musiq_Library.Models.Artist> getShortListArtist(string Name)
        {
            try
            {
                using (var db = new MusicEntities())
                {
                    return (from a in db.Artists.Where(a => a.ArtistName.Contains(Name) && a.ShortList == true)
                            select new Musiq_Library.Models.Artist
                            {
                                ID = (int)a.Id,
                                ArtistName = a.ArtistName,
                                Country = a.Country,
                                Aliases = a.Aliases,
                                Favourites = (bool?)a.Favourites ?? false
                            }).ToList<Musiq_Library.Models.Artist>();
                }
            }
            catch
            {
                return null;
            }
        }

        //add to shortlist
        public void AddRemoveToShort(int ID, bool bShortlist)
        {
            using (var db = new MusicEntities())
            {
                Artist tb = (from a in db.Artists.Where(a => a.Id == ID)
                             select a).SingleOrDefault();
                tb.ShortList = bShortlist;
                db.SaveChanges();
            }

        }

        // this is to update the web service releases
        public void AddRemoveToReleaseFavourites(int ID, bool bFavourites)
        {
            _MusicBrainz.UpdateFavouriteReleases(ID, bFavourites);
        }
        //add to favourites
        public void AddRemoveToFavourites(int ID, bool bFavourites)
        {
            using (var db = new MusicEntities())
            {
                Artist tb = (from a in db.Artists.Where(a => a.Id == ID)
                             select a).SingleOrDefault();
                tb.Favourites = bFavourites;
                db.SaveChanges();
            }
        }
        // get artists from web service
        public List<Musiq_Library.Models.Artist> getWebServiceArtists(string Name)
        {
            try
            {
                var _results = _MusicBrainz.getArtistList(Name);
                List<Musiq_Library.Models.Artist> _lstTemp = new List<Musiq_Library.Models.Artist>();
                var rst = (from a in _results
                          select new Musiq_Library.Models.Artist
                          {
                              ID = (int)a.ID,
                              ArtistName = a.ArtistName,
                              Country = a.Country,
                              Aliases = a.Aliases,
                              Favourites = a.Favourites
                          }).ToList<Musiq_Library.Models.Artist>();
                return rst;
            }
            catch
            {
                return null;
            }
        }
        // get artists releases from web service
        public List<Musiq_Library.Models.Releases> getWebServiceReleaseInformation(int ID)
        {
            try
            {
                var _results = _MusicBrainz.getArtistReleases(ID);
                List<Musiq_Library.Models.Releases> _lstTemp = new List<Musiq_Library.Models.Releases>();
                var bb = (from a in _results
                          select new Musiq_Library.Models.Releases
                          {
                              ID = (int)a.ID,
                              YearRelease = a.YearRelease,
                              Status = a.Status,
                              Label = a.Label,
                              NumberOfTracks = (int)a.NumberOfTracks,
                              bFavourite = (bool)a.bFavourite
                          }).ToList<Musiq_Library.Models.Releases>();
                return bb;
            }
            catch
            {
                return null;
            }
        }
        //get a list of favourite releases 
        public List<Musiq_Library.Models.Releases> getWebServiceFavouriteReleases()
        {
            try
            {
                var _results = _MusicBrainz.getFavouriteReleases();
                List<Musiq_Library.Models.Releases> _lstTemp = new List<Musiq_Library.Models.Releases>();
                var bb = (from a in _results
                          select new Musiq_Library.Models.Releases
                          {
                              ID = (int)a.ID,
                              YearRelease = a.YearRelease,
                              Status = a.Status,
                              Label = a.Label,
                              NumberOfTracks = (int)a.NumberOfTracks,
                              bFavourite = (bool)a.bFavourite
                          }).ToList<Musiq_Library.Models.Releases>();
                return bb;
            }
            catch
            {
                return null;
            }
        }
         
        // get a list of favourites artist
        public List<Musiq_Library.Models.Artist> getFavouriteArtists()
        {
            try
            {
                using (var db = new MusicEntities())
                {
                    return (from a in db.Artists.Where(a=> a.Favourites == true)
                            select new Musiq_Library.Models.Artist
                            {
                                ID = (int)a.Id,
                                ArtistName = a.ArtistName,
                                Country = a.Country,
                                Aliases = a.Aliases,
                                Favourites = a.Favourites
                            }).ToList<Musiq_Library.Models.Artist>();
                }
            }
            catch
            {
                return null;
            }
        }

    }
}