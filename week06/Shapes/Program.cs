using System;
using System.Reflection.Metadata;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the Shapes Project.");

        List<Shapes> shapes = new List<Shapes>();
        // Create a square
        shapes.Add(new Square("yellow", 5));
        // Create a rectangle
        shapes.Add(new Rectangle("blue", 4, 6));
        // Create a circle
        shapes.Add(new Circle("red", 3));
        // Display the color and area of each shape
        foreach (Shapes sha in shapes)
        {
            Console.WriteLine($"Shape Color: {sha.GetColor()}");
            Console.WriteLine($"Shape Area: {sha.GetArea()}");
        }
        // Create a square
        //Square square = new Square("yellow", 5);
        // Display the color and area of the square
        //square.SetColor("yellow");
        //Console.WriteLine($"Square Color: {square.GetColor()}");
        //Console.WriteLine($"Square Area: {square.GetArea()}");
        // Create a rectangle
        //Rectangle rectangle = new Rectangle("blue", 4, 6);
        // Display the color and area of the rectangle
        //rectangle.SetColor("blue");
        //Console.WriteLine($"Rectangle Color: {rectangle.GetColor()}");
        //Console.WriteLine($"Rectangle Area: {rectangle.GetArea()}");
        // Create a circle
        //Circle circle = new Circle("red", 3);
        // Display the color and area of the circle
        //circle.SetColor("red");
        //Console.WriteLine($"Circle Color: {circle.GetColor()}");
        //Console.WriteLine($"Circle Area: {circle.GetArea()}");


    }
}