using System;

namespace DotNetInternshipTraining; 

public class Task4_DTO
{
    public void Run()
    {
        Console.WriteLine("\nTask 4");

        Student s = new Student { Name = "Akanksha", Age = 21 };

        Console.WriteLine(s.Name + " - " + s.Age);
    }
}
class Student
{
    public string Name;
    public int Age;
}
