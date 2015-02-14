//Write a program that reads a rectangular matrix of size N x M and finds in it the square 3 x 3 that has maximal sum of its elements.
using System;


namespace _02.MaximalSum
{
    class MaximalSum
    {
        static void Main()
        {
            Console.WriteLine("Enter the size of the matrix N");
            int n = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter the size of the matrix M");
            int m = int.Parse(Console.ReadLine());
            int[,] matrix = new int[n, m];
            int maxSum = int.MinValue;
            int maxSumNumR = 0;
            int maxSumNumC = 0;
            //filling matrix
            for (int row = 0; row < n; row++)
            {
                for (int col = 0; col < m; col++)
                {
                    Console.Write("matrix[{0},{1}] = ", row, col);
                    matrix[row, col] = int.Parse(Console.ReadLine());
                }
            }
            //calculations
            for (int row = 0; row < n - 2; row++)
            {
                for (int col = 0; col < n - 2; col++)
                {
                    int currSum = matrix[col, row] + matrix[col + 1, row] + matrix[col + 2, row] + 
                                  matrix[col, row + 1] + matrix[col + 1, row + 1] + matrix[col + 2, row + 1] + 
                                  matrix[col, row + 2] + matrix[col + 1, row + 2] + matrix[col + 2, row + 2];
                    if (currSum > maxSum)
                    {
                        maxSum = currSum;
                        maxSumNumR = row;
                        maxSumNumC = col;
                    }
                }
            }
            //printing max sum numbers
            for (int row = 0; row < 3; row++)
            {
                for (int col = 0; col < 3; col++)
                {
                    Console.Write("{0, 4} ", matrix[maxSumNumR + row, maxSumNumC + col]);
                }
                Console.WriteLine();
            }
            Console.WriteLine("The max sum is {0} ", maxSum );
           

        }
    }
}
