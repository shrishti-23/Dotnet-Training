using System;

class Manager : Employee
{
    public string dept;
    public double Bonus;

    public Manager(int i, string e, double s,string d, double b) : base(i, e, s)
    {
        dept = d;
        Bonus = b;
    }
    public void DisplayManager()
    {
        Display();
         Console.WriteLine("dept :" +dept);
         Console.WriteLine("Bonus : "+Bonus);
         Console.WriteLine("--------------------");
    }
}