//Write a program, that reads from the console an array of N integers and an integer K, 
//sorts the array and using the method Array.BinSearch() finds the largest number in the array which is ≤ K.
using System;

namespace _04.BinarySearch
{
    class BinarySearch
    {
        static void Main()
        {
            Console.WriteLine("Enter length of the array N");
            int n = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter K");
            int k = int.Parse(Console.ReadLine());
            int[] intArray = new int[n];

            // filling array
            for (int i = 0; i < n; i++)
            {
                Console.Write("Enter {0} int element of the array ", i);
                intArray[i] = int.Parse(Console.ReadLine()); 
            }
            Array.Sort(intArray);
            // printing sorted array
            Console.WriteLine("Sorted array: {0}", string.Join(", ", intArray)); 
           
            int index = Array.BinarySearch(intArray, k);
            
            if (index < 0)
            {
                Console.WriteLine("Not found in the array N");
                return;
            }
            else if (intArray[index] == intArray[index + 1])
            {
                
                Console.WriteLine("The largest number in the array which is smaller or equal to K={0} is {1}",k , intArray[index + 1]);
            }
            else if (intArray[index] > intArray[index - 1])
            {

                Console.WriteLine("The largest number in the array which is smaller or equal to K={0} is {1}",k,  intArray[index - 1]);
            }
        }
    }
}
