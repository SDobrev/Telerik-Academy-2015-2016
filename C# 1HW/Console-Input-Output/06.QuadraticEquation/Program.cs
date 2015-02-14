//Write a program that reads the coefficients a, b and c of a quadratic equation ax2 + bx + c = 0 and solves it (prints its real roots).

using System;

namespace _06.QuadraticEquation
{
    class QuadraticEquation
    {
        static void Main()
        {
            Console.WriteLine("Enter coefficent a:");
            double a = double.Parse(Console.ReadLine());
            Console.WriteLine("Enter coefficent b:");
            double b = double.Parse(Console.ReadLine());
            Console.WriteLine("Enter coefficent c:");
            double c = double.Parse(Console.ReadLine());
            double discriminant = (b * b) - 4 * a * c;
            double x1;
            double x2;

            if (a != 0)
            {
                if (discriminant < 0)
                {
                    Console.WriteLine("No real roots");
                }
                else if (discriminant == 0)
                {
                    x1 = x2 = (-b / (2 * a));
                    Console.WriteLine("x1 = x2 = {0}", x1);
                }
                else
                {
                    x1 = (-b + Math.Sqrt(discriminant)) / (2 * a);
                    x2 = (-b - Math.Sqrt(discriminant)) / (2 * a);
                    Console.WriteLine("x1 = {0}; x2 = {1}", x1, x2);
                }
            }
            else
            {
                x1 = x2 = (-c / b);
                Console.WriteLine("x1 = x2 = {0}", x1);

            }
        }
    }
}
