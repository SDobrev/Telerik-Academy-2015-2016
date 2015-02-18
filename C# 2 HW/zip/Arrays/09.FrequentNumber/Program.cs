//Write a program that finds the most frequent number in an array.
using System;


namespace _09.FrequentNumber
{
    class FrequentNumber
    {
        static void Main()
        {

            Console.WriteLine("Enter the length of the array N");
            int n = int.Parse(Console.ReadLine());
            int[] array = new int[n];
            int counter = 0;
            int element = 0;
            Console.WriteLine("Enter array elements");
            for (int i = 0; i < n; i++)
            {
                array[i] = int.Parse(Console.ReadLine());
            }
            for (int i = 0; i < n; i++)
            {
                int tempcounter = 1;
                for (int j = 1; j < n; j++)
                {

                    if (array[i] == array[j] && i != j)
                    {
                        tempcounter++;
                    }

                }
                if (tempcounter > counter)
                {
                    counter = tempcounter;
                    element = array[i];
                }
            }
            Console.WriteLine("{0} ({1} times)", element, counter);
        }
    }
}

