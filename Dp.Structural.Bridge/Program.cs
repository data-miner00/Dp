namespace Dp.Structural.Bridge;

internal static class Program
{
    public static void Main(string[] args)
    {
        var red = new RedColor();
        var blue = new BlueColor();

        // Triangles
        var redTriangle = new TriangleShape(red);
        var blueTriangle = new TriangleShape(blue);

        // Squares
        var redSquare = new SquareShape(red);
        var blueSquare = new SquareShape(blue);

        // Prints
        Console.WriteLine(redTriangle);
        Console.WriteLine(blueTriangle);
        Console.WriteLine(redSquare);
        Console.WriteLine(blueSquare);
    }
}
