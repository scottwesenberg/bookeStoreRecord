using System;

public record Bookstore(int ID, string Title, string Author, double Price);

class Program
{
    static void Main(string[] args)
    {
        Bookstore book1 = new Bookstore(1, "The Great Gatsby", "F. Scott Fitzgerald", 10.99);
        Bookstore book2 = new Bookstore(2, "To Kill a Mockingbird", "Harper Lee", 12.99);
        Bookstore book3 = new Bookstore(3, "1984", "George Orwell", 9.99);

        Console.WriteLine($"Book 1: ID: {book1.ID}, Title: '{book1.Title}', Author: {book1.Author}, Price: ${book1.Price}");
        Console.WriteLine($"Book 2: ID: {book2.ID}, Title: '{book2.Title}', Author: {book2.Author}, Price: ${book2.Price}");
        Console.WriteLine($"Book 3: ID: {book3.ID}, Title: '{book3.Title}', Author: {book3.Author}, Price: ${book3.Price}");
    }
}