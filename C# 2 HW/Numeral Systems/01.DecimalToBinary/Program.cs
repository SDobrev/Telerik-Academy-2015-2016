//Write a program to convert decimal numbers to their binary representation.
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


class DecimalToBinary
{
    static void Main(string[] args)
    {

        Console.Write("Enter a Number : ");
        int num = int.Parse(Console.ReadLine());
        string binaryString = Convert.ToString(num, 2);
        Console.WriteLine("{0} in binary format is {1}", num, binaryString);
    }
}

