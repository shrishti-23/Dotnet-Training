//suppose an API allows searchin in a different wyas 
//search method is same but the parameters will change
//same method.different parameters 
//compiler decides which method to call 

using System;

class CompiletimePoly
{
    public void Search(int id)
    {
        Console.WriteLine("Search by Employee id ");
    }

    public void Search(string firstName, string lastName)
    {
        Console.WriteLine("Search by phone ");
    }

    public void Search(long phone)
    {
        Console.WriteLine("Search by name ");
    }
}