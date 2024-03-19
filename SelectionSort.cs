using System.Diagnostics;

namespace PartTWOStringSortingWithList;

public class SelectionSort : ISortBehaviour
{
    public long Sort(List<string> list)
    {
        Stopwatch watch = new Stopwatch();
        watch.Start();
        watch.Stop();return
        watch.ElapsedMilliseconds;
    }
}