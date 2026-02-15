using System;

namespace DotNetInternshipTraining
{
    class Person
    {
        public string Name;
        public int Age;

        // constructor
        public Person(string name, int age)
        {
            Name = name;
            Age = age;
        }
        // method
        public virtual void Show()
        {
            Console.WriteLine("Name: " + Name);
            Console.WriteLine("Age: " + Age);
        }
    }
    // Inheritance
    class Employee : Person
    {
        public string Department;
        public Employee(string name, int age, string department)
            : base(name, age)
        {
            Department = department;
        }
        // Polymorphism
        public override void Show()
        {
            base.Show(); 

            Console.WriteLine("Department: " + Department);
        }
    }

    public class OOPDemo
    {
        public void Run()
        {
            Console.WriteLine(" Task 2 : OOPS Example\n");

            Employee emp = new Employee("Akanksha", 21, "Full stack Developer");

            emp.Show();
        }
    }
}
