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
        public string employer1;
        public string employer2;
        public string staffLogin;
        public string staffPass;
        public Environment(string siteName, string siteUrl, string zipCode, string state, string abbreviation, string employer1, string employer2, string staffLogin, string staffPass)
        {
            this.siteName = siteName;
            this.siteUrl = siteUrl;
            this.zipCode = zipCode;
            this.state = state;
            this.abbreviation = abbreviation;
            this.employer1 = employer1;
            this.employer2 = employer2;
            this.staffLogin = staffLogin;
            this.staffPass = staffPass;
        }

        public static List<Environment> CreateEnvironments()
        {
            List<Environment> list = new List<Environment>
            {
                new Environment("IA UAT", "https://uat-app-vos19000000-gus.geosolinc.com/vosnet/default.aspx", "50031", "Iowa", "IA", "Target", "Toyota", "GSISA0", "GeoIAGUSSol22*@"),
                new Environment("IA QA", "https://qa-app-vos19000000-gus.geosolinc.com/vosnet/default.aspx", "50031", "Iowa", "IA", "Target", "Toyota", "GSISA0", "GeoIAGUSSol22*@"),
                new Environment("PR UAT", "https://uat-app-vos72000000.geosolinc.com/vosnet/default.aspx", "00780", "Puerto Rico", "PR", "Publix", "Toyota", "GSISA0", "GeoIAGUSSol22*@"),
                new Environment("PR QA", "https://qa-app-vos72000000.geosolinc.com/vosnet/default.aspx", "00780", "Puerto Rico", "PR", "Publix", "Toyota", "GSISA0", "GeoIAGUSSol22*@"),
                new Environment("DC UI UAT", "https://uat-app-vos11000000-ui.geosolinc.com/vosnet/default.aspx", "20010", "District of Columbia", "DC", "Target", "Toyota", "GSISA0", "GeoIAGUSSol22*@"),
                new Environment("DC UI QA", "https://qa-app-vos11000000-ui.geosolinc.com/vosnet/default.aspx", "20010", "District of Columbia", "DC", "Target", "Toyota", "GSISA0", "GeoIAGUSSol22*@"),
                new Environment("DC PFL UAT", "https://uat-app-vos11980000.geosolinc.com/vosnet/default.aspx", "20010", "District of Columbia", "DC", "Target", "Toyota", "GSISA0", "GeoIAGUSSol22*@"),
                new Environment("DC PFL CUAT", "https://cuat-app-vos11980000.geosolinc.com/vosnet/default.aspx", "20010", "District of Columbia", "DC", "Target", "Toyota", "GSISA0", "GeoIAGUSSol22*@"),
                new Environment("DC PFL STAGING", "https://staging-app-vos11980000.geosolinc.com/vosnet/default.aspx", "20010", "District of Columbia", "DC", "Target", "Toyota", "GSISA0", "GeoIAGUSSol22*@"),
                new Environment("PA UAT", "https://uat-app-vos42000000.geosolinc.com/vosnet/default.aspx", "17104", "Pennsylvania", "PA", "Target", "Toyota", "GSISA0", "GeoIAGUSSol22*@"),
                new Environment("PA CIT", "https://cit.benefits.uc.pa.gov/vosnet/default.aspx", "17104", "Pennsylvania", "PA", "Target", "Toyota", "Gsisa02", "UIgsiA1*"),
                new Environment("PA QA", "https://qa-app-vos42000000.geosolinc.com/vosnet/default.aspx", "17104", "Pennsylvania", "PA", "Target", "Toyota", "GSISA0", "GeoIAGUSSol22*@"),
                new Environment("NE UAT", "https://uat-app-vos31000000.geosolinc.com/vosnet/default.aspx", "68104", "Nebraska", "NE", "Target", "Toyota", "GSISA0", "GeoIAGUSSol22*@"),
                new Environment("NE QA", "https://qa-app-vos31000000.geosolinc.com/vosnet/default.aspx", "68104", "Nebraska", "NE", "Target", "Toyota", "GSISA0", "GeoIAGUSSol22*@"),
                new Environment("NE STAGING", "https://staging-app-vos31000000.geosolinc.com/vosnet/default.aspx", "68104", "Nebraska", "NE", "gsitaxmc080701", "Toyota", "GSISA0", "GeoIAGUSSol22*@"),
                new Environment("LA UAT", "https://uat-app-vos22000000.geosolinc.com/vosnet/default.aspx", "70803", "Louisiana", "LA", "Target", "Toyota", "GSISA0", "GeoIAGUSSol22*@"),
                new Environment("LA QA", "https://qa-app-vos22000000.geosolinc.com/vosnet/default.aspx", "70803", "Louisiana", "LA", "Target", "Toyota", "GSISA0", "GeoIAGUSSol22*@"),
                new Environment("TN UAT", "https://uat-app-vos47000000.geosolinc.com/vosnet/default.aspx", "37243", "Tennessee", "TN", "Target", "Toyota", "GSISA0", "GeoIAGUSSol22*@"),
                new Environment("TN QA", "https://qa-app-vos47000000.geosolinc.com/vosnet/default.aspx", "37243", "Tennessee", "TN", "Target", "Toyota", "GSISA0", "GeoIAGUSSol22*@"),
                new Environment("AZ UAT", "https://uat-app-vos04990000.geosolinc.com/vosnet/default.aspx", "86438", "Arizona", "AZ", "Target", "Toyota", "GSISA0", "GeoIAGUSSol22*@")
            };
            return list;
        }
    }

}
