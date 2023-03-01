using System;

class Program
{
    static void Main(string[] args)
    {
        Book book1 = new Book();
        book1.SetAuthor("Elroe");
        book1.SetTitle("A Great book");

        string info = book1.GetBookInfo();
        System.Console.WriteLine(info);
    }
}