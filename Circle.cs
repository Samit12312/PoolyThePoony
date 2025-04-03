using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PoolyThePoony
{
    internal class Circle : BasicShape
    {
        public int radius;
        public Circle(Point point, int BorderColor, int radius) : base(point, BorderColor, radius)
        {
            this.radius = radius;
        }
        public override void Draw()
        {
            Console.WriteLine("Display Circle impossibility in Console Applications");
        }
        public override double GetParameter()
        {
            return radius * 2 * 3.14;
        }
        public override double GetArea()
        {
            return 3.14 * radius * radius;
        }
        public override void PrintDetails()
        {
            base.PrintDetails();
            Console.WriteLine($"Radius: {this.radius}");
        }

    }
}
