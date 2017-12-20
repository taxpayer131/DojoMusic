using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace DojoMusic.Controllers
{

	public class HomeController : Controller

	{

		private SongsDBEntities _db = new SongsDBEntities(); 

		public ActionResult Index()

		{

			return View(SongsDB.ToList());

		}

	}

}