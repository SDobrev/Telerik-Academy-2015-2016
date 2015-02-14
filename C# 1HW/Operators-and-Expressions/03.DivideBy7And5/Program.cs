using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.DivideBy7And5
{
    class DivideBy7And5
    {
        static void Main(string[] args)
        {
            //Write a Boolean expression that checks for given integer if it can be divided (without remainder) by 7 and 5 at the same time.

            Console.WriteLine("Enter number to check if it can be divided (without remainder) by 7 and 5 at the same time.");
            int number = int.Parse(Console.ReadLine());
            bool divide = (number % 7) == 0 && (number % 5) == 0;
            Console.WriteLine("Is {0} divisible by 5 and 7 at the same time ---> {1}", number, divide);

        }
    }
}
