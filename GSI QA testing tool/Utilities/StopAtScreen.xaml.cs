using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace GSI_QA_testing_tool.Utilities
{
    /// <summary>
    /// Interaction logic for StopAtScreen.xaml
    /// </summary>
    public partial class StopAtScreen : Window
    {
        public StopAtScreen()
        {
            InitializeComponent();
        }

        private void BtnStopAtScreenOk_Click(object sender, RoutedEventArgs e)
        {
            foreach (var item in LbxStopAt.SelectedItems)

            {
                Data._StopAt += item.ToString() + ", ";
            }
          //  ListBoxItem lbi = ((sender as ListBox).SelectedItem as ListBoxItem);
         //   tb.Text = "   You selected " + lbi.Content.ToString() + ".";
             Debug.WriteLine(Data._StopAt);
    
            Close();
        }
    }
}
