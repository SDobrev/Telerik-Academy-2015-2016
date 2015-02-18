//Write a program to convert hexadecimal numbers to binary numbers (directly).
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


class HexadecimalToBinary
{
    static void Main(string[] args)
    {
        Console.WriteLine("Enter number in hexadecimal format");
        string hexString = Console.ReadLine();
        string binaryString = Convert.ToString(Convert.ToInt32(hexString, 16), 2);
        Console.WriteLine("{0} in binary format is {1}", hexString, binaryString);
    }
}

