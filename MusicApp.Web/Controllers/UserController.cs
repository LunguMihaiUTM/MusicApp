using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MusicApp.Web.Controllers
{
    public class UserController : Controller
    {
        // GET: User
        public ActionResult _UserHeader()
        {
            return View();
        }
    }
}