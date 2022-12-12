using System.Collections.Generic;

namespace SortConsoleApp.algorithms
{
    public class ABCSort : StringSort
    {
        public ABCSort() { }

        private ICollection<string> Sort(ICollection<string> words, int rank = 0)
        {
            if (words.Count > 1)
            {
                Dictionary<char, List<string>> squares = new Dictionary<char, List<string>> {{'@', new List<string>()}};
                foreach (var word in words)
                {
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
                    }
                    else
                    {
                        squares['@'].Add(word);
                    }
                }

                if (squares['@'].Count == words.Count)
                {
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