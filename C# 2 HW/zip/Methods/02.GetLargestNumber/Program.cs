//Write a method GetMax() with two parameters that returns the larger of two integers.
//Write a program that reads 3 integers from the console and prints the largest of them using the method GetMax().
using System;


namespace _02.GetLargestNumber
{
    class GetLargestNumber
    {
        static void Main()
        {
            Console.WriteLine("Enter first integer a");
            int a = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter second integer b");
            int b = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter third integer c");
            int c = int.Parse(Console.ReadLine());
            
          
            Console.WriteLine("The bigger is: ");
            Console.WriteLine(GetMax(GetMax(a,b),c));

        }
        static int GetMax(int number1, int number2)
        {
        
            int max = number1;
            if (number2 > number1)
            {
                max = number2;
            }
           
            return max;
        }
    }
}
