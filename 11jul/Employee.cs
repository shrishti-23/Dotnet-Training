using System;

using System;

public class Employee
{
    public int id;
    public string EmpName;
    public double MonthlySalary;

    // Constructor
    public Employee(int i, string e, double s)
    {
        id = i;
        EmpName = e;
        MonthlySalary = s;
    }

    // Method to calculate annual salary
    public double CalculateAnnualSalary()
    {
        return MonthlySalary * 12;
    }

    // Method to display employee details
    public void Display()
    {
        Console.WriteLine("Id : " + id);
        Console.WriteLine("Name : " + EmpName);
        Console.WriteLine("Monthly Salary : " + MonthlySalary);
        Console.WriteLine("Annual Salary : " + CalculateAnnualSalary());
        Console.WriteLine("------------------------");
    }
}