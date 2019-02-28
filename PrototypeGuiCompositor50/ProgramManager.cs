using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xceed.Wpf.Toolkit.PropertyGrid;

//using WPG;

namespace PrototypeGuiCompositor30
{
    public static class ProgramManager
    {
        public static ObservableCollection<IScreen> screens;
//        public static List<IScreen> screens;
        //public static IScreen ActiveScreen= new DefaultScreen();
        public static PropertyGrid propGrid  = new PropertyGrid();
        public static ActScreenManager ActiveScreen = new ActScreenManager();
        public static ActControlManager ActiveControl= new ActControlManager();
        public static void InitializeProgram()
        {
            screens = ScreensFactory.LoadScreenList();
            ActiveScreen.Screen = screens[0];
            ActiveControl= new ActControlManager();
            propGrid = new PropertyGrid();
           // ActiveScreen = screens[0];
        }

    }
}
