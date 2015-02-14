using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _09.Trapezoids
{
    class Program
    {
        static void Main(string[] args)
        {
            //Write an expression that calculates trapezoid's area by given sides a and b and height h.

            Console.WriteLine("Enter trapezoid's side a:");
            double a = double.Parse(Console.ReadLine());
            Console.WriteLine("Enter trapezoid's side b:");
            double b = double.Parse(Console.ReadLine());
            Console.WriteLine("Enter trapezoid's height h:");
            double h = double.Parse(Console.ReadLine());
            double area = ((a + b) / 2) * h;
            Console.WriteLine("Trapezoid's area is: " + area);
        }
    }
}
