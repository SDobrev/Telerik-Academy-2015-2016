//We are given a matrix of strings of size N x M. Sequences in the matrix we define
//as sets of several neighbour elements located on the same line, column or diagonal.
//Write a program that finds the longest sequence of equal strings in the matrix.
using System;


namespace _03.SequenceNMatrix
{
    class SequenceMatrix
    {
        static void Main()
        {
            Console.WriteLine("Enter the size of the matrix N");
            int n = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter the size of the matrix M");
            int m = int.Parse(Console.ReadLine());
            string[,] matrix = new string[n, m];
            int maxSequence = 1;

            //filling matrix
            for (int row = 0; row < n; row++)
            {
                for (int col = 0; col < m; col++)
                {
                    Console.Write("matrix[{0},{1}] = ", row, col);
                    matrix[row, col] = Console.ReadLine();
                }
            }
            //check
            for (int row = 0; row < n - 1; row++)
            {
                int sequence = 1;
                for (int col = 0; col < m - 1; col++)
                {
                    if (matrix[row, col] == matrix[row + 1, col])
                    {
                        sequence++;

                    }
                    else if (matrix[row, col] == matrix[row, col + 1])
                    {
                        sequence++;
                    }
                    else if (matrix[row, col] == matrix[row + 1, col + 1])
                    {
                        sequence++;
                    }
                    if (sequence > maxSequence)
                    {
                        maxSequence = sequence;
                    }

                }
            }
            Console.WriteLine(maxSequence);
        }
    }
}
