using System;

public static class ResistorColor
{
    public static int ColorCode(string color) => //this is a switch expression (C# 8)
        color switch
        {
            "Black" => 0,
            "Brown" => 1,
            "Red" => 2,
            "Orange" => 3,
            "Yellow" => 4,
            "Green" => 5,
            "Blue" => 6,
            "Violet" => 7,
            "Grey" => 8,
            "White" => 9,
            _ => -1
        };

    public static string[] Colors()
    {
        string[] result = {"Black","Brown","Red","Orange","Yellow","Green","Blue","Violet","Grey","White"};
        return result;
    }

}   