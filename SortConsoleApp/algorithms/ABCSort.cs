using System;
using System.Collections.Generic;
using System.Threading;

namespace SortConsoleApp.algorithms
{
    public class ABCSort : StringSort
    {
        public ABCSort() { }

        private ICollection<string> Sort(ICollection<string> words, int rank = 0)
        {
            if (words.Count > 1)
            {
                Console.WriteLine($"Сравнение слов по символу на позиции {rank}\n");
                Thread.Sleep(Delay);
                Dictionary<char, List<string>> squares = new Dictionary<char, List<string>> {{'@', new List<string>()}};
                foreach (var word in words)
                {
                    Console.WriteLine($"Сравнение позиции {rank} и длину слова {word}");
                    Thread.Sleep(Delay);
                    if (rank < word.Length)
                    {
                        if (squares.ContainsKey(word[rank]))
                        {
                            squares[word[rank]].Add(word);
                        }
                        else
                        {
                            squares.Add(word[rank], new List<string>() {word});
                        }

                        Console.WriteLine($"\tДобавление слова \"{word}\" в группу [ {word[rank]} ]\n");
                        Thread.Sleep(Delay);
                    }
                    else
                    {
                        Console.WriteLine($"Добавление слова \"{word}\" в дефолтную группу [ @ ]\n");
                        Thread.Sleep(Delay);
                        squares['@'].Add(word);
                    }
                }

                if (squares['@'].Count == words.Count)
                {
                    Console.WriteLine(
                        $"Прошли все символы всех слов, поэтому добавляем отсортированные значение в результирующий список\n");
                    Thread.Sleep(Delay);
                    return words;
                }

                List<string> result = new List<string>();
                for (char i = '@'; i <= 'z'; i++)
                {
                    if (squares.ContainsKey(i))
                    {
                        foreach (var word in Sort(squares[i], rank + 1))
                        {
                            result.Add(word);
                        }
                    }
                }

                return result;
            }

            return words;
        }

        public ABCSort(int delay) : base(delay) { }

        public override ICollection<string> Sort(List<string> text)
        {
            return Sort(text);
        }
    }
}