using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Versioning;
using System.Text;
using System.Threading.Tasks;

namespace PoolyThePoony
{
    internal class Rectangle : BasicShape
    {
        double height;
        double length;
        public Rectangle(Point point, int borderColor, int fillColor, double height, double length) : 
            base(point, borderColor, fillColor)
        {
            this.height = height; this.length = length;
        }
        public override void Draw()
        {
            for(int i = 0;  i < height; i++)
            {
                for(int j = 0; j < length; j++)
                {
                   Console.Write("█");
                }
                Console.WriteLine();
            }
        }
        public override double GetParameter()
        {
            return height * 2 + length * 2; 
        }
        public override double GetArea()
        {
            return this.height * this.length;
        }
        public override void PrintDetails()
        {
            Console.WriteLine($"Height: {this.height}");
            Console.WriteLine($"Length: {this.length}");
            base.PrintDetails();
            Console.WriteLine($"Border Color: {this.borderColor}");
            Console.WriteLine($"Fill Color: {this.fillColor}");
        }
    }
}
