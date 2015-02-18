//Write a program that finds the maximal sequence of equal elements in an array.

using System;

namespace _4.MaximalSequence
{
    class MaximalSequence
    {
        static void Main()
        {
            Console.WriteLine("Enter the length of the array");
            int length = int.Parse(Console.ReadLine());
            int[] array = new int[length];
            int tempcounter = 1;
            int counter = 0;
            int maxSeqNum = 0;

            for (int i = 0; i < length; i++)
            {
                array[i] = int.Parse(Console.ReadLine());

            }
            for (int i = 0; i < length - 1; i++)
            {
                if (array[i] == array[i + 1])
                {
                    tempcounter++;
                    if (counter < tempcounter)
                    {
                        counter = tempcounter;
                        maxSeqNum = i;
                    }
                }
                else
                {
                    tempcounter = 1;
                }

            }
            for (int i = 0; i < counter; i++)
            {
                Console.Write("{0} ", array[maxSeqNum]);
            }

        }
    }
}
