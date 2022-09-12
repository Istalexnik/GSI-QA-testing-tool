﻿using GSI_QA_testing_tool.Utilities;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;

namespace GSI_QA_testing_tool
{
    public static class Data
    {
        public static string _URL;
        public static string _ZIP;
        public static string _Site;
        public static string _Login;
        public static string _SSN;
        public static string _FirstName = "Alex";
        public static string _LastName = "Istomin";
        public static string _DOB = "11/11/1959";
        public static string _Employer1 = "Amazon";
        public static string _Employer2 = "Walmart";
        public static string _DataPane = "";
        public static bool _SecondEmployer = false;
        public static string _WorkedFrom1 = "11/11/2020";
        public static string _WorkedTo1 = DateTime.Now.ToString("MM/dd/yyyy");
        public static string _WorkedFrom2 = "11/11/2020";
        public static string _WorkedTo2 = DateTime.Now.ToString("MM/dd/yyyy");
        public static int _claimType;
        public static string[] _claimTypes = { "Regular", "UCX", "UCFE", "CWC", "Alien", "PUA" };
        public static string[] _Employers = { "Publix", "Target", "Toyota", "Alex" };
        public static string _State;
        public static string _Abbreviation;
        public static bool _BasePeriod = true;
        public static string _CreditWeeks = "13";
        public static string _FIC = "CA";
        public static string _City = "City";
        public static string _Wages = "5000";
        public static string _Pass = "Olga2011!!!!!";
        public static string _Email;
        public static string _Address = "1010 Street Avenue";
        public static string _JobTitle = "test";
        public static string _DriverLicense = "D234765456";

        public static string MakeEmail() => _Email = $"{_Login}@geosolinc.com";

        public static string NewSSN() => "5" + Utilities.Rand.GenerateRandom("0123456789", 8);

        public static string NewAlienCardNumber() => "GSI" + Utilities.Rand.GenerateRandom("0123456789", 10);

        public static string NewUSCISNumber() => Utilities.Rand.GenerateRandom("0123456789", 9);

        public static void NewLogin()
        {
            _Login = "GSIUI" + HostName().Substring(0, 2) + Utilities.Rand.GenerateRandom("ABCDEFGHIJKLMNOPQRSTUVWXYZ", 7) + _claimType.ToString();
        }

        public static string HostName() => System.Net.Dns.GetHostName();

        public static void Printing()
        {
            Debug.WriteLine($"{_Site} {_claimType} {_Login} {_SSN} {_FirstName} {_LastName} {_DOB} {_ZIP} " +
                $"{_URL} {_Employer1} {_WorkedFrom1} {_WorkedTo1} {_SecondEmployer} {_Employer2} {_WorkedFrom2} {_WorkedTo2}");
        }

        public static void UpdateDataPane()
        {
               _DataPane = $"{_Login} {_SSN} {_Site} \n" + _DataPane;
        }

        public static void CheckForStateAndAbbr()
        {
            List<Environment> envs = Environment.CreateEnvironments();
            foreach (Environment v in envs)
            {
                if(_Site == v.siteName)
                {
                    _State = v.state;
                    _Abbreviation = v.abbreviation;
                }
            }
        }



        static Data()
        {

        }


    }
}
