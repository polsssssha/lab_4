using System;
using System.Linq;
using System.Text.RegularExpressions;
using AlgorythmsLab3.Interface;
using SortConsoleApp.algorithms;
using SortConsoleApp.menu.menus.utils;

namespace SortConsoleApp.menu.menus;

public abstract class AlgorithmStringSortMenu : MenuItem
{
    private StringSort _sort;

    protected AlgorithmStringSortMenu(StringSort sort, string title, bool isSelected = false) : base(title: title,
        isSelected)
    {
        _sort = sort;
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
                Console.WriteLine("Введите задержку в миллисекундах");
                var inputDelay = Console.ReadLine();
                if (!int.TryParse(inputDelay, out var delay))
                {
                    throw new ArgumentException("Введенные данные содержат не допустимые значения");
                }

                _sort.Delay = delay;

                var inputListWord = inputText.Trim().Split(new[] {' ', ',', '.', '(', ')'}).Where(x => x != "")
                    .ToList();
                var result = _sort.Sort(inputListWord).ToList();
                for (int i = 0; i < result.Count; i++)
                {
                    Console.WriteLine($"{i}) {result[i]} ");
                }

                var wordCount = AlgorithmsUtil.Count(result);
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