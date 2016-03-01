using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Musiq_Library.DAL.Interface
{
    public interface IMusic
    {
        List<Musiq_Library.Models.Artist> getArtists(string Name);
        List<Musiq_Library.Models.Artist> getShortListArtist(string Name);
        void AddRemoveToShort(int ID, bool bShortlist);
        void AddRemoveToFavourites(int ID, bool bFavourites);
        List<Musiq_Library.Models.Artist> getWebServiceArtists(string Name);
        List<Musiq_Library.Models.Releases> getWebServiceReleaseInformation(int ID);
        void AddRemoveToReleaseFavourites(int ID, bool bFavourites);
        List<Musiq_Library.Models.Releases> getWebServiceFavouriteReleases();
        List<Musiq_Library.Models.Artist> getFavouriteArtists();

    }
}
