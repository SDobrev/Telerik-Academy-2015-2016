using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10.PointInsideCircleAndOutsideOfRectangle
{
    class PointInsideCircleAndOutsideOfRectangle
    {
        static void Main(string[] args)
        {
            //Write an expression that checks for given point (x, y) if it is within the circle K({1, 1}, 1.5) and out of the rectangle R(top=1, left=-1, width=6, height=2).


            Console.WriteLine("Enter X");
            double x = double.Parse(Console.ReadLine());
            Console.WriteLine("Enter Y");
            double y = double.Parse(Console.ReadLine());
         
            bool isInCircleAndOutsideOfRectangle = (x - 1)*(x - 1) + (y - 1)*(y - 1) <= 1.5 * 1.5 
                && (y > 1) ;

            Console.WriteLine("Is it in the circle And outside of Rectangle ---> " + isInCircleAndOutsideOfRectangle);
        }
    }
}
