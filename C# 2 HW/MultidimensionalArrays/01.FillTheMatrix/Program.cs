//Write a program that fills and prints a matrix of size (n, n) as shown below:

using System;


namespace _01.FillTheMatrix
{
    class FillMatrix
    {
        static void Main()
        {
            Console.WriteLine("Enter the size of the matrix n");
            int n = int.Parse(Console.ReadLine());
            int[,] matrix = new int[n, n];
            int digit = 1;
            // filling a)
            
            for (int col = 0; col < n; col++)
            {

                for (int row = 0; row < n; row++)
                {
                    matrix[col, row] = digit;
                    digit++;

                }
            }
            // printing a)
            Console.WriteLine("a)");
            Printing(n, matrix);
            Console.WriteLine();

            // filling b)
            digit = 1;

            for (int col = 0; col < n; col++)
            {
                if (col % 2 == 0)
                    for (int row = 0; row < n; row++)
                    {

                        matrix[col, row] = digit;
                        digit++;
                    }
                else
                {
                    for (int row = n - 1; row >= 0; row--)
                    {

                        matrix[col, row] = digit;
                        digit++;
                    }
                }

            }
            // printing b)
            Console.WriteLine("b)");
            Printing(n, matrix);
            Console.WriteLine();
            // filling c)
            digit = 1;
            int r = n - 1;
            int c = 0;

            for (int i = 0; i < n * n; i++)
            {
                matrix[c, r] = digit;
                r++;
                c++;
                digit++;

                if (r == n || c == n)
                {
                    r--;
                    if (c == n)
                    {
                        r--;
                        c--;
                    }
                    while (r - 1 >= 0 && c - 1 >= 0)
                    {
                        r--;
                        c--;
                    }
                }
            }
        // printing c)
            Console.WriteLine("c)");
            Printing(n, matrix);
            Console.WriteLine();
        }
        // printing method
        static void Printing(int n, int[,] matrix)
        {
            for (int col = 0; col < n; col++)
            {
                for (int row = 0; row < n; row++)
                {
                    Console.Write("{0, 4} ", matrix[row, col]);
                }
                Console.WriteLine();
            }
        }


    }
}


