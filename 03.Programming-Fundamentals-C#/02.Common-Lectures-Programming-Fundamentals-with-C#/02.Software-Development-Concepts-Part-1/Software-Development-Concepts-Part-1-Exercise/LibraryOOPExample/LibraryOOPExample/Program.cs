using System;
using System.Collections.Generic;

public class Book
{
    public string Title { get; set; }
    public string Author { get; set; }
    public int Pages { get; set; }

    public void PrintInfo()
    {
        Console.WriteLine($"Title: {Title}, Author: {Author}, Pages: {Pages}");
    }
}

public class Library
{
    public List<Book> Books { get; set; } = new List<Book>();

    public void AddBook(Book book)
    {
        Books.Add(book);
    }

    public void PrintAllBooks()
    {
        foreach (var book in Books)
        {
            book.PrintInfo();
        }
    }
}

class Program
{
    static void Main()
    {
        Book book1 = new Book { Title = "1984", Author = "George Orwell", Pages = 328 };
        Book book2 = new Book { Title = "The Hobbit", Author = "J.R.R. Tolkien", Pages = 310 };
        Book book3 = new Book { Title = "Clean Code", Author = "Robert C. Martin", Pages = 464 };

        Library myLibrary = new Library();
        myLibrary.AddBook(book1);
        myLibrary.AddBook(book2);
        myLibrary.AddBook(book3);

        myLibrary.PrintAllBooks();

        Console.ReadLine();
    }
}
