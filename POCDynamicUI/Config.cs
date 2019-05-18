using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Web;

namespace POCDynamicUI
{
    public static class Config
    {
        public static string FilePath
        {
            get
            {
                return ConfigurationManager.AppSettings["FilePath"].ToString();
            }
        }
    }
}