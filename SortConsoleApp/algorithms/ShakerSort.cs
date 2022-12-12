﻿using System;
using System.Collections.Generic;
using System.Threading;

namespace SortConsoleApp.algorithms;

public class ShakerSort : StringSort
{
    public ShakerSort() { }

    public override ICollection<string> Sort(List<string> words)
    {
        for (int i = 0; i < words.Count / 2; i++)
        {
            var swapFlag = false;
            for (int j = i; j < words.Count - i - 1; j++)
            {
                Thread.Sleep(Delay);
                if (CompareString(words[j].ToLower(), words[j + 1].ToLower()))
                {
                    Thread.Sleep(Delay);
                    Console.WriteLine($"\tСмена слов {words[j + 1]} и {words[j]} местами\n");
                    (words[j], words[j + 1]) = (words[j + 1], words[j]);
                    swapFlag = true;
                }
            }

            for (int j = words.Count - 2 - i; j > i; j--)
            {
                Thread.Sleep(Delay);
                if (CompareString(words[j - 1].ToLower(), words[j].ToLower()))
                {
                    Thread.Sleep(Delay);
                    Console.WriteLine($"\tСмена слов {words[j - 1]} и {words[j]} местами\n");
                    (words[j - 1], words[j]) = (words[j], words[j - 1]);
                    swapFlag = true;
                }
            }

            if (!swapFlag)
            {
                break;
            }
        }

        return words;
    }

    private bool CompareString(string s1, string s2)
    {
        Console.WriteLine($"Сравнение слов {s1} и {s2}");
        var min = Math.Min(s1.Length, s2.Length);
        for (int i = 0; i < min; i++)
        {
            if (s1[i] == s2[i])
            {
                continue;
            }

            if (s1[i] > s2[i])
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        return false;
    }

    public ShakerSort(int delay) : base(delay) { }
}