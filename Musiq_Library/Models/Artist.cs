using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Musiq_Library.Models
{
    public class Artist
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