//Write a program that finds the maximal increasing sequence in an array.
using System;

namespace _05.MaximalIncreasingSequence
{
    class IncreasingSeq
    {
        static void Main()
        {
            Console.WriteLine("Enter the length of the array");
            int length = int.Parse(Console.ReadLine());
            int[] array = new int[length];
           
            int counter = 0;
            int maxSeqNum = 0;
            int tempCounter = 1;

            for (int i = 0; i < length; i++)
            {
                array[i] = int.Parse(Console.ReadLine());

            }

            for (int i = 0; i < length - 1; i++)
            {
               if (array[i] < array[i+1])
               {
                   tempCounter++;
                   if(tempCounter > counter)
                   {
                       maxSeqNum = array[i + 1];
                       counter = tempCounter;
                   }
               }
               else
               {
                   tempCounter = 1;
               }
               
            }
           
            for (int i = counter; i > 0; i--)
            {
                Console.Write("{0} ", (maxSeqNum - i + 1));
            }

        }
    }
}
