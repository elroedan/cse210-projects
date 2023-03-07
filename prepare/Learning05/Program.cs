using System;

class Program
{
    static void Main(string[] args)
    {
        // Book book1 = new Book();
        // book1.SetAuthor("Elroe");
        // book1.SetTitle("Da Vinci Code");

        // string info = book1.GetBookInfo();
        // System.Console.WriteLine(info);

        // PictureBook book2 = new PictureBook();
        // book2.SetAuthor("Yodahe");
        // book2.SetTitle("Hard Work!");
        // book2.SetIllustrator("Habesha");

        // System.Console.WriteLine(book2.GetBookInfo());
        // System.Console.WriteLine(book2.GetIllustrator());

        // Book book3 = new Book();
        // System.Console.WriteLine(book3.GetBookInfo());

        // PictureBook book4 = new PictureBook("Daniel", "Father", "Tsige Zewge");
        // System.Console.WriteLine(book4.GetPictureBookInfo());


        Square square = new Square(27);
        Rectangle rectangle = new Rectangle(7, 9);
        Circle circle = new Circle(9);
    
        List<Shape> shapes = new List<Shape>();
        shapes.Add(square);
        shapes.Add(circle);
        shapes.Add(rectangle); 

        foreach (Shape shape in shapes)
        {
            DisplayShapeInformation(shape);
        }

    }

    public static void DisplayShapeInformation(Shape shape)
    {
        double area = shape.GetArea();
        shape.SetColor("White");
        string color = shape.GetColor();
        System.Console.WriteLine(color);
        System.Console.WriteLine(area);
    }
}