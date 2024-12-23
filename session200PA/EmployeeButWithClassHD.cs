using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EMPLOYEE_NEW
{


public enum Gender
    {
        Male = 1, 
        Female = 2
    }


    public class EmployeeButWithClassHD
    { 
        public int id;
        public string name;
        public int securityLevel;
        public double salary;
        public Hiring_Date hireDate;
        public Gender gender;

        // Constructor
        public Employee(int _ID, string _Name, int _SecurityLevel, double _salary,Hiring_Date _hireDate, Gender _gender)
        {
            this.id = _ID;
            this.name = _Name;
            this.securityLevel = _SecurityLevel;
            this.salary = _salary;
            this.hireDate=_hireDate;
            this.gender = _gender;
        }

        // Properties (Getters and Setters)
        public int ID
        {
            get { return id; }
            set { id = value; }
        }

        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        public int SecurityLevel
        {
            get { return securityLevel; }
            set { securityLevel = value; }
        }

        public double Salary
        {
            get { return salary; }
            set { salary = value; }
        }

        public Hire_Date HireDate
        {
            get { return hireDate; }
            set { hireDate = value; }
        }

        public Gender Gender
        {
            get { return gender; }
            set { gender = value; }
        }

        // Method to show employee details
        // public void ShowEmpDetails()
        // {
        //     Console.WriteLine($"Employee ID: {ID}");
        //     Console.WriteLine($"Name: {Name}");
        //     Console.WriteLine($"Security Level: {SecurityLevel}");
        //     Console.WriteLine($"Salary: {Salary:C}"); // Format salary as currency
        //     Console.WriteLine($"Hire Date: {HireDate.ToShortDateString()}");
        //     Console.WriteLine($"Gender: {Gender}");
        // }

        public override string ToString()
        {
            return String.Format(
                "Employee ID: {0}\nName: {1}\nSecurity Level: {2}\nSalary: {3:C}\nHire Date: {4}\nGender: {5}",
                ID, Name, SecurityLevel, Salary, HireDate.ToShortDateString(), Gender
            );
        }
    }
}

