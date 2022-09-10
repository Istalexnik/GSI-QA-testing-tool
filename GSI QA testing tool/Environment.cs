using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GSI_QA_testing_tool
{
    class Environment
    {
        public string siteName;
        public string siteUrl;
        public string zipCode;
        public string state;
        public string abbreviation;

        public Environment(string siteName, string siteUrl, string zipCode, string state, string abbreviation)
        {
            this.siteName = siteName;
            this.siteUrl = siteUrl;
            this.zipCode = zipCode;
            this.state = state;
            this.abbreviation = abbreviation;
        }

        public static List<Environment> createEnvironments()
        {
            List<Environment> list = new List<Environment>();
            list.Add(new Environment("PA UAT", "https://uat-app-vos42000000.geosolinc.com/vosnet/default.aspx", "17104", "Pennsylvania", "PA"));
            list.Add(new Environment("IA UAT", "https://uat-app-vos19000000-gus.geosolinc.com/vosnet/default.aspx", "50031", "Iowa", "IA"));
            list.Add(new Environment("DC UI UAT", "https://uat-app-vos11000000-ui.geosolinc.com/vosnet/default.aspx", "20010", "District of Columbia", "DC"));
            list.Add(new Environment("DC PFL UAT", "https://uat-app-vos11980000.geosolinc.com/vosnet/default.aspx", "20010", "District of Columbia", "DC"));
            list.Add(new Environment("PR UAT", "https://uat-app-vos72000000.geosolinc.com/vosnet/default.aspx", "00780", "Puerto Rico", "PR"));
            list.Add(new Environment("NE UAT", "https://uat-app-vos31000000.geosolinc.com/vosnet/default.aspx", "68104", "Nebraska", "NE"));
            list.Add(new Environment("NE STAGING", "https://staging-app-vos31000000.geosolinc.com/vosnet/default.aspx", "68104", "Nebraska", "NE"));
            list.Add(new Environment("LA UAT", "https://uat-app-vos22000000.geosolinc.com/vosnet/default.aspx", "70803", "Louisiana", "LA"));
            list.Add(new Environment("TN UAT", "https://uat-app-vos47000000.geosolinc.com/vosnet/default.aspx", "37243", "Tennessee", "TN"));        
            return list;
        }
    }

}
