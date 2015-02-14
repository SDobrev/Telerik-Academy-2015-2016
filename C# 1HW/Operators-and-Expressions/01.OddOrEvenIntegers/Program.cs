using System;


namespace _01.OddOrEvenIntegers
{
    class OddOrEvenIntegers
    {
        static void Main(string[] args)
        {
            //Write an expression that checks if given integer is odd or even.
            Console.WriteLine("Enter number to check if it is Odd");
            int number = int.Parse(Console.ReadLine());
            if (number % 2 == 0)
            {
                Console.WriteLine("False");
            }
            else
            {
                Console.WriteLine("True");
            }
        }
    }
}
