//Write a program that reads two integer numbers N and K and an array of N elements from the console.
//Find in the array those K elements that have maximal sum.
using System;


namespace _06.MaximalKSum
{
    class MaximalkSum
    {
        static void Main()
        {
            Console.WriteLine("Enter the length of the array N");
            int n = int.Parse(Console.ReadLine());
            int[] array = new int[n];
            Console.WriteLine("Enter K");
            int k = int.Parse(Console.ReadLine());
            int sum = 0;

            Console.WriteLine("Enter array elements");
            for (int i = 0; i < n; i++)
            {
                array[i] = int.Parse(Console.ReadLine());
            }

            Array.Sort(array);
            for (int i = 0; i < k; i++)
            {
                sum += array[n - i - 1];
            }
            Console.WriteLine(sum);
        }
    }
}
