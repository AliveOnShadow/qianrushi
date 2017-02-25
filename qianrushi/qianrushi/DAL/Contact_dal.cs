using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;
namespace qianrushi.DAL
{
    public class Contact_dal
    {
       public DataTable GetContact()
        {
            string sqlStr = "select Name, Contact, Class from TheContact";
            return SqlHelpers.ExecuteDataTable(sqlStr);
        }
    }
}