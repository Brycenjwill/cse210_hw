using System;

class Program
{
    static void Main(string[] args)
    {
        List<Shape> shapes = new List<Shape>();

        Square square1 = new Square("red", 5);
        shapes.Add(square1);
        
        Rectangle rectangle1 = new Rectangle(5, 10, "blue");
        shapes.Add(rectangle1);

        Circle circle1 = new Circle(4, "green");
        shapes.Add(circle1);

        foreach(Shape shape in shapes){
            string color = shape.getColor();

            double area = shape.GetArea();

            Console.WriteLine($"The {color} shape has an area of {area}");
        }

        
    }
}