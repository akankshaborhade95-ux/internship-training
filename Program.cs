using System;
using DotNetInternshipTraining.Task2_OOP;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Starting Application...\n");

        // create object of OOPDemo
        OOPDemo demo = new OOPDemo();

        // run task 2
        demo.Run();

        Console.WriteLine("\nPress any key to exit...");
        Console.ReadKey();
    }
}
