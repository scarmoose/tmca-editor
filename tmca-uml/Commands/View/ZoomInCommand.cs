using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Input;

namespace tmca_uml.Commands.View
{
    public class ZoomInCommand : ICommand
    {
        public string Header { get; set; }

        public event EventHandler CanExecuteChanged;

        public ZoomInCommand()
        {
            Header = "Zoom In";
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
                mainWindow.data.StatusBarLabel = "Zoom In...";
            }
            else
            {
                mainWindow.data.StatusBarLabel = "Zoom In failed";
            }
        }
    }
}
