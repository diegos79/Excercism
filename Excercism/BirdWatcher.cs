using System;
class BirdCount
{
    private int[] birdsPerDay;
    public BirdCount(int[] birdsPerDay)
    {
        this.birdsPerDay = birdsPerDay;
    }
    public static int[] LastWeek()
    {
        int[] arr = { 0, 2, 5, 3, 7, 8, 4 };
        return arr;
    }
    public int Today() => this.birdsPerDay[birdsPerDay.Length - 1];

    public void IncrementTodaysCount()
    {
        this.birdsPerDay[birdsPerDay.Length - 1]++;
    }
    public bool HasDayWithoutBirds()
    {
        if (Array.IndexOf(this.birdsPerDay, 0) == -1)
            return false;
        else return true;
    }
    public int CountForFirstDays(int numberOfDays)
    {
        int sum = 0;
        for (int i = 0; i < numberOfDays; i++)
            sum += this.birdsPerDay[i];
        return sum;
    }
    public int BusyDays()
    {
        int busyDays = 0;
        foreach (int day in this.birdsPerDay)
            if (day >= 5) busyDays++;
        return busyDays;
    }
}