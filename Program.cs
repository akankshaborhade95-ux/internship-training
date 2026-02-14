using System;

namespace DotNetInternshipTraining
{
    class Project
    {
        static void Main()
        {
            OOPDemo oop = new OOPDemo();
            oop.Run();

            Console.WriteLine("\n----------------------\n");

            CollectionsDemo collections = new CollectionsDemo();
            collections.Run();
            Task4_Collections demo = new Task4_Collections(); 
               demo.Run();

            Console.ReadKey();
        }
    }
}
