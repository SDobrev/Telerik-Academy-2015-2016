//Write a program to convert binary numbers to their decimal representation.
using System;
using System.Linq;



class BinaryToDecimal
{
    static void Main()
    {
        Console.Write("Enter a binary number : ");
        string binaryNum = Console.ReadLine();
        int decimalNum = Convert.ToInt32(binaryNum, 2);
        Console.WriteLine("{0} in decimal format is {1}", binaryNum, decimalNum);
    }
}

