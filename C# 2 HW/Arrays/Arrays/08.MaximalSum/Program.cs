//Write a program that finds the sequence of maximal sum in given array.

using System;

namespace _08.MaximalSum
{
    class MaximalSum
    {
        static void Main()
        {
            Console.WriteLine("Enter the length of the array N");
            int n = int.Parse(Console.ReadLine());
            int[] array = new int[n];
            int sum = 0;

            Console.WriteLine("Enter array elements");
            for (int i = 0; i < n; i++)
            {
                array[i] = int.Parse(Console.ReadLine());
            }

            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] + array[i+1] > array[i+1])
                {
                    sum += array[i] + array[i + 1];
                }
            }
        }
    }
}
