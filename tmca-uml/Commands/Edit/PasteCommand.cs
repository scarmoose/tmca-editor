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
    public class PasteCommand : ICommand
    {
        public string Header { get; set; }

        public KeyGesture Gesture { get; set; }

        public event EventHandler CanExecuteChanged;

        public PasteCommand()
        {
            Header = "Paste";

            Gesture = new KeyGesture(Key.V, ModifierKeys.Control);
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
                mainWindow.data.StatusBarLabel = "The content was pasted successfully...";
                mainWindow.data.StatusBarBackground = "";
            }
            else
            {
                mainWindow.data.StatusBarLabel = "Paste failed!";
            }
        }

        public string GestureText
        {
            get { return Gesture.GetDisplayStringForCulture(CultureInfo.CurrentUICulture); }
        }
    }
}
