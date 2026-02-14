using System;
using System.Collections.Generic;

namespace DotNetInternshipTraining;

public class Task4_Collections
{
    public void Run()
    {
        Console.WriteLine("TASK 4");

        ArrayExample();
        ListExample();
        DictionaryExample();
        ExceptionExample();
    }
    // ARRAY (Fixed size)
    void ArrayExample()
    {
        Console.WriteLine("\nArray Example");

        int[] marks = { 80, 90, 75, 88, 95 };

        foreach (int m in marks)
        {
            Console.WriteLine(m);
        }
    }
    // LIST (Dynamic size)
    void ListExample()
    {
        Console.WriteLine("\nList Example");

        List<string> students = new List<string>();

        students.Add("Akanksha");
        students.Add("Tanya");
        students.Add("Arunita");

        students.Remove("Radhika");

        foreach (string s in students)
        {
            Console.WriteLine(s);
        }
    }

    //DICTIONARY (Key + Value pair)
    void DictionaryExample()
    {
        Console.WriteLine("\n Dictionary Example");

        Dictionary<string, string> phonebook = new Dictionary<string, string>();

        phonebook["Vedika"] = "1234567890";
        phonebook["Amruta"] = "0987654321";

        Console.WriteLine("Vedika number: " + phonebook["Vedika"]);
    }
    //EXCEPTION HANDLING
    void ExceptionExample()
    {
        Console.WriteLine("\nException Example");

        try
        {
            Console.Write("Enter a number: ");
            int number = int.Parse(Console.ReadLine());

            int result = 100 / number;

            Console.WriteLine("Result = " + result);
        }
        catch (DivideByZeroException)
        {
            Console.WriteLine(" Cannot divide by zero");
        }
        catch (FormatException)
        {
            Console.WriteLine("Please enter valid number");
        }
        finally
        {
            Console.WriteLine("Program finished safely");
        }
    }
}
