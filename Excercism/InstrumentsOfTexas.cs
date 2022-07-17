using System;

public class CalculationException : Exception
{
    public CalculationException(int operand1, int operand2, string message, Exception inner)
    // TODO: complete the definition of the constructor
    {
        Operand1 = operand1;
        Operand2 = operand2;
    }

    public int Operand1 { get; }
    public int Operand2 { get; }
}

public class CalculatorTestHarness
{
    private Calculator calculator;

    public CalculatorTestHarness(Calculator calculator)
    {
        this.calculator = calculator;
    }

    public string TestMultiplication(int x, int y)
    {
        /*
         * Implement the CalculatorTestHarness.TestMultiplication() method which 
         * takes two integers and calls the CalculatorTestHarness.Multiply() method. 
         * 
         * "Multiply succeeded" is returned.
         */

        /*
         * Modify the CalculatorTestHarness.TestMultiplication() method so that 
         * "Multiply failed for negative operands. <INNER_EXCEPTION_MESSAGE>"is returned 
         * if both integer arguments are negative (less than zero).

The     <INNER_EXCEPTION_MESSAGE> placeholder should be replaced with 
        the CalculationException's inner exception's message.*/

        try
        {
            Multiply(x, y);
            return "Multiply succeeded";
        }
        //catch (CalculationException ex) when (ex.Operand1 < 0 && ex.Operand2 < 0) 
        catch (CalculationException ex) when (x < 0 && y < 0) 
        {
            return "Multiply failed for negative operands. Arithmetic operation resulted in an overflow.";
        }
        catch (CalculationException)
        {
            return "Multiply failed for mixed or positive operands.Arithmetic operation resulted in an overflow.";
        }
        
    }

    public void Multiply(int x, int y)
    {
        
        /*
         * Implement CalculatorTestHarness.Multiply() method, 
         * which should call the Calculator.Multiply() method of the Calculator instance passed to the constructor. 
         * passing in x and y integer values. 
         * 
         * If an overflow occurs in the Calculator.Multiply() method, 
         * it will throw an OverflowException. 
         * 
         * This exception should be caught in the CalculatorTestHarness.Multiply() method 
         * and wrapped in a CalculationException and the x and y values being passed around 
         * should be stored as the exception's operands. 
         * The newly created CalculationException object should be thrown. 
         * You can ignore the value returned by the Calculator.Multiply() method if it is successful.
        */
        try
        {
            calculator.Multiply(x, y);
        }
        catch (OverflowException ex)
        {
            throw new CalculationException(x, y, "error", ex);
        }

    }
}


// Please do not modify the code below.
// If there is an overflow in the multiplication operation
// then a System.OverflowException is thrown.
public class Calculator
{
    public int Multiply(int x, int y)
    {
        checked
        {
            return x * y;
        }
    }
}
