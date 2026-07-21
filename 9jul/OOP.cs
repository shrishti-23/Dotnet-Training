using System;

class OOP
{
    static void Main()
    {
        Employee e = new Employee();

        e.EmpName = "Shrishti";
        e.Salary = 10000;

        Console.WriteLine(e.EmpName+ " " +e.Salary);

        // encapsulation : data protection, validation,controlled access

        CompiletimePoly c = new CompiletimePoly();
        c.Search(101);
        c.Search(2345632466);
        c.Search("Shrishti", "Ingale");


        RuntimePoly r = new RuntimePoly();
     

        r.Checkout(new UpiPayment(), 500);
        r.Checkout(new CreditPayment(), 55000);
        r.Checkout(new NetBanking(), 256800);

        


    }
}
