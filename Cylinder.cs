using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PoolyThePoony
{
    internal class Cylinder : BasicShape
    {
        private int height;
        private int radius;
        public Cylinder(Point point, int borderColor, int fillColor, int heigth, int radius) : base(point, borderColor, fillColor)
        {
            this.height = heigth; this.radius = radius;
        }
        public override void Draw()
        {
            Console.WriteLine("Display Cylinder impossibility in Console Applications");
        }
        public double Getvolume()
        {
            return 3.14 * radius * radius * height;
        }
        public override double GetArea()
        {
            return 2 * 3.14 * radius * height;
        }

        public int GetHeight()
        {
            return this.height;
        }
        public void SetHeight(int height)
        {
            this.height = height;
        }


    }
}
