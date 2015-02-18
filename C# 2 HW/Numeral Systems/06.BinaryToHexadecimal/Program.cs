//Write a program to convert binary numbers to hexadecimal numbers (directly).
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


class BinaryToHexadecimal
{
    static void Main()
    {
        Console.WriteLine("Enter binary number");
        string binaryString = Console.ReadLine();
        string hexString = Convert.ToString(Convert.ToInt32(binaryString, 2), 16);
        Console.WriteLine("{0} in hexadecimal is {1}", binaryString, hexString);
     
    }
}

