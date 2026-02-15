using System;
namespace DotNetInternshipTraining;
// Interface
public interface ISalaryService
{
    int CalculateTotal(int basic, int bonus);
}
// Service
public class SalaryService : ISalaryService
{
    public int CalculateTotal(int basic, int bonus)
    {
        return basic + bonus;
    }
}
public class Task5_Service
{
    public void Run()
    {
        Console.WriteLine("\n Task 5 ");
        ISalaryService service = new SalaryService();

        int total = service.CalculateTotal(10000, 2000);

        Console.WriteLine("Total Salary = " + total);
    }
}
