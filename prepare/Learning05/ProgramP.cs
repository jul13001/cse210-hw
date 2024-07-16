using System;
using System.Net.NetworkInformation;
using System.Reflection;
using employee_demo;

class ProgramP
{
    static void Main(string[] args)
    {
        HourlyEmployee hEmployee = new HourlyEmployee();
        hEmployee.SetName("Arellia");
        hEmployee.SetIdNumber("12354");
        hEmployee.SetPayRate(15);
        hEmployee.SetHoursWorked(35);

        SalaryEmployee sEmployee = new SalaryEmployee();
        sEmployee.SetName("Peter");
        sEmployee.SetIdNumber("45689");
        sEmployee.SetSalary(60000);

        DisplayEmployeeInformation(hEmployee);
        DisplayEmployeeInformation(sEmployee);
        
    }

    public static void DisplayEmployeeInformation(Employee employee)
    {
        float pay = employee.GetPay();
        Console.WriteLine($"{employee.GetName()} will be paid ${pay}");
    }
}