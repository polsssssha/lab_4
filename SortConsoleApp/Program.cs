using System;
using System.Collections.Generic;
using System.IO;
using AlgorythmsLab3.Tester;
using AlgorythmsLab3.Testing.Tester;
using SortConsoleApp.menu;
using SortConsoleApp.menu.menus;
using ABCSort = SortConsoleApp.algorithms.ABCSort;
using ShakerSort = SortConsoleApp.algorithms.ShakerSort;

namespace SortConsoleApp
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            Menu menu = new MainMenu();
            menu.Start();
            
            // TestTextSort(x => ABCSort.Sort(x), "ABC Sort", 1);
            // TestTextSort(x => ShakerSort.Sort(x), "Shaker Sort", 1);
        }

        private static void TestTextSort(Func<List<string>, ICollection<string>> func, string name, int iterCount)
        {
            var tester = new TimeTester();
            var tester2 = new MemoryTester();
            var allText = File.ReadAllText(Directory.GetCurrentDirectory() + "\\..\\..\\testText.txt").Split(' ');
            for (int i = 1; i <= 50_000; i += 1)
            {
                var testText = CopyTo(allText, i);
                
                Console.WriteLine($"Тест алгоритма: {name} | Итерация: {i}");
                tester.Test(() => func.Invoke(testText), iterCount, name);
                tester2.Test(() => func.Invoke(testText), iterCount, name);
            }

            tester.SaveAsExcel(Environment.GetFolderPath(Environment.SpecialFolder.Desktop), $"{name} - время");
            tester.AllResults.Clear();

            tester2.SaveAsExcel(Environment.GetFolderPath(Environment.SpecialFolder.Desktop), $"{name} - память");
            tester2.AllResults.Clear();
        }

        private static List<string> CopyTo(string[] array, int index)
        {
            List<string> list = new List<string>();
            for (int i = 0; i < index; i++)
            {
                list.Add(array[i]);
            }

            return list;
        }
    }
}