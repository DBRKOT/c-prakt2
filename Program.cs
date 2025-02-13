using System;

class Rectangle
{
    public double Width;
    public double Height;

    static Rectangle()
    {
        Console.WriteLine("Статический конструктор");
    }
        public Rectangle(double width, double height)
    {
        Width = width;
        Height = height;
    }
    public Rectangle()
    {
        Width = 5;
        Height = 10;
    }
    public Rectangle(Rectangle Cop)
    {
        Width = Cop.Width;
        Height = Cop.Height;
    }
    ~Rectangle()
    {
        Console.WriteLine("Объект Rectangle уничтожен.");
    }
    public double CalculatePloshad()
    {
        return Width * Height;
    }
    public void Info()
    {
        Console.WriteLine($"Ширина: {Width}, Высота: {Height}, Площадь: {CalculatePloshad()}");
    }
    static void Main(string[] args)
    {
        Rectangle rectangle = new Rectangle();
        Console.WriteLine($"Ширина{rectangle.Width},Высота{rectangle.Width}");

        Rectangle rectangleCop = new Rectangle(rectangle);
        Console.WriteLine($"Ширина копии: {rectangleCop.Width}, Высота копии: {rectangleCop.Height}");

        Console.WriteLine($"Площадь rectangle: {rectangle.CalculatePloshad()}");
        Console.WriteLine($"Площадь копии: {rectangleCop.CalculatePloshad()}");
    }
}
