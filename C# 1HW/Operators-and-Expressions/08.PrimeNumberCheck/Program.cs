using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _08.PrimeNumberCheck
{
    class PrimeNumberCheck
    {
        static void Main(string[] args)
        {
            //Write an expression that checks if given positive integer number n (n <= 100) is prime (i.e. it is divisible without remainder only to itself and 1).
            //Note: You should check if the number is positive

            Console.WriteLine("Enter positive number <= 100 to check if's Prime:");
            int number = int.Parse(Console.ReadLine());
            Console.WriteLine("The number is Prime ? {0}", isPrime (number) ? true : false );
        }

        private static bool isPrime(int number)
        {
            if (number < 2) return false;
            if (number == 2) return true;
            for (int i = 2; i <= (int)Math.Sqrt(number); i++)
            {
                if (number % i == 0) return false;
            }
            return true;
        }
    }
}
