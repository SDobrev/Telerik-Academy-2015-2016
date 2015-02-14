using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06.Four_DigitNumber
{
    class FourDigitNumber
    {
        static void Main(string[] args)
        {
            //Write a program that takes as input a four-digit number in format abcd (e.g. 2011) and performs the following:
            //Calculates the sum of the digits (in our example 2 + 0 + 1 + 1 = 4).
            //Prints on the console the number in reversed order: dcba (in our example 1102).
            //Puts the last digit in the first position: dabc (in our example 1201).
            //Exchanges the second and the third digits: acbd (in our example 2101).

            Console.WriteLine("Enter four-digit number");
            int number = int.Parse(Console.ReadLine());

            int fourthDigit = number % 10;
            number /= 10;
            int thirdDigit = number % 10;
            number /= 10;
            int secondDigtit = number % 10;
            number /= 10;
            int firstDigit = number % 10;

            int sum = firstDigit + secondDigtit + thirdDigit + fourthDigit; 
            Console.WriteLine("Sum of the digits: " + sum);

            int reverse = 1000 * fourthDigit + 100 * thirdDigit + 10 * secondDigtit + firstDigit;
            Console.WriteLine("The number in reversed order: " + reverse);

            int lastDigitFirst = 1000 * fourthDigit + 100 * firstDigit + 10 * secondDigtit + thirdDigit;
            Console.WriteLine("Last digit in first position: " + lastDigitFirst);

            int exchange = 1000 * firstDigit + 100 * thirdDigit + 10 * secondDigtit + fourthDigit;
            Console.WriteLine("Exchange the second and the thirdt digits: " + exchange);

        }
    }
}
