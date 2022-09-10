using System;
using System.Collections.Generic;
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
    //uasage
    //    if (customDialog.ShowDialog() == true)
    //{
    //     lblFirstName.Content = customDialog.Answer;
    //}
    //OR
    //CustomDialog customDialog = new CustomDialog("Please enter your name:", "John Doe");
    //customDialog.ShowDialog();

/// <summary>
/// Interaction logic for CustomDialog.xaml
/// </summary>
public partial class CustomDialog : Window
    {
        public CustomDialog(string question, string defaultAnswer = "")
     
        {
            InitializeComponent();
            lblQuestion.Content = question;
            txtAnswer.Text = defaultAnswer;
        }

        
        private void btnDialogOk_Click(object sender, RoutedEventArgs e)
        {
            this.DialogResult = true;
        }

        private void Window_ContentRendered(object sender, EventArgs e)
        {
            txtAnswer.SelectAll();
            txtAnswer.Focus();
        }

        public string Answer
        {
            get { return txtAnswer.Text; }
        }

    }
}
