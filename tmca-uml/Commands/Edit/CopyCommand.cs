using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Input;

namespace tmca_uml.Commands.Edit
{
    public class CopyCommand : ICommand

    {
        public string Header { get; set; }
        public KeyGesture Gesture { get; set; }
        public event EventHandler CanExecuteChanged;

        public CopyCommand()
        {
            Header = "Copy";

            Gesture = new KeyGesture(Key.C, ModifierKeys.Control);
        }

        public bool CanExecute(object parameter)
        {
            return true;
        }

        public void Execute(object parameter)
        {
            MessageBox.Show("Copy something!");
        }

        public string GestureText
        {
            get { return Gesture.GetDisplayStringForCulture(CultureInfo.CurrentUICulture); }
        }
    }
}
