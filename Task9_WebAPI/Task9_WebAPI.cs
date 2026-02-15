using System;
using System.Collections.Generic;
using System.Linq;

namespace DotNetInternshipTraining;

public class Task9_WebAPI
{
    public void Run()
    {
        Console.WriteLine("\n Task 9- Web API ");
        
        var controller = new StudentController();
        var students = controller.GetAllStudents();

        Console.WriteLine("All Students:");
        foreach (var s in students)
            Console.WriteLine($"{s.Name} - {s.Age}");
    }
}
//DTO
class StudentDto
{
    public string Name;
    public int Age;
}
// Repository
class StudentRepository
{
    private List<StudentDTO> students = new List<StudentDTO>
    {
        new StudentDTO { Name = "Akanksha", Age = 22 },
        new StudentDTO { Name = "Anita", Age = 20 },
        new StudentDTO { Name = "Riya", Age = 23 }
    };

    public List<StudentDTO> GetStudents()
    {
        return students;
    }
}
class StudentService
{
    private StudentRepository repo = new StudentRepository();

    public List<StudentDTO> GetStudents()
    {
        return repo.GetStudents().Where(s => s.Age > 21).ToList();
    }
}
//Controller
class StudentController
{
    private StudentService service = new StudentService();

    public List<StudentDTO> GetAllStudents()
    {
        return service.GetStudents();
    }
}
