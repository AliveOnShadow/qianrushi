using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using qianrushi.BLL;
using System.Data;
using System.Web.Script.Serialization;
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
            string UserName = Request["UserName"];
            string Password = Request["Password"];
            string Group = Request["Group"];
            string WorkPlace = Request["WorkPlace"];
            string Contact = Request["Contact"];
            Register_bll register = new Register_bll();
            UserLogin_bll login = new UserLogin_bll();
            if (UserName != "" && Password != "" && Group != "" && Contact != "" || (UserName != null && Password != null && Group != null && Contact != null))
            {
                if (register.ExRegister(UserName, Password, Group, Contact, WorkPlace))
                    if (login.UserLoginYes(UserName, Password))
                    {
                        return View("../Home/Index");
                    }
                    else
                        return View("../Login/Login");
                else
                    return View("RegisterFail");
            }
            else
                return View("Register");
        }
	}
}