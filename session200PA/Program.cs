using System;
using EmployeeNamespace;
using Hiring_DateNamespace;
using EMPLOYEE_NEW;

namespace MyCLIApp
{
    class Program
    {
        static void Main(string[] args)
        {
             #region Employee Testing
            Console.WriteLine("Employee Details ");
            
             Employee emp1 = new Employee(1, "Shahd Sherif", 3, 50000, DateTime.Now, Gender.Female);
    
            emp1.ShowEmpDetails();
            Console.WriteLine();
            #endregion

             #region Hiring Date Testing
            Console.WriteLine("Hiring Date Details");
            
            // Creating a Hiring_Date instance with sample data
            Hiring_Date hireDate = new Hiring_Date(12, 6, 2024);
            
            // Displaying the hiring date details
            Console.WriteLine($"Hiring Date: {hireDate.Day}/{hireDate.Month}/{hireDate.Year}");
            Console.WriteLine();
            #endregion

 
            
            Console.WriteLine();
            #endregion
        }
    }
}
