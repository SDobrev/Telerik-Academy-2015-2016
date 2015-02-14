using System;

//Sorting an array means to arrange its elements in increasing order. Write a program to sort an array.
//Use the Selection sort algorithm: Find the smallest element, move it at the first position, 
//find the smallest from the rest, move it at the second position, etc.

namespace _07.SelectionSort
{
    class SelectionSort
    {
        static void Main()
        {
            Console.WriteLine("Enter the length of the array N");
            int n = int.Parse(Console.ReadLine());
            int[] array = new int[n];
            Console.WriteLine("Enter array elements");

            for (int i = 0; i < n; i++)
            {
                array[i] = int.Parse(Console.ReadLine());
            }

            for (int i = 0; i < n; i++)
            {
                int min = i;
                for (int j = 0 + 1; j < n; j++)
                {
                    
                    if (array[i] > array[j])
                    {
                        min = j;
                    }
                }
                if (min != i)
                {
                    int temp = 0;
                    temp = array[i];
                    array[i] = array[min];
                    array[min] = temp;
                }
            }
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine(array[i]);
            }
        }
    }
}
