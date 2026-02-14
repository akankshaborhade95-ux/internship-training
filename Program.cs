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

            Console.ReadKey();
        }
    }
}
