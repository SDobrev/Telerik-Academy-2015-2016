//Write a program that finds the biggest of three numbers.

using System;

namespace _05.TheBiggestOf3Numbers
{
    class TheBiggestOf3Numbers
    {
        static void Main()
        {
            Console.WriteLine("Enter first number: ");
            double fNum = double.Parse(Console.ReadLine());
            Console.WriteLine("Enter second number: ");
            double sNum = double.Parse(Console.ReadLine());
            Console.WriteLine("Enter third number: ");
            double tNum = double.Parse(Console.ReadLine());
            if (fNum > sNum && fNum > tNum)
            {
                Console.WriteLine(fNum);
            }
            else if (sNum > fNum && sNum > tNum)
            {
                Console.WriteLine(sNum);
            }
            else 
                Console.WriteLine(tNum);
            
        }
    }
}
