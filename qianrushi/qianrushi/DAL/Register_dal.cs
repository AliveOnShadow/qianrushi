using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.SqlClient;
using System.Data;

namespace qianrushi.DAL
{
    public class Register_dal
    {
        public bool ExRegister(string UserName,string Password,string Group,string Contact,string WorkPlace)
        {
            string sql = "SELECT theUserName FROM UserInfo WHERE theUserName=@UserName";
            SqlParameter[] theparameter = new SqlParameter[]
            {
                new SqlParameter("UserName",UserName)
            };
            if (UserName == Convert.ToString(SqlHelpers.ExecuteScalar(sql, theparameter)))
                return false;
            string sqlstr = "INSERT INTO UserInfo(theUserName, thePassword,theGroup,theContact,theWorkPlace) VALUES (@UserName, @Password, @Group, @Contact, @WorkPlace)";
            int i;            
            SqlParameter[] parameters = new SqlParameter[]
            {
                new SqlParameter("UserName",UserName),
                new SqlParameter("Password",Password),
                new SqlParameter("Group",Group),
                new SqlParameter("Contact",Contact),
                new SqlParameter("WorkPlace",WorkPlace)
            };
            
            i = SqlHelpers.ExecuteNonquery(sqlstr, parameters);
            if (i == 1)
                return true;
            else if (i == 0)
                return false;
            else
                throw new Exception("存储错误!");
        }
    }
}