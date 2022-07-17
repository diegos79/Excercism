using System;

public static class Hamming
{
    public static int Distance(string firstStrand, string secondStrand)
    {
        int distance = 0;
        if (firstStrand.Length == 0 && secondStrand.Length == 0)
            return 0;
        else if (firstStrand.Length == 0 || secondStrand.Length == 0)
            throw new ArgumentException("No empty strands allowed");
        else if (firstStrand.Length > secondStrand.Length || firstStrand.Length < secondStrand.Length)
            throw new ArgumentException("Strands must have same lengths");
        for (int i = 0; i < firstStrand.Length; i++)
        {
            if (firstStrand[i] != secondStrand[i])
                distance++;
        }
        return distance;
    }
}