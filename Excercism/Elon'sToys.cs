/*
 * The primary object-oriented construct in C# is the class, which is a combination of data (fields) and behavior (methods). The fields and methods of a class are known as its members.

Access to members can be restricted through access modifiers, the two most common ones being:

public: the member can be accessed by any code (no restrictions).
private: the member can only be accessed by code in the same class.
You can think of a class as a template for creating instances of that class. To create an instance of a class (also known as an object), the new keyword is used:
*/

using System;
class RemoteControlCar
{
    int speed;
    int batteryDrain;
    int distanceDriven;
    int batteryCharge;
    int battery;

    public RemoteControlCar()
    {
        distanceDriven = 0;
        battery = 100;
    }

    public RemoteControlCar(int speed, int batteryDrain)
    {
        this.speed = speed;
        this.distanceDriven = 0;
        this.batteryDrain = batteryDrain;
        this.batteryCharge = 100;
    }

    public bool BatteryDrained()
    {
        return (batteryCharge < batteryDrain);
    }

    public int DistanceDriven() => distanceDriven;


    public static RemoteControlCar Buy()
    {
        return new RemoteControlCar();
    }
    public string DistanceDisplay()
    {
        return $"Driven {distanceDriven} meters";
    }
    public string BatteryDisplay()
    {
        if (battery > 0)
            return $"Battery at {battery}%";
        else
            return "Battery empty";
    }

    public void Drive()
    {
        if ((batteryCharge > 0) && !BatteryDrained())
        {
            distanceDriven += speed;
            batteryCharge -= batteryDrain;
        }
        else
            Console.WriteLine("Battery drained");
    }
    public static RemoteControlCar Nitro()
    {
        return new RemoteControlCar(50, 4);
    }

    //public void Drive()
    //{
    //    if (battery > 0)
    //    {
    //        distanceDriven += 20;
    //        battery -= 1;
    //        Console.WriteLine($"Driven {distanceDriven} meters");
    //    }
    //    else
    //        Console.WriteLine("Drain the battery");

}

class RaceTrack
{
    int distance;

    public RaceTrack(int distance)
    {
        this.distance = distance;
    }

    public bool TryFinishTrack(RemoteControlCar car)
    {
        while (!car.BatteryDrained())
            car.Drive();
        if (car.DistanceDriven() >= this.distance)
            return true;
        else return false;
    }
}
