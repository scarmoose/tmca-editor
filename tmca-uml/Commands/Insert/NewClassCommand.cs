using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Input;

namespace tmca_uml.Commands.Insert
{
    public class NewClassCommand : ICommand
    {
        public string Header { get; set; }
        public event EventHandler CanExecuteChanged;

        public NewClassCommand()
        {
            Header = "New Class";
        }

        public bool CanExecute(object parameter)
        {
            return true;
        }

        public void Execute(object parameter)
        {
            MessageBox.Show("New Class");
        }
    }
}
