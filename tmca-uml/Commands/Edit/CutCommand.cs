﻿using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Input;

namespace tmca_uml.Commands.Edit
{
    public class CutCommand : ICommand
    {
        public string Header { get; set; }
        public KeyGesture Gesture { get; set; }
        public event EventHandler CanExecuteChanged;

        public CutCommand()
        {
            Header = "Cut";

            Gesture = new KeyGesture(Key.N, ModifierKeys.Control);
        }

        public bool CanExecute(object parameter)
        {
            return true;
        }

        public void Execute(object parameter)
        {
            MessageBox.Show("Cut");
        }

        public string GestureText
        {
            get { return Gesture.GetDisplayStringForCulture(CultureInfo.CurrentUICulture); }
        }
    }
}