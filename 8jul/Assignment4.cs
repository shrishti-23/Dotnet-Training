using System;
using System.Collections.Generic;

class Assignment4
{
    static void Main()
    {
        // Creating and initializing a list of books
        List<string> books = new List<string>()
        {
            "C Programming",
            "Java Programming",
            "Python Programming",
            "Data Structures",
            "Computer Networks"
        };

        // Display all books
        Console.WriteLine("Available Books:");

        foreach (string book in books)
        {
            Console.WriteLine(book);
        }

        // Add a new book
        books.Add("C# Programming");

        // Remove an old book
        books.Remove("Java Programming");

        // Display updated list
        Console.WriteLine("\nUpdated Book List:");

        foreach (string book in books)
        {
            Console.WriteLine(book);
        }

        // Display total number of books
        Console.WriteLine("\nTotal Number of Books: " + books.Count);
    }
}