﻿
namespace DapperConnectionApp
{
    using System;
    using System.Collections.Generic;
    // added as refference
    using System.Configuration;
    //
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;
    public static class Helper
    {
       public static string CnnStringValue (string name)
        {
            // when we put our conn string as a name parameter into this method  it will look up into app.config
           return  ConfigurationManager.ConnectionStrings[name].ConnectionString;
        }
    }
}
