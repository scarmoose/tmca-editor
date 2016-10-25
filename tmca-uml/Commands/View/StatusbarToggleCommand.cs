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

        public StatusbarToggleCommand()
        {
            Header = "Statusbar";
        }

        public bool CanExecute(object parameter)
        {
            return true;
        }

        public void Execute(object parameter)
        {
            MessageBox.Show("Statusbar");
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
