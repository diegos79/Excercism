/*
 * Lists in C# are collections of primitive values or instances of structs or classes. 
 * They are implemented in the base class library as List<T> 
 * where T is the type of the item in the list. 
 * 
 * The API exposes a rich set of methods for creating and manipulating lists.
 * */

using System;
using System.Collections.Generic;

public static class Languages
{
    public static List<string> NewList()
    {
        var newList = new List<string>();
        return newList;
    }

    public static List<string> GetExistingLanguages()
    {
        List<string> listProg = new List<string>();
        listProg.Add("C#");
        listProg.Add("Clojure");
        listProg.Add("Elm");
        return listProg;
    }

    public static List<string> AddLanguage(List<string> languages, string language)
    {
        languages.Add(language);
        return languages;
    }

    public static int CountLanguages(List<string> languages)
    {
        return languages.Count;
    }

    public static bool HasLanguage(List<string> languages, string language)
    {
        return languages.Contains(language);
    }

    public static List<string> ReverseList(List<string> languages)
    {
        languages.Reverse();
        return languages;
    }

    public static bool IsExciting(List<string> languages)
    {
        if (languages.Count == 0) return false;
        else if (languages[0] == "C#") return true;
        else if ((languages[1] == "C#") && ((languages.Count == 2) || (languages.Count == 3))) return true;
        else return false;
    }

    public static List<string> RemoveLanguage(List<string> languages, string language)
    {
        languages.Remove(language);
        return languages;
    }

    public static bool IsUnique(List<string> languages)
    {
        languages.Sort();
        bool res = false;
        for (int i = 0; i < languages.Count - 1; i++)
        {
            if (i == languages.Count) break;
            else if (languages[i] == languages[i + 1])
            {
                res = false; break;
            }
            else res = true;
        }
        return res;


    }
}
