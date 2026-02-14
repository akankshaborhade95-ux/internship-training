using System;

namespace DotNetInternshipTraining.Task2_OOP
{

    // Every person has Name and Age
    class Person
    {
        // variables (data)
        public string Name;
        public int Age;

        // constructor → runs when object is created
        // used to set initial values
        public Person(string name, int age)
        {
            Name = name;
            Age = age;
        }

        // method → prints basic person details
        public virtual void Show()
        {
            Console.WriteLine("Name: " + Name);
            Console.WriteLine("Age: " + Age);
        }
    }



    // Employee is a Person who works in company
    // Inheritance → Employee gets Name and Age from Person
    class Employee : Person
    {
        // extra property only for employee
        public string Department;

        // constructor
        // base(name, age) → calls Person constructor
        public Employee(string name, int age, string department)
            : base(name, age)
        {
            Department = department;
        }

        // Polymorphism (override)
        // we modify Show() to print more details
        public override void Show()
        {
            base.Show(); // prints Name + Age from Person

            Console.WriteLine("Department: " + Department);
        }
    }



    // Demo class to run the example
    public class OOPDemo
    {
        public void Run()
        {
            Console.WriteLine(" Task 2 : OOPS Example\n");

            // creating object (real employee in company)
            Employee emp = new Employee("Akanksha", 21, "Full stack Developer");

            // calling method
            emp.Show();
        }
    }
}
