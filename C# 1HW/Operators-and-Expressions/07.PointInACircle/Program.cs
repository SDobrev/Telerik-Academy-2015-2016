using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07.PointInACircle
{
    class PointInACircle
    {
        static void Main(string[] args)
        {
            //Write an expression that checks if given point (x, y) is inside a circle K({0, 0}, 2).
            Console.WriteLine("Enter X");
            double x = double.Parse(Console.ReadLine());
            Console.WriteLine("Enter Y");
            double y = double.Parse(Console.ReadLine());
            int rad = 2;
            bool isInCircle = (x*x) + (y*y) < (rad*rad);

            Console.WriteLine("Is it in the circle ---> " + isInCircle);
        }
    }
}
