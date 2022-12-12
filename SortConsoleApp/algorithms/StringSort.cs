using System.Collections.Generic;

namespace SortConsoleApp.algorithms;

public abstract class StringSort
{
    public int Delay { get; set; }

    public StringSort(int delay)
    {
        Delay = delay;
    }

    protected StringSort() { }

    public abstract ICollection<string> Sort(List<string> text);
}