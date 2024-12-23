# session2OOP
Assignment 6: Employee Management System

Overview

This project involves creating a class to represent employees in a company. The Employee class includes fields such as employee ID, name, security level, salary, hire date, and gender. We also implement a HiringDate class that holds the day, month, and year of the employee's hiring date. Security levels are defined as an enum, and the gender field is restricted to either 'M' (Male) or 'F' (Female). The employee salary is displayed in a currency format.

The program allows users to manage and display employee data in an organized manner while ensuring input validation and preventing runtime errors.

Features

Employee Class:
Holds employee information such as ID, Name, Security Level, Salary, Hire Date, and Gender.
Security Level is represented by an Enum (Guest, Developer, Secretary, DBA).
Gender is restricted to M (Male) or F (Female).
Salary is displayed in a currency format using String.Format().
The ToString() method is overridden to represent the employee in a readable string format.
HiringDate Class:
Holds the date of hiring information with fields for the day, month, and year.
Array of Employees:
An array of employees is created with size three: one employee as a DBA, one as a Guest, and one as a Security Officer with full permissions.
Input Validation:
The program ensures no runtime errors by validating inputs for all fields.
Classes and Methods

Employee Class
Fields:
EmployeeID: Employee ID (integer).
Name: Employee name (string).
SecurityLevel: Security level (enum: Guest, Developer, Secretary, DBA).
Salary: Employee salary (double).
HireDate: The date the employee was hired (instance of HiringDate class).
Gender: Employee gender (restricted to 'M' or 'F').
Constructors:
A constructor that takes all employee information (ID, Name, SecurityLevel, Salary, HireDate, Gender).
A default constructor (optional).
Properties:
Getters and setters for each field, ensuring data validation where necessary (e.g., Gender must be 'M' or 'F').
Methods:
ToString(): Returns a string representation of the employee, including their name, ID, salary (formatted as currency), and hire date.
DisplaySalary(): Displays the salary in a formatted currency string using String.Format().
HiringDate Class
Fields:
Day: The day the employee was hired (integer).
Month: The month the employee was hired (integer).
Year: The year the employee was hired (integer).
Constructor:
A constructor to initialize the Day, Month, and Year fields.
Method:
ToString(): Returns the hire date in the format dd/MM/yyyy.
Enum for Security Levels
Guest
Developer
Secretary
DBA
Employee Array
An array EmpArr[] of size 3, containing:
A DBA employee with full permissions.
A Guest employee with limited permissions.
A third employee representing a security officer with full permissions.
Input Validation
All input is validated to ensure that no invalid data is entered. For example:
Gender must be either 'M' or 'F'.
Salary must be a valid number.
Hire date must be valid (e.g., day should be between 1 and 31).
Example Usage

using System;

namespace MyConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            // Create HireDate instances for employees
            HiringDate hireDate1 = new HiringDate(1, 1, 2015);
            HiringDate hireDate2 = new HiringDate(15, 3, 2020);
            HiringDate hireDate3 = new HiringDate(20, 6, 2018);

            // Create Employee instances
            Employee emp1 = new Employee(1, "Ali", Permission.DBA, 5000, hireDate1, 'M');
            Employee emp2 = new Employee(2, "Noor", Permission.Guest, 2000, hireDate2, 'F');
            Employee emp3 = new Employee(3, "Rana", Permission.Developer, 4000, hireDate3, 'F');

            // Display employee information
            Console.WriteLine(emp1.ToString());
            Console.WriteLine(emp2.ToString());
            Console.WriteLine(emp3.ToString());
        }
    }
}
Expected Output
Employee ID: 1, Name: Ali, Salary: $5,000.00, Hire Date: 01/01/2015, Gender: M
Employee ID: 2, Name: Noor, Salary: $2,000.00, Hire Date: 15/03/2020, Gender: F
Employee ID: 3, Name: Rana, Salary: $4,000.00, Hire Date: 20/06/2018, Gender: F
Installation

To run the project, ensure that you have the following installed:

.NET SDK (version 6 or later)
Visual Studio or any other C# IDE (like Visual Studio Code)
Clone this repository and open the project in your IDE. Build and run the project to see the results.

License

This project is licensed under the MIT License.

