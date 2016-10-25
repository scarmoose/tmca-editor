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
            MessageBox.Show("Save As something!"); ;
        }
    }
}
