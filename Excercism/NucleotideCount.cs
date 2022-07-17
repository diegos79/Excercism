using System;
using System.Collections.Generic;
using System.Linq;
public static class NucleotideCount
{
    public static IDictionary<char, int> Count(string sequence)
    {
        var count = new Dictionary<char, int> //set base dictionary ready 
        {
            ['A'] = 0,
            ['C'] = 0,
            ['G'] = 0,
            ['T'] = 0
        };

        Console.WriteLine(count['A']);
        foreach (char c in sequence) //read every char in input parameter "sequence"
        {
            if (count.ContainsKey(c)) //incrment Key value if finding value
            {
                count[c]++;
            }
            else
            {
                throw new ArgumentException();
            }
        }
        return count;
    }
}