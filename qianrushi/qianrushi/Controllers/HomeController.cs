using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using qianrushi.BLL;

namespace qianrushi.Controllers
{
    public class HomeController : Controller
    {
        //
        // GET: /Home/
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Contact()
        {
            Contact_bll contact_bll = new Contact_bll();
            string ConJson;
            ConJson = contact_bll.GetJsonOfContactData();
            ViewBag.Json = ConJson;
            return View();
        }
	}
}