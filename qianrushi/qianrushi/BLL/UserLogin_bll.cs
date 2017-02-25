using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using qianrushi.DAL;
using qianrushi.Models;

namespace qianrushi.BLL
{
    public class UserLogin_bll
    {
        public bool UserLoginYes(string UserName,string Password)
        {
            UserLogin_dal user_dal = new UserLogin_dal();
            string dbPassword = user_dal.GetPwd(UserName);
            if (dbPassword == Password)
            {
                return true;
            }
            else
                return false;
        }
    }
}