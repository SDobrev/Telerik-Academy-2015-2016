//Write a method that returns the index of the first element in array that is larger than its neighbours, or -1, if there’s no such element.
//Use the method from the previous exercise.
using System;

namespace _06.FirstLargerThanNeighbours
{
    class FirstLargerThanNeighbours
    {
        static void Main()
        {
            int[] numbers = { 9, -1, 25, 4, 4, 3, 1, 2, 9, 4, 5, 5, 5, 3, 3, 3, 9 };
            int index = BiggerThanNeighbours(numbers);
            Console.WriteLine("Index of the first element in array that is larger than its neighbours is {0}", index);

        }

        static int BiggerThanNeighbours(int[] array)
        {
            for (int i = 1; i < array.Length - 1; i++)
            {
                if (array[i] > array[i - 1] && array[i] > array[i + 1])
                {
                    return i;
                }
            }
            return -1;
        }
    }
}
