namespace GeometricShapes;

internal class Program
{
    static void Main(string[] args)
    {
        //QUAD

        //create new instance
        Quad q1 = new Quad (3, 4, 5, 6);
        Quad q2 = new Quad(10, 10, 20, 20);
        
        //call Area and Perimeter methods
        q2.Area();
        Console.WriteLine($"Perimeter is {q2.Perimeter()}");

        //RECTANGLE

        //create new instance
        Rect rect1 = new Rect(10, 5);

        //call Area and Perimeter methods
        Console.WriteLine($"Area is {rect1.Area()} and Perimeter is {rect1.Perimeter()}");

        //SQUARE

        Square sqr = new Square(5);
        Console.WriteLine($"Area is {sqr.Area()} and Perimeter is {sqr.Perimeter()}");
    }
}
