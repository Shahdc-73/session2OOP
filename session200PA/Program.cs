using System;
using EmployeeNamespace;
using  Hiring_DateNamespace ;
using EMPLOYEE_NEW;

namespace MyCLIApp
{
    class Program
    {
        static void Main(string[] args)
        {

            #region  testing class emp
                // Creating an employee instance
                // Employee emp1 = new Employee(1, "shahd sherif", 3, 50000, DateTime.Now, Gender.Male);

                // // Displaying the employee details
                // emp1.ShowEmpDetails();
            #endregion
            #region Name
                Hiring_Date hireDate = new Hiring_Date(12, 6, 2024);
                Console.WriteLine($"Hiring Date: {hireDate.Day}/{hireDate.Month}/{hireDate.Year}");
            #endregion
            #region Name
                
            #endregion
        }
    }
}
