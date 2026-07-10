//Events - based on delegate and used to notify other classes whn something happens

using System;

class Button
{
    public event Action Click;

    public void Press()
    {
        Console.WriteLine("Button is pressed");
        Click? .Invoke();

    }
}