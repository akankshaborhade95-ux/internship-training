using System;
using System.Collections.Generic;

namespace DotNetInternshipTraining;

public class Task6_CommonTypes
{
    public void Run()
    {
        Console.WriteLine("\n Task 6");

        StudentDTO studentDTO = new StudentDTO { Name = "Akanksha", Age = 21 };
        Console.WriteLine("DTO: " + studentDTO.Name + " - " + studentDTO.Age);
        
        StudentEntity studentEntity = new StudentEntity { Id = 1, Name = "Tanya", Age = 23 };
        Console.WriteLine("Entity: " + studentEntity.Id + " - " + studentEntity.Name);

        Personn person = new Personn { Name = "Anita", Age = 21 };
        Console.WriteLine("POCO: " + person.Name + " - " + person.Age);

        StudentRecord record = new StudentRecord("Amit", 24);
        Console.WriteLine("Record: " + record.Name + " - " + record.Age);

        ApiResponse<StudentDTO> response = new ApiResponse<StudentDTO>
        {
            Data = studentDTO,
            Success = true,
            Message = "Fetched successfully"
        };
        Console.WriteLine("ApiResponse: " + response.Data.Name + " - " + response.Message);

        PaginationModel<int> page = new PaginationModel<int>
        {
            Items = new List<int> { 1, 2, 3 },
            PageNumber = 1,
            PageSize = 3,
            TotalItems = 10
        };
        Console.WriteLine($"Pagination: Page {page.PageNumber}, Items count = {page.Items.Count}");
    }
}


// DTO
class StudentDTO
{
    public string Name;
    public int Age;
}

// Entity
class StudentEntity
{
    public int Id;
    public string Name;
    public int Age;
}

// POCO
class Personn
{
    public string Name;
    public int Age;
}
// Record
record StudentRecord(string Name, int Age);
// Generic API Response
class ApiResponse<T>
{
    public T Data;
    public bool Success;
    public string Message;
}
// Pagination
class PaginationModel<T>
{
    public List<T> Items;
    public int PageNumber;
    public int PageSize;
    public int TotalItems;
}
