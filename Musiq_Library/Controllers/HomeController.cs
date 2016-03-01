using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Musiq_Library.Controllers
{
    public class HomeController : Controller
    {
        //
        // GET: /Home/
        Musiq_Library.DAL.Interface.IMusic _Artist = new Musiq_Library.DAL.Classes.MusicRepository();

        public ActionResult LastFM()
        {
            List<Musiq_Library.Models.Artist> list = new List<Models.Artist>();
            if (Session["SearchArtist"] != null)
            {
                list = _Artist.getArtists(Session["SearchArtist"].ToString());
                return View(list);
            }
            else
            {
                return View(list);
            }
        }

        public ActionResult AddRemoveToArtistShortList(int id, bool bShortlist)
        {
            _Artist.AddRemoveToShort(id, bShortlist);
            return RedirectToAction("LastFM");
        }
        public ActionResult AddRemoveToArtistFavourites(int id, bool bFavourites)
        {
            _Artist.AddRemoveToFavourites(id, bFavourites);
            if (Request.Url.AbsoluteUri.ToString().Contains("LastFM"))
                return RedirectToAction("LastFM");
            else
                return RedirectToAction("Favourites");
        }

        public ActionResult AddRemoveReleaseFavourites(int id, bool bFavourites)
        {
            _Artist.AddRemoveToReleaseFavourites(id, bFavourites);
            if (Request.Url.AbsoluteUri.ToString().Contains("Musicbrainz"))
                return RedirectToAction("Musicbrainz");
            else
                return RedirectToAction("Favourites");
        }



        [HttpGet]
        public ActionResult SearchArtist(string search)
        {
            if (!String.IsNullOrEmpty(search))
                Session["SearchArtist"] = search;
            else
                Session["SearchArtist"] = null;

            return RedirectToAction("LastFM");
        }

        [HttpGet]
        public ActionResult WebServiceSearchArtist(string search)
        {
            if (!String.IsNullOrEmpty(search))
                Session["WebServiceSearchArtist"] = search;
            else
                Session["WebServiceSearchArtist"] = null;

            return RedirectToAction("Musicbrainz");
        }


        public ActionResult Musicbrainz()
        {
            List<Musiq_Library.Models.Artist> _list = new List<Models.Artist>();
            if (Session["WebServiceSearchArtist"] != null)
            {
                _list = _Artist.getWebServiceArtists(Session["WebServiceSearchArtist"].ToString());
                return View(_list);
            }
            else
            {
                return View(_list);
            }
        }

        public ActionResult ShowRelease(int id)
        {
            if (id > 0)
                Session["SearchArtistID"] = id;
            else
                Session["SearchArtistID"] = null;

            return RedirectToAction("Musicbrainz");
        }
        public ActionResult Favourites()
        {
            return View();
        }
    }
}