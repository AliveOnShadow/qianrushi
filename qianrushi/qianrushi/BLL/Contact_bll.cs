using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;
using qianrushi.DAL;
using Newtonsoft.Json;

namespace qianrushi.BLL
{
    public class Contact_bll
    {
        public string GetJsonOfContactData()
        {
            Contact_dal con = new Contact_dal();
            DataTable dt = new DataTable();
            string result = "";
            dt = con.GetContact();
            if(dt!=null)
                result = JsonConvert.SerializeObject(dt);
            return result;
        }
    }
}