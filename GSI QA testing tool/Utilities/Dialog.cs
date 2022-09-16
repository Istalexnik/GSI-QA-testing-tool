using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace GSI_QA_testing_tool.Utilities
{
    public static class Dialog
    {
        public static void ShowDialog(string captionText, string messageText)
        {
            string messageBoxText = messageText;
            string caption = captionText;
            MessageBoxButton button = MessageBoxButton.OK;
            MessageBoxImage icon = MessageBoxImage.Warning;
            MessageBoxResult result;

            result = MessageBox.Show(messageBoxText, caption, button, icon, MessageBoxResult.Yes);
            

            switch (result)
            {
                case MessageBoxResult.Cancel:
                    // User pressed Cancel
                    break;
                case MessageBoxResult.Yes:
                    // User pressed Yes
                    break;
                case MessageBoxResult.No:
                    // User pressed No
                    break;
            }
        }

    }
}
