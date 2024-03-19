namespace PartTWOStringSortingWithList;
using System;

class Program
{
    static void Main(string args)
    {
        StringCollecion sc = new StringCollecion();
        sc.Read("names.txt");
        sc.Search("Bobens");
        
       Console.Write(sc.ToString());
    }
}

