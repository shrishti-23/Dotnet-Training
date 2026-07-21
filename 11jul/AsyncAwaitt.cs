//async - needed for operations which take sometime
//without async the application waits until the work finishez

using System;
using System.Threading.Tasks;

public class AsyncAwaitt
{
    static async Task Main()
    {
        Console.WriteLine("Loading employee data details......");

        await LoadEmployee();

        Console.WriteLine("Completed");
    }    
    static async Task LoadEmployee()
    {
        await Task.Delay(3000);

        Console.WriteLine("Employee Loaded");
    }

    

}