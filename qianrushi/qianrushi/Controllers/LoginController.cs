using qianrushi.BLL;
using qianrushi.DAL;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
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
            string UserName = Request["UserName"];
            string Password = Request["Password"];

            if(UserName==""||Password=="")
            {
                return View("Login");
            }
            UserLogin_bll userlogin_bll = new UserLogin_bll();
            if (userlogin_bll.UserLoginYes(UserName, Password))
            {
                return View("../Home/Index");
            }
            else
                return View("../Register/Register");
        }
	}
}