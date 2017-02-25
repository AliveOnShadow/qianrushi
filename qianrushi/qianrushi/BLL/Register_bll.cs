using qianrushi.DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace qianrushi.BLL
{
    public class Register_bll
    {
        public bool ExRegister(string UserName, string Password, string Group, string Contact, string WorkPlace)
        {
            Register_dal register = new Register_dal();
            if (register.ExRegister(UserName, Password, Group, Contact, WorkPlace))
                return true;
            else
                return false;
        }
    }
}