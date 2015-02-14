using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _15.BitsExchange
{
    class BitsExchange
    {
        static void Main(string[] args)
        {
            //Write a program that exchanges bits 3, 4 and 5 with bits 24, 25 and 26 of given 32-bit unsigned integer.

            Console.Write("Enter unsigned integer: ");
            int n = int.Parse(Console.ReadLine());

            int positionOne = 3;
            int positionTwo = 24;

            int maskOne = 7 << positionOne;
            int maskTwo = 7 << positionTwo;

            int getNumbersOne = n & maskOne;
            int getNumbersTwo = n & maskTwo;

            int change = (n & ~maskOne) & ~maskTwo;

            int maskThree = (getNumbersOne >> positionOne) << positionTwo;
            int maskFour = (getNumbersTwo >> positionTwo) << positionOne;

            int result = (change | maskThree) | maskFour;

            Console.WriteLine(result);
        }
    }
}
