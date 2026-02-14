using System;

namespace DotNetInternshipTraining.Task1_Basics
{
    public class BasicsDemo
    {
        public void Run()
        {
            Console.WriteLine("===== TASK 1: C# BASICS =====\n");
            // 1. Variables
            int age = 25;
            string name = "Akanksha";
            bool isStudent = true;
            Console.WriteLine($"Name: {name}, Age: {age}, Student: {isStudent}\n");
            // 2. Operators
            int a = 10, b = 3;
            Console.WriteLine("Operators:");
            Console.WriteLine($"{a} + {b} = {a + b}");
            Console.WriteLine($"{a} - {b} = {a - b}");
            Console.WriteLine($"{a} * {b} = {a * b}");
            Console.WriteLine($"{a} / {b} = {a / b}");
            Console.WriteLine($"{a} % {b} = {a % b}\n");

            // 3. Arrays
            int[] numbers = {1,2,3};
            Console.Write("Array: ");
            foreach(var num in numbers)
                Console.Write(num + " ");
            Console.WriteLine("\n");

            // 4. String
            string greeting = "ArthDisha Services";
            Console.WriteLine("String Methods:");
            Console.WriteLine("Upper: " + greeting.ToUpper());
            Console.WriteLine("Length: " + greeting.Length + "\n");
            // 5. Enum
            Day today = Day.Monday;
            Console.WriteLine("Enum: Today is " + today + "\n");
            // 6. Nullable
            int? nullableInt = null;
            Console.WriteLine("Nullable int: " + nullableInt + "\n");
            // 7. Value vs Reference Type
            int val1 = 5;
            int val2 = val1;
            val2 = 10;
            Console.WriteLine($"Value type: val1={val1}, val2={val2}");
            int[] arr1 = {1,2};
            int[] arr2 = arr1;
            arr2[0] = 100;
            Console.WriteLine($"Reference type: arr1[0]={arr1[0]}, arr2[0]={arr2[0]}");
        }
        enum Day { Sunday, Monday, Tuesday, Wednesday, Thursday, Friday, Saturday }
    }
}
