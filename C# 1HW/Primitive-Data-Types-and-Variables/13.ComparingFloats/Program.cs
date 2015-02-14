using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _13.ComparingFloats
{
    class ComparingFloats
    {
        static void Main(string[] args)
        {
            // Write a program that safely compares floating-point numbers (double) with precision eps = 0.000001.

            Console.WriteLine("Enter the first number: ");
            decimal firstNumber = decimal.Parse(Console.ReadLine());
            Console.WriteLine("Enter the second number: ");
            decimal secondNumber = decimal.Parse(Console.ReadLine());
            bool comparing = (Math.Abs(firstNumber - secondNumber) < 0.000001m);
            Console.WriteLine(comparing);
 

        }
    }
}
