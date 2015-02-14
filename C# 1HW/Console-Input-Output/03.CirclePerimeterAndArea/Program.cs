//Write a program that reads the radius r of a circle and prints its perimeter and area formatted with 2 digits after the decimal point.

using System;

namespace _03.CirclePerimeterAndArea
{
    class CirclePerimeterAndArea
    {
        static void Main()
        {
            Console.WriteLine("Enter radius of the circle:");
            double rad = double.Parse(Console.ReadLine());
            double perimeter = 2 * Math.PI * rad;
            double area = Math.PI * rad * rad;
            Console.WriteLine("Area = {0:0.00}, Perimeter = {1:0.00}", area, perimeter);
        }
    }
}
