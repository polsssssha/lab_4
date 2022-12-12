using System.Collections.Generic;

namespace SortConsoleApp.algorithms;

public class AlgorithmsUtil
{
    public static Dictionary<string, int> Count(ICollection<string> text)
    {
        Dictionary<string, int> dictionary = new Dictionary<string, int>();
        foreach (var word in text)
        {
            if (dictionary.ContainsKey(word))
            {
                dictionary[word]++;
            }
            else
            {
                dictionary.Add(word, 1);
            }
        }

        return dictionary;
    }
}