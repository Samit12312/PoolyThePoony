using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PoolyThePoony
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ShapeSystem system = new ShapeSystem(10);

            Console.Write("how many shapes? ");
            int numShapes = int.Parse(Console.ReadLine());

            for (int i = 0; i < numShapes; i++)
            {
                Console.WriteLine("\n1. rectangle\n2. circle\n3. right triangle\n4. cylinder");
                Console.Write("choose shape: ");
                int choice = int.Parse(Console.ReadLine());

                if (choice == 1)
                {
                    Console.Write("x, y: ");
                    int x = int.Parse(Console.ReadLine());
                    int y = int.Parse(Console.ReadLine());
                    Console.Write("border color: ");
                    int borderColor = int.Parse(Console.ReadLine());
                    Console.Write("fill color: ");
                    int fillColor = int.Parse(Console.ReadLine());
                    Console.Write("width: ");
                    int width = int.Parse(Console.ReadLine());
                    Console.Write("length: ");
                    int length = int.Parse(Console.ReadLine());

                    Rectangle rect = new Rectangle(new Point(x, y), borderColor, fillColor, width, length);
                    system.AddShape(rect);
                }
                else if (choice == 2)
                {
                    Console.Write("x, y: ");
                    int x = int.Parse(Console.ReadLine());
                    int y = int.Parse(Console.ReadLine());
                    Console.Write("border color: ");
                    int borderColor = int.Parse(Console.ReadLine());
                    Console.Write("fill color: ");
                    int fillColor = int.Parse(Console.ReadLine());
                    Console.Write("radius: ");
                    int radius = int.Parse(Console.ReadLine());

                    Circle circ = new Circle(new Point(x, y), borderColor, fillColor, radius);
                    system.AddShape(circ);
                }
                else if (choice == 3)
                {
                    Console.Write("x, y: ");
                    int x = int.Parse(Console.ReadLine());
                    int y = int.Parse(Console.ReadLine());
                    Console.Write("border color: ");
                    int borderColor = int.Parse(Console.ReadLine());
                    Console.Write("fill color: ");
                    int fillColor = int.Parse(Console.ReadLine());
                    Console.Write("side A: ");
                    int sideA = int.Parse(Console.ReadLine());
                    Console.Write("side B: ");
                    int sideB = int.Parse(Console.ReadLine());

                    RightAngledTriangle tri = new RightAngledTriangle(new Point(x, y), borderColor, fillColor, sideA, sideB);
                    system.AddShape(tri);
                }
                else if (choice == 4)
                {
                    Console.Write("x, y: ");
                    int x = int.Parse(Console.ReadLine());
                    int y = int.Parse(Console.ReadLine());
                    Console.Write("border color: ");
                    int borderColor = int.Parse(Console.ReadLine());
                    Console.Write("fill color: ");
                    int fillColor = int.Parse(Console.ReadLine());
                    Console.Write("radius: ");
                    int radius = int.Parse(Console.ReadLine());
                    Console.Write("height: ");
                    int height = int.Parse(Console.ReadLine());

                    Cylinder cyl = new Cylinder(new Point(x, y), borderColor, fillColor, radius, height);
                    system.AddShape(cyl);
                }
            }

            Console.WriteLine("\nDetails:");
            system.PrintDetails();

            Console.WriteLine("\nTotal area: " + system.GetArea());
            Console.WriteLine("Total perimeter: " + system.GetPerimeter());

            Console.WriteLine("\nDrawing shapes:");
            system.Draw();

            Console.Write("\nEnter shape type to draw: ");
            string type = Console.ReadLine().ToLower();
            system.Draw();

            int rectangleCount = 0;
            int circleCount = 0;
            int triangleCount = 0;
            int cylinderCount = 0;

            for (int i = 0; i < system.shapesCount; i++)
            {
                if (system.shapes[i] is Rectangle)
                    rectangleCount++;
                else if (system.shapes[i] is Circle)
                    circleCount++;
                else if (system.shapes[i] is RightAngledTriangle)
                    triangleCount++;
                else if (system.shapes[i] is Cylinder)
                    cylinderCount++;
            }

            Console.WriteLine("\nRectangle count: " + rectangleCount);
            Console.WriteLine("Circle count: " + circleCount);
            Console.WriteLine("Right Triangle count: " + triangleCount);
            Console.WriteLine("Cylinder count: " + cylinderCount);
        }
    }
}