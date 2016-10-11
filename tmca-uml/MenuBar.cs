using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace tmca_uml
{
    class MenuBar
    {
        public ICommand NewProjectCommand { get; set; }

        public MenuBar()
        {
            NewProjectCommand = new NewProjectCommand();
        }
    }
}
