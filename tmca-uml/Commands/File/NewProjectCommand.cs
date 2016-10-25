using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Input;

namespace tmca_uml
{
    public class NewProjectCommand : ICommand
    {
        public string Header { get; set; }
        public KeyGesture Gesture { get; set; }
        public event EventHandler CanExecuteChanged;

        public NewProjectCommand()
        {
            Header = "New Project";

            Gesture = new KeyGesture(Key.N, ModifierKeys.Control);
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
                mainWindow.data.StatusBarLabel = "New Project created succesfully...";
            }
            else
            {
                mainWindow.data.StatusBarLabel = "New Project failed!";
            }
        }

        public string GestureText
        {
            get { return Gesture.GetDisplayStringForCulture(CultureInfo.CurrentUICulture); }
        }
    }
}
