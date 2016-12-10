using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace qianrushi.Controllers
{
    public class RegisterController : Controller
    {
        //
        // GET: /Register/

        //注册视图
        public ActionResult Register()
        {
            return View();
        }

        //接收注册数据
        public ActionResult ReceiveRegister()
        {
            return null;
        }
	}
}