//Write a program that reads two integer arrays from the console and compares them element by element.

using System;

namespace _02.CompareArrays
{
    class CompareArrays
    {
        static void Main(string[] args)
        {
            Console.Write("Enter first array length: ");
            int first = int.Parse(Console.ReadLine());
            int[] firstArr = new int[first];

            Console.Write("Enter second array length: ");
            int sec = int.Parse(Console.ReadLine());
            int[] secondArr = new int[sec];

            bool equal = true;
            if (firstArr.Length != secondArr.Length)
            {
                equal = false;
            }
            else
            {
                Console.WriteLine("Enter first array elements");
                for (int i = 0; i < firstArr.Length; i++)
                {
                    firstArr[i] = int.Parse(Console.ReadLine());
                }
                Console.WriteLine("Enter second array elements");
                for (int i = 0; i < secondArr.Length; i++)
                {
                    secondArr[i] = int.Parse(Console.ReadLine());
                }


                for (int i = 0; i < firstArr.Length; i++)
                {
                    if (firstArr[i] != secondArr[i])
                    {
                        equal = false;
                    }
                }
            }
            Console.WriteLine(equal);
        }
    }
}
