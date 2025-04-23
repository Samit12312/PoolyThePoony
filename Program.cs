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
            double d = 2;

            if(d == 2)
            {
                Console.SetCursorPosition(5,a);

            }
            if(d == 1)
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
    }
}
