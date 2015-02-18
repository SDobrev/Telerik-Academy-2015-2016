//Write a method that counts how many times given number appears in given array.
//Write a test program to check if the method is workings correctly.
using System;

namespace _04.AppearanceCount
{
    class AppearanceCount
    {
        static void Main()
        {
            int[] numbers = { 5, -1, 5, 5, 3, 1, 2, 3, 4, 5, 6, 5, 3, 5, 3, 9 };

            // to check please edit searchedNumber

            int searchedNumber = 3;
            int count = NumberCount(numbers, searchedNumber);
            Console.WriteLine("{0} appears in the given array {1} times", searchedNumber, count);
        }
        static int NumberCount (int[] array, int searchedNum)
        {
            int count = 0;
            for (int i = 0; i < array.Length; i++)
            {
                if ( searchedNum == array[i])
                {
                    count++;
                }
            }
            return count;
        }
    }
}
