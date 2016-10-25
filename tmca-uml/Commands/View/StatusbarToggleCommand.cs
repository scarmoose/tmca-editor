using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Input;

namespace tmca_uml.Commands.View
{
    public class StatusbarToggleCommand : ICommand
    {
        public string Header { get; set; }
        public event EventHandler CanExecuteChanged;
        private bool visible { get; set; }

        public StatusbarToggleCommand()
        {
            Header = "Statusbar";
            visible = true;
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
                if (visible == true)
                {
                    mainWindow.data.StatusBarVisability = "Hidden";
                    visible = false;
                }
                else if (visible == false)
                {
                    mainWindow.data.StatusBarLabel = "";
                    mainWindow.data.StatusBarBackground = "";
                    mainWindow.data.StatusBarVisability = "Visible";
                    visible = true;
                }
                
            }
        }

        public bool Checked(object sender, EventArgs e)
        {
            return true;
        }

        public bool Unchecked(object sender, EventArgs e)
        {
            return true;
        }
    }
}
