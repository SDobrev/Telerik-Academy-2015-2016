//Write methods to calculate minimum, maximum, average, sum and product of given set of integer numbers.
//Use variable number of arguments.
using System;


namespace _14.IntegerCalculations
{
    class IntegerCalculations
    {
        static void Main()
        {
            Console.WriteLine("Min {0}", min(4, -3, 18, 21, 5));
            Console.WriteLine("Max {0}", max(1, 2, 4, -3, 18, 21, 5));
            Console.WriteLine("Average {0}", avg(1, 2, 4, -3, 18, 21, 5));
            Console.WriteLine("Sum {0}", sum(1, 2, 4, -3, 18, 21, 5));
            Console.WriteLine("Product {0}", product(2, 4, 18, 21, 5));
            
        }
        static int min(params int[] sequence)
        {
            int min = int.MaxValue;
            for (int i = 0; i < sequence.Length; i++)
            {
                if (sequence[i] < min)
                {
                    min = sequence[i];
                }
            }
            return min;
        }
        static int max(params int[] sequence)
        {
            int max = int.MinValue;
                for (int i = 0; i < sequence.Length; i++)
			{
			 if (sequence[i] > max)
             {
                 max = sequence[i];
             }
			}
            return max;
        }
        static int avg(params int[] sequence)
        {
            int average = 0;
            for (int i = 0; i < sequence.Length; i++)
            {
                average += sequence[i];
            }
            return average / sequence.Length;
        }
        static int sum(params int[] sequence)
        {
            int sum = 0;
            for (int i = 0; i < sequence.Length; i++)
            {
                sum += sequence[i];
            }
            return sum;
        }
        static int product(params int[] sequence)
        {
            int product = 1;
            for (int i = 0; i < sequence.Length; i++)
			{
			 product *= sequence[i];
			}
            return product;
        }
    }
}
