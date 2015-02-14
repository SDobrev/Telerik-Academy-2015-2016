//Write a program that reads two positive integer numbers and prints 
//how many numbers p exist between them such that the reminder of the division by 5 is 0.

using System;

class NumbersInIntervalDividableByGivenNumber
{
    static void Main()
    {
        Console.Write("Enter first positive integer number: ");
        int fNum = int.Parse(Console.ReadLine());

        Console.Write("Enter second positive integer number: ");
        int sNum = int.Parse(Console.ReadLine());

        if (fNum > sNum)
        {
            int temp = fNum;
            fNum = sNum;
            sNum = temp;
        }

        int count = 0;
        for (int i = fNum; i <= sNum; i++)
        {
            if (i % 5 == 0)
            {
                count++;
            }
        }

        Console.WriteLine("{0} numbers exist between the given numbers", count);
    }
}