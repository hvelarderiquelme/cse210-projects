using System;

class Program
{
    static void Main(string[] args)
    {
        Square square1 = new Square("red", 2.3);
        // Console.WriteLine($"color of the square is: {square1.GetColor()} and its area: {Math.Round(square1.GetArea(),2)}");

        Rectangle rectangle1 = new Rectangle("green", 4, 8);
        // Console.WriteLine($"color of the rectangle is: {rectangle1.GetColor()} and its area: {Math.Round(rectangle1.GetArea(),2)}");

        Circle circle1 = new Circle("yellow", 10);
        // Console.WriteLine($"color of the circle is: {circle1.GetColor()} and its area: {Math.Round(circle1.GetArea(),2)}");
        Square s1 = new Square("pink", 3);
        Rectangle s2 = new Rectangle("blue", 2.2, 3.6);
        Circle s3 = new Circle("brown", 5);

        List<Shapes> shapes = new List<Shapes>();
        shapes.Add(square1);
        shapes.Add(rectangle1);
        shapes.Add(circle1);
        shapes.Add(s1);
        shapes.Add(s2);
        shapes.Add(s3);

        foreach(Shapes shape in shapes){
            Console.WriteLine($"color of the shape is: {shape.GetColor()} and its area: {Math.Round(shape.GetArea(),2)}");
        }

    }
}