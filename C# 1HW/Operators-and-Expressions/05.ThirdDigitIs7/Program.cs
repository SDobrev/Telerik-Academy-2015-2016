using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05.ThirdDigitIs7
{
    class ThirdDigitIs7
    {
        static void Main(string[] args)
        {
            //Write an expression that checks for given integer if its third digit from right-to-left is 7.

            Console.WriteLine("Enter number to check if its third digit from right-to-left is 7");
            int number = int.Parse(Console.ReadLine());

            number /= 100;

            bool thirdDigitIsSeven = (number % 10) == 7;

            Console.WriteLine("The third digit is 7 ----> " + thirdDigitIsSeven);
        }
    }
}
