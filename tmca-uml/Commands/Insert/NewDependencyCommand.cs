﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Input;

namespace tmca_uml.Commands.Insert
{
    public class NewDependencyCommand : ICommand
    {
        public string Header { get; set; }
        public event EventHandler CanExecuteChanged;

        public NewDependencyCommand()
        {
            Header = "New Dependency";
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
                mainWindow.data.resetStatusBar();
                MessageBox.Show("New Dependency");
            }
        }
    }
}
