//variables and datatypes
/*
String name = "Shrishti";
int marks = 80;
float number = 5.2f;
bool isStudent = true;

Console.WriteLine("Name:" + name);
Console.WriteLine("Marks:" + marks);
Console.WriteLine("Number:" + number);
Console.WriteLine("isStudent:" +isStudent);
*/

//Opertors
class Variable_operators
{
    static void Main(String[] args)
    {
        int a=5;
int b=1;
Console.WriteLine("Addition: "+(a + b));

int x = 20;
Console.WriteLine("Assignment: "+x);

int number = 6;
number--;
Console.WriteLine("decrement: "+number);

int marks = 10;
marks++;
Console.WriteLine("increment: "+marks);

int y = 11;
Console.WriteLine(y>=10 && y<=30);

Assignment1 t = new Assignment1();
t.display();

Assignment2 obj = new Assignment2();
obj.shown();

    }
}
