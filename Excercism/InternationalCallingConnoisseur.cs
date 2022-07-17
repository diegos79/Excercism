/*
 * 
 * A dictionary is a collection of elements where each element comprises a key and value such that 
 * if a key is passed to a method of the dictionary its associated value is returned. 
 * It has the same role as maps or associative arrays do in other languages.

A dictionary can be created as follows:

new Dictionary<int, string>();

 * 
 * */
using System;
using System.Collections.Generic;

public static class DialingCodes
{
    public static Dictionary<int, string> GetEmptyDictionary()
    {
        Dictionary<int, string> dict = new Dictionary<int, string>();
        return dict;
    }

    public static Dictionary<int, string> GetExistingDictionary()
    {
        Dictionary<int, string> dict =
            new Dictionary<int, string>
        {
            {1, "United States of America"},
            {55, "Brazil"},
            {91, "India"}
        };
        return dict;
    }

    public static Dictionary<int, string> AddCountryToEmptyDictionary(int countryCode, string countryName)
    {
        Dictionary<int, string> dict = new Dictionary<int, string>();
        dict.Add(countryCode, countryName);
        return dict;
    }

    public static Dictionary<int, string> AddCountryToExistingDictionary(
        Dictionary<int, string> existingDictionary, int countryCode, string countryName)
    {
        existingDictionary.Add(countryCode, countryName);
        return existingDictionary;
    }

    public static string GetCountryNameFromDictionary(
        Dictionary<int, string> existingDictionary, int countryCode)
    {
        if (!existingDictionary.ContainsKey(countryCode))
            return "";
        else return existingDictionary[countryCode];
    }

    public static bool CheckCodeExists(Dictionary<int, string> existingDictionary, int countryCode)
    {
        return existingDictionary.ContainsKey(countryCode);
    }

    public static Dictionary<int, string> UpdateDictionary(
        Dictionary<int, string> existingDictionary, int countryCode, string countryName)
    {
        if (!CheckCodeExists(existingDictionary, countryCode))
            Console.WriteLine("No changes made");
        else existingDictionary[countryCode] = countryName;
        return existingDictionary;
    }

    public static Dictionary<int, string> RemoveCountryFromDictionary(
        Dictionary<int, string> existingDictionary, int countryCode)
    {
        existingDictionary.Remove(countryCode);
        return existingDictionary;
    }

    public static string FindLongestCountryName(Dictionary<int, string> existingDictionary)
    {
        int maxL = 0;
        string country = "";
        foreach (string c in existingDictionary.Values)  
        {
            if (c.Length > maxL)
            {
                maxL = c.Length;
                country = c;
            }
            return country;
        }

        return country;
    }
}