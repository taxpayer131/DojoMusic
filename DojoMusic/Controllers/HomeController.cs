using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace DojoMusic.Controllers
{

	public class HomeController : Controller

    {

        // GET: /Songs

        public ActionResult Index()

        {

            var entities = new SongDBEntities();

            return View(entities.SongSet.ToList());

        }

    }

}