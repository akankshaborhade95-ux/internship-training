using System;
using System.Collections.Generic;
using System.Linq;

namespace DotNetInternshipTraining;

public class Task8_LINQ
{
    public void Run()
    {
        Console.WriteLine("\nTask 8");
        List<Studentt> students = new List<Studentt>
        {
            new Studentt { Name = "sarita", Age = 22, Department = "IT" },
            new Studentt { Name = "Anita", Age = 20, Department = "CS" },
            new Studentt { Name = "Rutuja", Age = 23, Department = "Robotics" },
            new Studentt { Name = "Priya", Age = 21, Department = "CS" }
        };

        // Where
        var olderStudents = students.Where(s => s.Age > 21);
        Console.WriteLine("Students older than 21:");
        foreach (var s in olderStudents)
            Console.WriteLine(s.Name + " - " + s.Age);
        //Select
        var names = students.Select(s => s.Name);
        Console.WriteLine("\nStudent Names:");
        foreach (var name in names)
            Console.WriteLine(name);

        // OrderBy
        var sorted = students.OrderBy(s => s.Age);
        Console.WriteLine("\nStudents sorted by age:");
        foreach (var s in sorted)
            Console.WriteLine(s.Name + " - " + s.Age);

        //GroupBy
        var groups = students.GroupBy(s => s.Department);
        Console.WriteLine("\nStudents grouped by department:");
        foreach (var group in groups)
        {
            Console.WriteLine("Department: " + group.Key);
            foreach (var s in group)
                Console.WriteLine("  " + s.Name);
        }

        var firstIT = students.FirstOrDefault(s => s.Department == "IT");
        Console.WriteLine("\nFirst IT student: " + firstIT?.Name);
        // Join
        List<Gradet> grades = new List<Gradet>
        {
            new Gradet { StudentName = "sarita", Marks = 90 },
            new Gradet { StudentName = "Anita", Marks = 85 },
            new Gradet { StudentName = "Rutuja", Marks = 88 },
            new Gradet { StudentName = "Priya", Marks = 92 }
        };

        var studentGrades = students.Join(grades,
                                          s => s.Name,
                                          g => g.StudentName,
                                          (s, g) => new { s.Name, s.Department, g.Marks });

        Console.WriteLine("\nStudents with Grades:");
        foreach (var sg in studentGrades)
            Console.WriteLine($"{sg.Name} ({sg.Department}) - Marks: {sg.Marks}");
    }
}
class Studentt
{
    public string Name;
    public int Age;
    public string Department;
}
class Gradet
{
    public string StudentName;
    public int Marks;
}
