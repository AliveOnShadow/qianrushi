using qianrushi.Models;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace qianrushi.DAL
{
    public class UserLogin_dal
    {
        public string GetPwd(string UserName)
        {
            string sqlStr = "select thePassword from UserInfo where theUserName=@UserName";
            return Convert.ToString(SqlHelpers.ExecuteScalar(sqlStr, new SqlParameter("UserName", UserName)));
        }
    }
}