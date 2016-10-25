using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Input;

namespace tmca_uml.Commands.Help
{
    public class HelpCommand : ICommand
    {
        public string Header { get; set; }

        public KeyGesture Gesture { get; set; }

        public event EventHandler CanExecuteChanged;

        public HelpCommand()
        {
            Header = "Help";

            Gesture = new KeyGesture(Key.F1);
        }

        public bool CanExecute(object parameter)
        {
            return true;
        }

        public void Execute(object parameter)
        {
            var mainWindow = (Application.Current.MainWindow as MainWindow);
            if (mainWindow != null)
            {
                MessageBox.Show("Help info...");
                mainWindow.data.StatusBarLabel = "Help was shownes succesfully...";
            }
            else
            {
                mainWindow.data.StatusBarLabel = "Show Help failed!";
            }
        }

        public string GestureText
        {
            get { return Gesture.GetDisplayStringForCulture(CultureInfo.CurrentUICulture); }
        }
    }
}
