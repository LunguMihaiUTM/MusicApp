using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MusicApp.Web.Controllers
{
    public class FreeMusicController : Controller
    {
        // GET: FreeMusic
        public ActionResult Index()
        {
            return View();
        }
    }
}