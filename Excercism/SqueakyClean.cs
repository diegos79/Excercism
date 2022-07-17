/*
 Chars
The C# char type is a 16 bit quantity to represent the smallest addressable components of text. Multiple chars can comprise a string such as "word" or chars can be processed independently. Their literals have single quotes e.g. 'A'.

C# chars support UTF-16 Unicode encoding - so in addition to the latin character set pretty much all the writing systems in use worldwide can be represented, e.g. the Greek letter 'β'.

There are many builtin library methods to inspect and manipulate chars. These can be found as static methods of the System.Char class.

String Builder
chars are sometimes used in conjunction with a StringBuilder object. This object has methods that allow a string to be constructed character by character and manipulated. At the end of the process ToString can be called on it to output a complete string.

 * 
 */

using System;
using System.Text;
public static class Identifier
{
    public static string Clean(string identifier)
    {
        StringBuilder res = new(); //Empty string to build
        bool isDash = false; //flag char isDash
        foreach (char c in identifier) //explore input string
        {
            if (char.IsWhiteSpace(c))
                res.Append('_');
            else if (char.IsControl(c))
                res.Append("CTRL");
            else if (c == '-')
            {
                isDash = true;
                continue;
            }
            else if (isDash)
            {
                res.Append(char.ToUpperInvariant(c));
                isDash = false;
            }
            else if (!char.IsLetter(c))
                continue;
            else if (c >= 'α' && c <= 'ω')
                continue;
            else res.Append(c);
        }
        return res.ToString();
    }
}
