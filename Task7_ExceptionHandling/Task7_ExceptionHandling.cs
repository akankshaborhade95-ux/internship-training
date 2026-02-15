using System;

namespace DotNetInternshipTraining;

public class Task7_ExceptionHandling
{
    public void Run()
    {
        Console.WriteLine("\n Task 7");
        
        try
        {
            Console.WriteLine("Enter a number to divide 100:");
            int input = int.Parse(Console.ReadLine()!); // throw FormatException
            int result = 100 / input; //throw DivideByZeroException
            Console.WriteLine("Result = " + result);
        }
        catch (FormatException)
        {
            Console.WriteLine("Error: Please enter a valid number!");
        }
        catch (DivideByZeroException)
        {
            Console.WriteLine("Error: Cannot divide by zero!");
        }
        catch (Exception ex)
        {
            Console.WriteLine("Something went wrong: " + ex.Message);
        }
        finally
        {
            Console.WriteLine("Finally block always runs\n");
        }
        try
        {
            CheckAge(15);
        }
        catch (AgeException ex)
        {
            Console.WriteLine("Custom Exception: " + ex.Message);
        }
    }
    void CheckAge(int age)
    {
        if (age < 18)
            throw new AgeException("Age must be at least 18!");
        Console.WriteLine("Age is valid: " + age);
    }
}
class AgeException : Exception
{
    public AgeException(string message) : base(message) { }
}
