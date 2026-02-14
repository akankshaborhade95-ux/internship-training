using System;

namespace DotNetInternshipTraining;

class Program
{
    static void Main()
    {
        Console.WriteLine(" DOTNET INTERNSHIP TRAINING");

        new Task1_Basics().Run();
        new OOPDemo().Run();
        new Task3_Collections().Run();
        new Task4_DTO().Run();
        new Task5_Service().Run();
        new Task6_CommonTypes().Run();
        new Task7_ExceptionHandling().Run();
        Console.WriteLine("\nAll Tasks Completed Successfully");
    }
}
