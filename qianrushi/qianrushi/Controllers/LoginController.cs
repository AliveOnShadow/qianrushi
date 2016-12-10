using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace qianrushi.Controllers
{
    public class LoginController : Controller
    {
        //
        // GET: /Login/

        //登陆视图
        public ActionResult Login()
        {
            return View();
        }


        //接受登陆数据
        public ActionResult ReceiveLogin()
        {
            return null;
        }
	}
}