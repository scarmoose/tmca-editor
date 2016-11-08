using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Input;

namespace tmca_uml.Commands.View
{
    class ToolboxToggleCommand : ICommand
    {
        public string Header { get; set; }
        public event EventHandler CanExecuteChanged;
        private bool visible { get; set; }

        public ToolboxToggleCommand()
        {
            Header = "Toolbox";
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
                    mainWindow.data.ToolBoxVisability = "Hidden";
                    visible = false;
                }
                else if (visible == false)
                {
                    mainWindow.data.resetStatusBar();
                    mainWindow.data.ToolBoxVisability = "Visible";
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
