//Write a program to convert hexadecimal numbers to their decimal representation.
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


class HexadecimalToDecimal
{
    static void Main()
    {
        Console.WriteLine("Enter number in hexadecimal format");
        string hexValue = Console.ReadLine();
        int decValue = Convert.ToInt32(hexValue, 16);
        Console.WriteLine(decValue);
    }
}
