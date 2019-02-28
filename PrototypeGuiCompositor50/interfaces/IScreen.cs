﻿using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;


namespace PrototypeGuiCompositor30
{
    public interface IScreen
    {
         ObservableCollection<IScreen> Childrens { get; set; }
      
        Canvas Screen { get; set; }
        ObservableCollection<IContent> Elements { get; set;}
        IContent ActiveElement { get; set; }
         string Name { get; set; }
        bool IsAllSelected { get; set; }
        void insertChildren(IScreen children);
        void UnselectAll();
        bool GetActiveExist();
    }
}
