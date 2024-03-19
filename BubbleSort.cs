using System.Diagnostics;

namespace PartTWOStringSortingWithList;

public class BubbleSort : ISortBehaviour
{
    public long Sort(List<string> list)
    {
        //Sotiere die Liste mit Bubblesort
        //Nutze str.CompareTo(otherStr);
        Stopwatch watch = new Stopwatch();
        watch.Start();
        watch.Stop();
        return watch.ElapsedMilliseconds;
    }
}