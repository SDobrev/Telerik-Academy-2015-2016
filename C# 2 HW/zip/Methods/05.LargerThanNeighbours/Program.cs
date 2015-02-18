//Write a method that checks if the element at given position in given array of integers is larger than its two neighbours (when such exist).
using System;


namespace _05.LargerThanNeighbours
{
    class LargerThanNeighbours
    {
        static void Main()
        {
            int[] numbers = {9, 5, -1, 5, 5, 3, 1, 2, 3, 4, 5, 6, 5, 3, 5, 3, 9 };

            // to check please edint elementPosition

            int elementPosition = 15;
            BiggerThanNeighbours(numbers, elementPosition);
        }
        static void BiggerThanNeighbours (int[] array, int position)
        {
            if (position - 1 > 0 && position + 1 < array.Length)
            {
                if (array[position] > array[position - 1] && array[position] > array[position + 1])
                {
                    Console.WriteLine("Element at position {0} is bigger than its two neighbours", position);
                }
                else
                {
                    Console.WriteLine("Element at position {0} is NOT bigger than its two neighbours", position);
                }
            }
            else
            {
                Console.WriteLine("Element at position {0} doesn't have two neighbours", position);
            }
        }
    }
}
