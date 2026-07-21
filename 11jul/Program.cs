using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
       Genericseg<int> n = new Genericseg<int>();
       n.Print(100);

         Genericseg<string> n1 = new Genericseg<string>();
       n1.Print("Shrishti");

         Genericseg<double> n2 = new Genericseg<double>();
       n2.Print(100.56);


       string empName = "SHRISHTI";
       Console.WriteLine(empName.ProperCase()); 

    

        List<Employee> employees = new List<Employee>();
        List<Manager> managers = new List<Manager>();

        while (true)
        {
            Console.WriteLine("\n===== Employee Management System =====");
            Console.WriteLine("1. Add Employee ");
            Console.WriteLine("2. Add Manager ");
            Console.WriteLine("3. View All Employees ");
            Console.WriteLine("4. View All Managers ");
            Console.WriteLine("5. Search Employee by ID ");
            Console.WriteLine("6. Exit ");

            Console.Write("Enter your choice (1-6): ");

            try
            {
                int choice = Convert.ToInt32(Console.ReadLine());

                switch (choice)
                {
                    case 1: // Add Employee
                        Console.Write("Enter Employee ID: ");
                        int id = Convert.ToInt32(Console.ReadLine());

                        if (employees.Exists(e => e.id == id) || managers.Exists(m => m.id == id))
                        {
                            Console.WriteLine("ID already exists.");
                            break;
                        }

                        Console.Write("Enter Employee Name: ");
                        string name = Console.ReadLine();

                        Console.Write("Enter Monthly Salary: ");
                        double salary = Convert.ToDouble(Console.ReadLine());

                        Employee employee = new Employee(id, name, salary);
                        employees.Add(employee);
                        Console.WriteLine("Employee added successfully.");
                        break;

                    case 2: // Add Manager
                        Console.Write("Enter Manager ID: ");
                        int mid = Convert.ToInt32(Console.ReadLine());

                        if (employees.Exists(e => e.id == mid) || managers.Exists(m => m.id == mid))
                        {
                            Console.WriteLine("ID already exists.");
                            break;
                        }

                        Console.Write("Enter Manager Name: ");
                        string mname = Console.ReadLine();

                        Console.Write("Enter Monthly Salary: ");
                        double msalary = Convert.ToDouble(Console.ReadLine());

                        Console.Write("Enter Department: ");
                        string dept = Console.ReadLine();

                        Console.Write("Enter Bonus: ");
                        double bonus = Convert.ToDouble(Console.ReadLine());

                        Manager manager = new Manager(mid, mname, msalary, dept, bonus);
                        managers.Add(manager);
                        Console.WriteLine("Manager added successfully.");
                        break;

                    case 3: // View All Employees
                        if (employees.Count == 0)
                            Console.WriteLine("No employees in the system.");
                        else
                            foreach (Employee emp in employees)
                                emp.Display();
                        break;

                    case 4: // View All Managers
                        if (managers.Count == 0)
                            Console.WriteLine("No managers in the system.");
                        else
                            foreach (Manager mgr in managers)
                                mgr.DisplayManager();
                        break;

                    case 5: // Search Employee by ID - checks both lists
                        Console.Write("Enter ID to search: ");
                        int searchId = Convert.ToInt32(Console.ReadLine());

                        bool found = false;
                        foreach (Employee emp in employees)
                        {
                            if (emp.id == searchId)
                            {
                                emp.Display();
                                found = true;
                                break;
                            }
                        }
                        foreach (Manager mgr in managers)
                        {
                            if (mgr.id == searchId)
                            {
                                mgr.DisplayManager();
                                found = true;
                                break;
                            }
                        }
                        if (!found) Console.WriteLine("ID not found.");
                        break;

                    case 6: // Exit
                        Console.WriteLine("Thank you! Exiting...");
                        return;

                    default:
                        Console.WriteLine("Invalid choice. Please enter 1-6.");
                        break;
                }
            }
            catch (FormatException)
            {
                Console.WriteLine("Please enter valid numeric input.");
            }
            catch (Exception e)
            {
                Console.WriteLine("Error: " + e.Message);
            }
        }
    }
}