/*
 * Exceptions in C# provide a structured, uniform, and type-safe way of handling error conditions 
 * that occur during runtime. Proper handling of exceptions and error is important when trying 
 * to prevent application crashes.

In C#, all exceptions have System.Exception class as their base type. 
It contains important properties such as Message, which contains a human-readable description 
of the reason for the exception being thrown.

To signal that there should be an error in a certain part of the code, 
a new exception object needs to be created and then thrown, using the throw keyword
*/

using System;

public static class SimpleCalculator
{
    public static string Calculate(int operand1, int operand2, string operation)
    {
        switch (operation)
        {
            case "+":
                return operand1.ToString() + " + " + operand2.ToString() + " = " + SimpleOperation.Addition(operand1, operand2).ToString();
            case "*":
                return operand1.ToString() + " * " + operand2.ToString() + " = " + SimpleOperation.Multiplication(operand1, operand2).ToString();
            case "/":
                if (operand2 == 0)
                    return "Division by zero is not allowed.";
                else
                    return operand1.ToString() + " / " + operand2.ToString() + " = " + SimpleOperation.Division(operand1, operand2).ToString();
            case null: throw new ArgumentNullException();
            case "": throw new ArgumentException();
            default: throw new ArgumentOutOfRangeException();
        }
    }
}

public static class SimpleOperation
{
    public static int Division(int operand1, int operand2)
    {
        return operand1 / operand2;
    }

    public static int Multiplication(int operand1, int operand2)
    {
        return operand1 * operand2;
    }

    public static int Addition(int operand1, int operand2)
    {
        return operand1 + operand2;
    }
}
