using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Newtonsoft.Json.Linq;
using System.IO;

namespace EmployeesApp.Models
{
    public class MyJson
    {
        public static JArray get_json()
        {

            String path = HttpContext.Current.Server.MapPath("~/Models/employees.json");
            using (StreamReader r = new StreamReader(path))
            {
                string json_str = r.ReadToEnd();
                return JArray.Parse(json_str);
            }

        }
    }
}