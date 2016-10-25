using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Input;

namespace tmca_uml.Commands.View
{
    public class ZoomOutCommand : ICommand
    {
        public string Header { get; set; }
        public event EventHandler CanExecuteChanged;

        public ZoomOutCommand()
        {
            Header = "Zoom Out";
        }

        public bool CanExecute(object parameter)
        {
            return true;
        }

        public void Execute(object parameter)
        {
            MessageBox.Show("Zoom out");
        }
    }
}
