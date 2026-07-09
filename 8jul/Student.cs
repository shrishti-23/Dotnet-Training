//Class- Logical Entity. it defines properties(data) and functions that object wil have.
//Store values of similar data.
//


using System;

class Student
{

    public int rollno;
    public String name;
    public String institute;
    public long dob;
    public String branch;
    public char gender;
    public float height;

    public Student(int r,String n, String i, String b, long d, char g, float h)
    {
        rollno = r;
        name = n;
        institute = i;
        branch = b;
        dob = d;
        gender = g;
        height = h;

    }

    public void display()
    {
        Console.WriteLine("Rollno: " +rollno);
         Console.WriteLine("Name: " +name);
          Console.WriteLine("DOB: " +dob);
           Console.WriteLine("Gender: " +gender);
            Console.WriteLine("height: " +height);
            Console.WriteLine("Branch: " +branch);
            Console.WriteLine("Institute: " +institute);

        
    }
}