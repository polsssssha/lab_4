using SortConsoleApp.menu;
using SortConsoleApp.menu.menus;

namespace SortConsoleApp
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            Menu menu = new MainMenu();
            menu.Start();
        }
    }
}