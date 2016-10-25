using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Input;

namespace tmca_uml.Commands
{
    public class SaveAsCommand : ICommand
    {
        public string Header { get; set; }


        public event EventHandler CanExecuteChanged;

        public SaveAsCommand()
        {
            Header = "Save As...";
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
                mainWindow.data.StatusBarLabel = "The Project was saved as: " + "(xxxx)" + " succesfully...";
            }
            else
            {
                mainWindow.data.StatusBarLabel = "Save As failed!";
            }
        }
    }
}
