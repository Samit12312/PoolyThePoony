using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace PoolyThePoony
{
    internal class RightAngledTriangle : BasicShape
    {
        public double a;
        public double b;
        public double direction;

        public RightAngledTriangle(Point rightHighPoint, int borderColor, int fillColor, int a, int b): 
            base(rightHighPoint, borderColor, fillColor)
        {
            this.a = a; this.b = b;
        }
        public override void Draw()
        {

            if (direction == 4)
            {
                for (int i = 0; i < a; i++)
                {
                    for (int j = 0; j < i; j++)
                    {
                        Console.Write(" ");
                    }
                    for (int k = 0; k < a - i; k++)
                    {
                        Console.Write("*");
                    }
                    Console.WriteLine();
                }
            }
            if (direction == 3)
            {
                for (int i = 0; i < a; i++)
                {
                    for (int j = 0; j < a - i - 1; j++)
                    {
                        Console.Write(" ");
                    }
                    for (int k = 0; k <= i; k++)
                    {
                        Console.Write("*");
                    }
                    Console.WriteLine();
                }
            }
            if (direction == 2)
            {

                for (int i = 0; i < a; i++)
                {
                    for (int j = 0; j < a - i; j++)
                    {
                        Console.Write("*");

                    }
                    Console.WriteLine();
                }
            }
            if (direction == 1)
            {
                for (int i = 0; i < a; i++)
                {
                    for (int j = 0; j < i + 1; j++)
                    {
                        Console.Write("*");
                    }

                    Console.WriteLine();
                }
            }
        }
        public override double GetParameter()
        {
            double peta = a * a + b * b;
            
            return Math.Sqrt(peta);
        }
        public override double GetArea()
        {
            return a * b / 2;
        }
        public override void PrintDetails()
        {
            base.PrintDetails();
            Console.WriteLine($" a = {this.a} b = {this.b} direction = {this.direction}");
        }

    }
}
