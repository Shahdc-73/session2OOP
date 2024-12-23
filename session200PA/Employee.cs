using System;

namespace EmployeeNamespace
{
    public enum Gender
    {
        Male = 1, 
        Female = 2
    }
    public enum SP{
        guest, Developer, secretary , DBA
    }

    public class Employee
    {
    
        public int id;
        public string name;
        public SP securityLevel;
        public double salary;
        public DateTime hireDate;
        public Gender gender;

        public Employee(int _ID, string _Name, SP _SecurityLevel, double _salary, DateTime _Hiredate, Gender _gender)
        {
            this.id = _ID;
            this.name = _Name;
            this.securityLevel = _SecurityLevel;
            this.salary = _salary;
            this.hireDate = _Hiredate;
            this.gender = _gender;
        }

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

        public SP SecurityLevel
        {
            get { return securityLevel; }
            set { securityLevel = value; }
        }

        public double Salary
        {
            get { return salary; }
            set { salary = value; }
        }

        public DateTime HireDate
        {
            get { return hireDate; }
            set { hireDate = value; }
        }

        public Gender Gender
        {
            get { return gender; }
            set { gender = value; }
        }

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
