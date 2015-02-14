//Write a program to calculate n! for each n in the range [1..100].
using System;
using System.Numerics;


namespace _10.NFactorial
{
    class NFactorial
    {
        static void Main()
        {
            int[] arr = new int[100];
            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = i + 1;
                Console.Write("{0}!= ", i + 1);
                Console.WriteLine(CalcFactorial(arr[i])); 
            }
        }
        static BigInteger CalcFactorial (int number)
        {
            BigInteger factorial = 1;
            for (int i = number; i > 0; i--)
            {
                factorial *= i;
            }
            return factorial;
        }
    }
}
