//exception handling prevents a program crashing when error occurs
//try - risky code
//catch(Exception e) - handle exception
//finally - always executes
//throw

using System;

class Exceptioneg
{
    static void Main()
    {
        static void CheckAge(int age)
        {
            if (age < 20)
            {
                throw new Exception("Not eligible for Placement Drive");
            }
            Console.WriteLine("can attend placement drive");
        }
        try
        {
            int a = 50;
            int b = 0;
            int c = a/b;
            Console.WriteLine(c);

        }
        catch(DivideByZeroException e)
        {
            Console.WriteLine(e.Message);
        }

        try
        {
            CheckAge(25);
        }
        catch
        {
            
        }
    }
}