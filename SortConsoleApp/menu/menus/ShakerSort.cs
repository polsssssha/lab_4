﻿using System;
using System.Linq;
using System.Text.RegularExpressions;
using AlgorythmsLab3.Interface;
using SortConsoleApp.algorithms;
using SortConsoleApp.menu.menus.utils;

namespace SortConsoleApp.menu.menus;

public class ShakerSort : MenuItem
{
    public ShakerSort(bool isSelected = false) : base(title: "Shaker Сортировка текста", isSelected)
    {
    }

    public override void Execute()
    {
        do
        {
            ConsoleUtil.ClearScreen();
            Console.WriteLine($"[ {Title.ToUpper()} ]\n");
            Console.CursorVisible = true;
                
            Console.WriteLine("Введите текст, слова которого должны быть отсортированы: ");
            string inputText = Console.ReadLine();
            if (string.IsNullOrEmpty(inputText))
            {
                Console.WriteLine("Введенная строка пуста!");
            }
            else if (new Regex("[0-9]", RegexOptions.Compiled | RegexOptions.IgnoreCase)
                         .Matches(inputText).Count > 0)
            {
                Console.WriteLine("Строка содержит числовые значения!");
            }
            else
            {
                var inputListWord = inputText.Trim().Split(' ').Where(x => x != "").ToList();
                var result = algorithms.ShakerSort.Sort(inputListWord).ToList();
                for (int i = 0; i < result.Count; i++)
                {
                    Console.WriteLine($"{i}) {result[i]} ");
                }

                var wordCount = ABCSort.Count(result);
                Console.WriteLine("\nПодсчет количества слова в тексте:");
                foreach (var word in wordCount)
                {
                    Console.WriteLine($"{word.Key} [ {word.Value} ]");
                }
            }
                
            Console.CursorVisible = false;
        } while (ConsoleUtil.Continue());
    }
}