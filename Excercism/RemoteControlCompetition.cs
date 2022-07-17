/*
Interfaces

An interface is a type containing members defining a group of related functionality. 
It distances the uses of a class from the implementation allowing multiple different implementations 
or support for some generic behavior such as formatting, comparison or conversion.

The syntax of an interface is similar to that of a class or struct 
except that methods and properties appear as the signature only and no body is provided. 
 * */

using System;
using System.Collections.Generic;

// TODO implement the IRemoteControlCar interface

public interface IRemoteControlCar
{
    public int DistanceTravelled
    {
        get;
        set;
    }

    public void Drive();
}

public class ProductionRemoteControlCar : IRemoteControlCar, IComparable<ProductionRemoteControlCar>
{
    public int DistanceTravelled { get; set; }
    public int NumberOfVictories { get; set; }

    public int CompareTo(ProductionRemoteControlCar other)
    {
        return NumberOfVictories.CompareTo(other.NumberOfVictories);
    }

    public void Drive()
    {
        DistanceTravelled += 10;
    }
}

public class ExperimentalRemoteControlCar : IRemoteControlCar
{

    // Property declaration:
    public int DistanceTravelled
    {
        get;
        set;
    }

    public void Drive()
    {
        DistanceTravelled += 20;
    }
}

public static class TestTrack
{
    public static void Race(IRemoteControlCar car)
    {
        car.Drive();
    }

    public static List<ProductionRemoteControlCar> GetRankedCars(ProductionRemoteControlCar prc1,
        ProductionRemoteControlCar prc2)
    {
        var rankedCarsList = new List<ProductionRemoteControlCar>() { prc1, prc2 };
        rankedCarsList.Sort();
        return rankedCarsList;
    }
}

