using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Web;

namespace qianrushi.DAL
{
    public class SqlConnectionString
    {
        public static string sqlConnectionString = ConfigurationManager.ConnectionStrings["ConStr"].ConnectionString;
    }
}