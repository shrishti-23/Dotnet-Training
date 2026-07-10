//delegate-Type that holds a reference to a method
//similar to function pointer
//predefined delegates:ex.func, action, predicate

using System;

delegate void MessageDelegate(string msg);

class Delegateeg
{
    static MessageDelegate m ;
    static void Display(string message)
    {
        Console.WriteLine("Method1 : " +message);
    }
     static void Display1(string message)
    {
        Console.WriteLine("Method2 : " +message);
    }
     static void Display2(string message)
    {
        Console.WriteLine("Method3 : "+message);
    }
    static void Main()
    {
        Func<int, int, int> add = (a,b) => a+b;
        Console.WriteLine(add(588,756));
        MessageDelegate m = Display;
        m = Display;
        //m +=Display1;
        m +=Display2;

        m("Hello, I am learning dot net c#");

        Button bt = new Button();
        bt.Click +=() => Console.WriteLine("Click event");
        bt.Press();
        Linqeg l = new Linqeg();
        l.Display3();

    }
}
