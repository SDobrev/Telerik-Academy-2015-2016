//Write a program that can solve these tasks:
//Reverses the digits of a number
//Calculates the average of a sequence of integers
//Solves a linear equation a * x + b = 0
//Create appropriate methods.
//Provide a simple text-based menu for the user to choose which task to solve.
//Validate the input data:
//The decimal number should be non-negative
//The sequence should not be empty
//a should not be equal to 0
using System;

namespace _13.SolveTasks
{
    class SolveTasks
    {

        static void Main()
        {
            Console.WriteLine("Which operation would to execute:");
            Console.WriteLine("Enter 1 to reverse the digits of a decimal number");
            Console.WriteLine("Enter 2 to calculate the average of a sequence of integers");
            Console.WriteLine("Enter 3 to solve a linear equation a*x + b = 0");
            int operation = int.Parse(Console.ReadLine());
            if (operation == 1)
            {
                Console.WriteLine("Enter decimal number");
                decimal num = decimal.Parse(Console.ReadLine());
                if (num < 0)
                {
                    Console.WriteLine("The decimal number should be non-negative");
                    return;
                }
                Console.WriteLine(ReverseNumber(num));
            }
            else if (operation == 2)
            {
                SequenceInput();
            }
            else if (operation == 3)
            {
                EquationInput();
              
            }
            else
            {
                Console.WriteLine("Plase enter 1, 2 or 3");
            }
        }
        static decimal ReverseNumber(decimal number)
        {

            char[] charArray = number.ToString().ToCharArray();
            Array.Reverse(charArray);
            decimal result = decimal.Parse(new string(charArray));
            return result;
        }
        static void SequenceInput()
        {
            Console.WriteLine("Enter the length of the sequence");
            int length = int.Parse(Console.ReadLine());
            if (length <= 0)
            {
                Console.WriteLine("The sequence should not be empty");
                return;
            }
            double[] arr = new double[length];
            for (int i = 0; i < length; i++)
            {

                Console.WriteLine("Enter {0} element of the array", i);
                arr[i] = double.Parse(Console.ReadLine());

            }
            Console.WriteLine(AverageOfSequence(arr));
        }
        static double AverageOfSequence(double[] sequence)
        {
            double sum = 0;
            for (int i = 0; i < sequence.Length; i++)
            {
                sum += sequence[i];
            }
            return sum / sequence.Length;
        }
        static void EquationInput()
        {
            Console.WriteLine("Enter a");
            int a = int.Parse(Console.ReadLine());
            if (a == 0)
            {
                Console.WriteLine("a should not be equal to 0");
                return;
            }
            Console.WriteLine("Enter b");
            int b = int.Parse(Console.ReadLine());
            Console.WriteLine(CalcEquation(a, b));
        }
        static double CalcEquation(int a, int b)
        {
            return (double)-b / a;
        }

    }
}

