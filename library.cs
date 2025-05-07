using System;

public class Book
{
    public string title;
    public string author;
    public int page;
    public string[] category;

    public void Display()
    {
        Console.WriteLine($"Book: {title} by {author}, {page} pages.");
    }
}

public class Program
{
    public static void Main()
    {
        PublishBook("Harry Potter and the Philosopher's Stone", "Robert or smth idk", 354, new string[] { "fantasy", "mage", "witch" });
    }

    public static void PublishBook(string title, string author, int page, string[] category)
    {
        Book newBook = new Book();
        newBook.title = title;
        newBook.author = author;
        newBook.page = page;
        newBook.category = category;
        newBook.Display();
    }
}
