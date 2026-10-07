using System;

class Employee
{
    public int employeeId;
    public string employeeName = "";

    public void DisplayEmployee()
    {
        Console.WriteLine("Employee ID: " + employeeId);
        Console.WriteLine("Employee Name: " + employeeName);
    }
}

class Department : Employee
{
    public string department = "";

    public void DisplayDepartment()
    {
        Console.WriteLine("Department: " + department);
    }
}

interface ISalary
{
    void DisplaySalary();
}

interface IBonus
{
    void DisplayBonus();
}

class EmployeeDetails : Employee, ISalary, IBonus
{
    public double salary;
    public double bonus;

    public void DisplaySalary()
    {
        Console.WriteLine("Salary: " + salary);
    }

    public void DisplayBonus()
    {
        Console.WriteLine("Bonus: " + bonus);
    }
}

class Program
{
    static void Main()
    {
        Console.WriteLine("Single Inheritance");

        Department emp1 = new Department();
        emp1.employeeId = 101;
        emp1.employeeName = "Haseen";
        emp1.department = "ECE";

        emp1.DisplayEmployee();
        emp1.DisplayDepartment();

        Console.WriteLine("\nMultiple Inheritance");

        EmployeeDetails emp2 = new EmployeeDetails();
        emp2.employeeId = 102;
        emp2.employeeName = "Arun";
        emp2.salary = 35000;
        emp2.bonus = 5000;

        emp2.DisplayEmployee();
        emp2.DisplaySalary();
        emp2.DisplayBonus();
    }
}
