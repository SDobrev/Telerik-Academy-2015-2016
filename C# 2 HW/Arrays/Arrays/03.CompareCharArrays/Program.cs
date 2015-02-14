//Write a program that compares two char arrays lexicographically (letter by letter).
using System;


namespace _03.CompareCharArrays
{
    class CompareCharArr
    {
        static void Main()
        {
            Console.Write("Enter first array length: ");
            int first = int.Parse(Console.ReadLine());
            char[] firstArr = new char[first];

            Console.Write("Enter second array length: ");
            int sec = int.Parse(Console.ReadLine());
            char[] secondArr = new char[sec];

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
                    firstArr[i] = char.Parse(Console.ReadLine());
                }
                Console.WriteLine("Enter second array elements");
                for (int i = 0; i < secondArr.Length; i++)
                {
                    secondArr[i] = char.Parse(Console.ReadLine());
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
