using System;
using System.Collections.Generic;

namespace DotNetInternshipTraining
{
    public class Task3_Collections
    {
        public void Run()
        {
            Console.WriteLine("Task 3 : Collection\n");
            // ARRAY
            string[] empArray = { "Akanksha", "Tanya" };

            Console.WriteLine("Array Employees:");
            foreach (var name in empArray)
            {
                Console.WriteLine(name);
            }

            // LIST
            List<string> empList = new List<string>();

            empList.Add("Neha");
            empList.Add("Anuja");
            empList.Add("Ankita");

            Console.WriteLine("\nList Employees:");
            foreach (var name in empList)
            {
                Console.WriteLine(name);
            }

            // DICTIONARY
            Dictionary<int, string> empDict = new Dictionary<int, string>();

            empDict.Add(101, "Akanksha");
            empDict.Add(102, "");

            Console.WriteLine("\nDictionary Employees:");
            foreach (var item in empDict)
            {
                Console.WriteLine(item.Key + " -> " + item.Value);
            }
            // STACK
            Stack<string> stack = new Stack<string>();
            stack.Push("File1");
            stack.Push("File2");
            stack.Push("File3");
            Console.WriteLine("\nStack Pop: " + stack.Pop());
            // QUEUE
            Queue<string> queue = new Queue<string>();
            queue.Enqueue("Task1");
            queue.Enqueue("Task2");
            Console.WriteLine("Queue Dequeue: " + queue.Dequeue());
        }
    }
}
