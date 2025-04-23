using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PoolyThePoony
{
    public class ShapeSystem
    {
        public BasicShape[] shapes;
        public int shapesCount;

        public ShapeSystem(int shapesCount)
        {
            this.shapes = new BasicShape[shapesCount];
            this.shapesCount = 0;
        }
        public void AddShape(BasicShape shape)
        {
            if (this.shapesCount < this.shapes.Length)
            {
                this.shapes[shapesCount] = shape;
                this.shapesCount++;
            }
        }

        public void PrintDetails()
        {
            for (int i = 0; i < this.shapesCount; i++)
            {
                this.shapes[i].PrintDetails();
            }
        }
        public double GetArea()
        {
            double sum = 0;
            for (int i = 0; i < this.shapesCount; i++)
            {
                sum += this.shapes[i].GetArea();
            }
            return sum;
        }
        public double GetPerimeter()
        {
            double sum = 0;
            for (int i = 0; i < this.shapesCount; i++)
            {
                sum += this.shapes[i].GetParameter();
            }
            return sum;
        }
        public void Draw()
        {
            for (int i = 0; i < this.shapesCount; i++)
            {
                this.shapes[i].Draw();
                Console.WriteLine("");
            }
        }
        public void Report()
        {
            int[] shapesTypes = new int[4];
            for (int i = 0; i < this.shapesCount; i++)
            {
                if (this.shapes[i] is Rectangle)
                {
                    shapesTypes[0]++;
                }
                else if (this.shapes[i] is Circle)
                {
                    shapesTypes[1]++;
                }
                else if (this.shapes[i] is RightAngledTriangle)
                {
                    shapesTypes[2]++;
                }
                else if (this.shapes[i] is Cylinder)
                {
                    shapesTypes[3]++;
                }
                Console.WriteLine("rectangle count: " + shapesTypes[0]);
                Console.WriteLine("circle count: " + shapesTypes[1]);
                Console.WriteLine("right angled triangle count: " + shapesTypes[2]);
                Console.WriteLine("cylinder count: " + shapesTypes[3]);
            }
        }
    }
}
