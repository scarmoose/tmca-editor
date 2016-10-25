﻿using System.Windows.Input;
using tmca_uml.Commands;
using tmca_uml.Commands.Edit;
using tmca_uml.Commands.Insert;
using tmca_uml.Commands.View;

namespace tmca_uml
{
    class MenuBar
    {
        //File
        public ICommand NewProjectCommand { get; set; }
        public ICommand OpenProjectCommand { get; set; }
        public ICommand ExitCommand { get; set; }
        public ICommand SaveCommand { get; set; }
        public ICommand SaveAsCommand { get; set; }

        //Edit
        public ICommand CopyCommand { get; set; }
        public ICommand CutCommand { get; set; }
        public ICommand DeleteCommand { get; set; }
        public ICommand PasteCommand { get; set; }
        public ICommand RedoCommand { get; set; }
        public ICommand UndoCommand { get; set; }

        //View
        public ICommand StatusbarToggleCommand { get; set; }
        public ICommand ToolboxToggleCommand { get; set; }
        public ICommand ZoomInCommand { get; set; }
        public ICommand ZoomOutCommand { get; set; }

        //Insert
        public ICommand NewClassCommand { get; set; }
        public ICommand NewDependencyCommand { get; set; }
        public ICommand NewTextBoxCommand { get; set; }

        //StatusBar
        public static string statusBarLabel { get; set; }

        public MenuBar()
        {
            //File
            NewProjectCommand = new NewProjectCommand();
            OpenProjectCommand = new OpenProjectCommand();
            ExitCommand = new ExitCommand();
            SaveCommand = new SaveCommand();
            SaveAsCommand = new SaveAsCommand();
            
            //Edit
            CopyCommand = new CopyCommand();
            CutCommand = new CutCommand();
            DeleteCommand = new DeleteCommand();
            PasteCommand = new PasteCommand();
            RedoCommand = new RedoCommand();
            UndoCommand = new UndoCommand();

            //View
            //StatusbarToggleCommand = new StatusbarToggleCommand();
            //ToolboxToggleCommand = new ToolboxToggleCommand();
            ZoomInCommand = new ZoomInCommand();
            ZoomOutCommand = new ZoomOutCommand();

            //Insert
            NewClassCommand = new NewClassCommand();
            NewDependencyCommand = new NewDependencyCommand();
            NewTextBoxCommand = new NewTextBoxCommand();
        }
    }
}
