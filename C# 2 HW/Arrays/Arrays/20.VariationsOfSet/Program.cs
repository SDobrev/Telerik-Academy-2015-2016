//Write a program that reads two numbers N and K and generates all the variations of K elements from the set [1..N].

using System;


namespace _20.VariationsOfSet
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter N");
            int n = int.Parse(Console.ReadLine());
            int[] array = new int[n];
            Console.WriteLine("Enter K");
            int k = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                array[i] = i + 1;
            }

            for (int i = 0; i < n; i++)
            {
                Console.Write(array[i] + "," + " ");
                for (int variations = 0; variations < k; variations++)
                {
                    Console.Write(array[i + i]);
                    Console.WriteLine();
                }
                
            }
           

        }
    }
}
