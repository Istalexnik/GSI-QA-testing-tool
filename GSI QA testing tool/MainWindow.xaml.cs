using GSI_QA_testing_tool.Utilities;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Linq;
using System.Security.Claims;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows;

using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;

namespace GSI_QA_testing_tool
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        Thread thread;
        readonly List<Environment> envs = Environment.CreateEnvironments();

        public MainWindow()
        {
            InitializeComponent();
            InitialSetUpGUI();

        }

        public void InitialSetUpGUI()
        {
            CbxSite.Items.Clear();
            CbxClaimType.Items.Clear();

            foreach (Environment v in envs)
            {
                CbxSite.Items.Add(v.siteName);
            }
            for (int i = 0; i < Data._claimTypes.Length; i++)
            {
                CbxClaimType.Items.Add(Data._claimTypes[i]);
            }
            CbxSite.SelectedIndex = 0;
            CbxClaimType.SelectedIndex = 0;


            Data.SetUpInitialData();
            TxtSSN.Text = Data._SSN;
            TxtFirstName.Text = Data._FirstName;
            TxtLastName.Text = Data._LastName;
            TxtDOB.Text = Data._DOB;
            TxtWorkedFrom1.Text = Data._WorkedFrom1;
            TxtWorkedTo1.Text = Data._WorkedTo1;
            TxtWorkedFrom2.Text = Data._WorkedFrom2;
            TxtWorkedTo2.Text = Data._WorkedTo2;
            ChbSecondEmployer.IsChecked = Data._SecondEmployer;
            ChbStaff.IsChecked = Data._Staff;
            TxtEmail.Text = "Random";
            TxtPhone.Text = "Random";


        }

        public void ScreenBeforeRunning()
        {
            BtnStart.Visibility = Visibility.Visible;
            BtnStop.Visibility = Visibility.Hidden;
        }

        public void ScreenWhileRunning()
        {
            BtnStart.Visibility = Visibility.Hidden;
            BtnStop.Visibility = Visibility.Visible;
        }

        public void ScreenAfterRunning()
        {
            //pop up about claim created TO-DO
            ScreenBeforeRunning();
        }


        private void BtnStart_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                AssigningFromGUIToData();
                ScreenWhileRunning();
                thread = new Thread(() => Base.StartCreating(this));
                thread.SetApartmentState(ApartmentState.STA);
                thread.Start();
            }
            catch (Exception ex)
            {
                Debug.WriteLine(ex.Message);
            }
            finally
            {

            }

        }

        private void BtnStop_Click(object sender, RoutedEventArgs e)
        {
            thread.Abort();
            ScreenBeforeRunning();
        }

        private void BtnReset_Click(object sender, RoutedEventArgs e)
        {
            Base.KillChromeProcess(2);
            InitialSetUpGUI();

        }


        private void CbxSite_SelectionChanged(object sender, System.Windows.Controls.SelectionChangedEventArgs e)
        {
            string currentSite = null;
            foreach (Environment v in envs)
            {


                if (CbxSite.SelectedItem != null)
                {
                    currentSite = CbxSite.SelectedItem.ToString();
                }

                if (currentSite == v.siteName)
                {
                    TxtZIP.Text = v.zipCode;
                    TxtURL.Text = v.siteUrl;
                    TxtEmployer1.Text = v.employer1;
                    TxtEmployer2.Text = v.employer2;
                    Data._StaffLogin = v.staffLogin;
                    Data._StaffPass = v.staffPass;
                }
            }

            if (currentSite == "AZ UAT")
            {
                CbxClaimType.SelectedItem = "DUA";
            }
        }



        public void AssigningFromGUIToData()
        {
            Data._SSN = TxtSSN.Text;
            Data._FirstName = TxtFirstName.Text;
            Data._LastName = TxtLastName.Text;
            Data._DOB = TxtDOB.Text;
            Data._Employer1 = TxtEmployer1.Text;
            Data._WorkedFrom1 = TxtWorkedFrom1.Text;
            Data._WorkedTo1 = TxtWorkedTo1.Text;
            Data._Employer2 = TxtEmployer2.Text;
            Data._WorkedFrom2 = TxtWorkedFrom2.Text;
            Data._WorkedTo2 = TxtWorkedTo2.Text;
            Data._SecondEmployer = (bool)ChbSecondEmployer.IsChecked;
            Data._Staff = (bool)ChbStaff.IsChecked;
            Data._Site = CbxSite.SelectedItem.ToString();
            Data._URL = TxtURL.Text;
            Data._ZIP = TxtZIP.Text;


            Data._claimType = (int)CbxClaimType.SelectedIndex + 1;
            Data.NewLogin();
            Data.MakeEmail();
            Data.MakePhone();

            if (TxtEmail.Text != "Random" && TxtEmail.Text != "")
            {
                Data._Email = TxtEmail.Text;
            }

            if (TxtPhone.Text != "Random" && TxtPhone.Text != "")
            {
                Data._Phone = TxtPhone.Text;
            }



            Data.CheckForStateAndAbbr();
            Data.UpdateDataPane();
            Data.Printing();
        }

        private void BtnStopAt_Click(object sender, RoutedEventArgs e)
        {
            StopAtScreen StopAtSceen = new StopAtScreen();
            StopAtSceen.Show();
        }






    }
}
