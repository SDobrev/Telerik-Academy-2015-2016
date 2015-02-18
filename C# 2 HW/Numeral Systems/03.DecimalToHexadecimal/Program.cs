//Write a program to convert decimal numbers to their hexadecimal representation.
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


class DecimalToHexadecimal
{
    static void Main()
    {
        Console.WriteLine("Enter decimal number");
        int decValue = int.Parse(Console.ReadLine());
        string hexValue = decValue.ToString("X");
        Console.WriteLine("{0} in hexadecimal format is {1}", decValue, hexValue);
    }
}

