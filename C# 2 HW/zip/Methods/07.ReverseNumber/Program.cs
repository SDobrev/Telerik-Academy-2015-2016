//Write a method that reverses the digits of given decimal number.

using System;

namespace _07.ReverseNumber
{
    class ReverseNumber
    {
        static void Main()
        {
            Console.WriteLine("Enter number");
            decimal num = decimal.Parse(Console.ReadLine());

            Console.WriteLine("Reversed {0}", ReverseNum(num));
        }
        static decimal ReverseNum(decimal number)
        {
            return decimal.Parse(ReverseString(number.ToString()));
        }

        static string ReverseString(string s)
        {
            char[] charArray = s.ToCharArray();
            Array.Reverse(charArray);
            return new string(charArray);
        }
    }
}
