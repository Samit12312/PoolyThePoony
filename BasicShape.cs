using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace PoolyThePoony
{
    internal class BasicShape
    {
        public Point point;
        public int borderColor;
        public int fillColor;
        public BasicShape(Point point, int borderColor, int fillColor)
        {
            this.point = point;
            this.borderColor = borderColor;
            this.fillColor = fillColor;
        }
        public virtual void PrintDetails()
        {
            Console.WriteLine($"Position: ({this.point.GetX()}, {this.point.GetY()})");
            Console.WriteLine($"Border Color: {this.borderColor}");
        }
        public virtual double GetArea()
        {
            return 0;
        }
        public virtual double GetParameter()
        {
            return 0;
        }
        public virtual void Draw()
        {
            Console.WriteLine();
        }   
    }
}
