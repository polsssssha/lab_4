using System;
using AlgorythmsLab3.Interface;

namespace SortConsoleApp.menu
{
    public class ExitMenuItem : MenuItem
    {
        public ExitMenuItem() : base("Выход")
        {
        }

        public override void Execute()
        {
            Console.WriteLine("Выход");
        }
    }
}