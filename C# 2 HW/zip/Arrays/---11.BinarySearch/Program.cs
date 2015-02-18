//Write a program that finds the index of given element in a sorted array of integers by using the Binary search algorithm.
using System;


namespace ___11.BinarySearch
{
    class BinarySearch
    {
        static void Main()
        {

            Console.WriteLine("Enter the length of the array N");
            int n = int.Parse(Console.ReadLine());
            int[] array = new int[n];
            Console.WriteLine("Enter the number for which index will search");
            int searchNum = int.Parse(Console.ReadLine());
            int numIndex = 0;

            Console.WriteLine("Enter SORTED array elements of {0} elements", n);
            for (int i = 0; i < n; i++)
            {
                array[i] = int.Parse(Console.ReadLine());
            }
            int min = 0;
            int max = array.Length;
            int middle = 0;
            
            while (true)
            {
                middle = (min + max) / 2;
                if (array[middle] > searchNum)
                {
                    max = middle;
                }
                else if (array[middle] < searchNum)
                {
                    min = middle;

                }

                else
                {
                    numIndex = middle;
                    break;
                }
                if (max == min + 1)
                {
                    if (array[min] == searchNum)
                    {
                        numIndex = min;
                    }
                    else
                    {
                        Console.WriteLine("Searched number is not in the array");
                        return;
                    }
                }
            }

            Console.WriteLine("The index of {0} is {1}", searchNum, numIndex);
        }
    }
}

