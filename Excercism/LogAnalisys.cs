using System;

public static class LogAnalysis
{
    public static string SubstringAfter(this string str, string delimiter)
    {
        return str.Substring(str.IndexOf(delimiter) + delimiter.Length);
    }

    //public static string SubstringBetween(this string str, string delA, string delB)
    //{
    //    return str.Substring(str.IndexOf(delA) + delA.Length, str.IndexOf(delB) - delB.Length);
    //}

    public static string SubstringBetween(this string str, string startDelimiter, string endDelimiter)
    => str.Split(endDelimiter).First().Split(startDelimiter).Last();

    public static string Message(this string str)
    {
        return str.SubstringAfter(": ");
    }

    public static string LogLevel(this string str)
    {
        return str.SubstringBetween("[", "]");
    }
    // TODO: define the 'LogLevel()' extension method on the `string` type
}