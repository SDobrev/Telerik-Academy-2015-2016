//Write a program that finds the sequence of maximal sum in given array.

using System;

namespace _08.MaximalSum
{
    class MaximalSum
    {
        static void Main()
        {
            int[] numbers = { 1, 5, -2, -5, 2, 3, 2, -4 };
           

            int maxSoFar = numbers[0];
            int maxStartingHere = numbers[0];
            int begin = 0;
            int tempBegin = 0;
            int end = 0;

            for (int i = 1; i < numbers.Length; i++)
            {
                if (maxStartingHere < 0)
                {
                    maxStartingHere = numbers[i];
                    tempBegin = i;
                }
                else
                {
                    maxStartingHere += numbers[i];
                }

                if (maxSoFar < maxStartingHere)
                {
                    maxSoFar = maxStartingHere;
                    begin = tempBegin;
                    end = i;
                }
            }

            for (int i = begin; i <= end; i++)
            {
                Console.Write("{0} ", numbers[i]);

            }

            Console.WriteLine("Sum = " + maxSoFar);
        }
    }
}
