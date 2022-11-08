using System.Collections.Generic;
using AlgorythmsLab3.Interface;

namespace SortConsoleApp.menu.menus
{
    public class MainMenu : Menu
    {
        public MainMenu() : base(title: "", items: new List<MenuItem>()
        {
            new TextSorting(),
        })
        {
        }
    }
}