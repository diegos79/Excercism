using System;
using System.Collections.Generic;
using System.Linq;

public class HighScores
{
    private readonly List<int> scores;


    public HighScores(List<int> list)
    {
        scores = list;
    }

    public List<int> Scores()
    {
        return scores;
    }

    public int Latest()
    {
        return Scores().Last();
    }

    public int PersonalBest()
    {
        List<int> ordered = scores.OrderBy(x => x).ToList();
        return ordered.Last();
    }

    public List<int> PersonalTopThree()
    {
        List<int> ordered = scores.OrderBy(x => x).ToList();
        return ordered.TakeLast(3).Reverse().ToList();
    }
}