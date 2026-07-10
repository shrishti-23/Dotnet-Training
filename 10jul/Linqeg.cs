//LINQ -Language Integrated Query
//used to query collection like arrays, List.
//where: filter data, select(), orderBy(), orderByDescending()
//first(), count(), min(), max(), sum()

using System;
using System.Linq;

class Linqeg
{
    public void Display3()
    {
        int[] numbers = {8,7,6,4,1,8,7,5,7,8};
        var even = numbers.Where(x => x%2==0);

        foreach(var n in even)
        {
            Console.WriteLine(n);
        }
    }
}