using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;

namespace PrototypeGuiCompositor30.Commands
{
    class SelectScreenCommand:ICommand
    {
        private IScreen _oldScreen;
        private IScreen _newScreen;


        public SelectScreenCommand(IScreen oldScreen, IScreen newScreen)
        {
            _oldScreen = oldScreen;
            _newScreen = newScreen;
            Execute();
        }
        public void Execute()
        {
            Console.WriteLine($"mudando tela ativa para {_newScreen.Name}");
            ProgramManager.ActiveScreen.Screen = _newScreen;
        }
        public void Undo()
        {
            Console.WriteLine($"mudando tela ativa para {_oldScreen.Name}");
            ProgramManager.ActiveScreen.Screen = _oldScreen;
        }
        public void Redo()
        {
            Execute();
        }
    }
}
