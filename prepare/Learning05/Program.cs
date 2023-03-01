using System;

class Program
{
    static void Main(string[] args)
    {
        Book book1 = new Book();
        book1.SetAuthor("Elroe");
        book1.SetTitle("Da Vinci Code");

        string info = book1.GetBookInfo();
        System.Console.WriteLine(info);

        PictureBook book2 = new PictureBook();
        book2.SetAuthor("Yodahe");
        book2.SetTitle("Hard Work!");
        book2.SetIllustrator("Habesha");

        System.Console.WriteLine(book2.GetBookInfo());
        System.Console.WriteLine(book2.GetIllustrator());

        Book book3 = new Book();
        System.Console.WriteLine(book3.GetBookInfo());

        PictureBook book4 = new PictureBook("Daniel", "Father", "Tsige Zewge");
        System.Console.WriteLine(book4.GetPictureBookInfo());

    }
}