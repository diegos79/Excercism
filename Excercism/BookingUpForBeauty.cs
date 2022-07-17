/*
 * A DateTime in C# is an immutable object that contains both date and time information. 
 * DateTime instances are manipulated by calling their methods. 
 * Once a DateTime has been constructed, its value can never change. 
 * Any methods that appear to modify a DateTime will actually return a new DateTime.
 * */

using System;

static class Appointment
{
    public static DateTime Schedule(string appointmentDateDescription) =>
        DateTime.Parse(appointmentDateDescription);


    public static bool HasPassed(DateTime appointmentDate) =>
        DateTime.Now > appointmentDate;

    public static bool IsAfternoonAppointment(DateTime appointmentDate) =>
        ((appointmentDate.Hour >= 12) && (appointmentDate.Hour < 18));


    public static string Description(DateTime appointmentDate) =>
        $"You have an appointment on {appointmentDate}.";

    public static DateTime AnniversaryDate()
    {
        DateTime now = DateTime.Now;
        DateTime ann = new DateTime(now.Year, 9, 15);
        return ann;
    }
}