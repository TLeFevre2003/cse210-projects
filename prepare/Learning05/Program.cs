using System;
using System.Collections.Generic;
namespace Learning05
{
    class Program
    {
        static void Main(string[] args)
        {
            Square mySquare = new Square("red",20);

            Rectangle myRectangle = new Rectangle("red",10,5);

            Circle myCircle = new Circle("red",11);

            List<Shape> shapes = new List<Shape>
            {
                mySquare,
                myRectangle,
                myCircle
            };
            foreach (Shape shape in shapes)
            {
                Console.WriteLine($"The color is {shape.GetColor()} the area is {shape.GetArea()}");


            }
        }
    }
}