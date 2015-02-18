//Write a program to convert from any numeral system of given base s to any other numeral system of base d (2 ≤ s, d ≤ 16).
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


class OneSystemToOther
{
    static void Main()
    {
        while (true)
        {
            Console.Write("Enter number base S (2 <= S, D <= 16): ");
            int baseS = int.Parse(Console.ReadLine());
            Console.Write("Convert to base D (2 <= S, D <= 16): ");
            int baseD = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter number with base {0} to convert to base {1}", baseS, baseD);
            string num = Console.ReadLine();

            if (baseS == baseD)
            {
                Console.WriteLine(num);
            }
            else if (baseS == 10 && baseD == 2)
            {
                DecimalToBin(num);
            }
            else if (baseS == 10 && baseD == 16)
            {
                DecimalToHexadecimal(num);
            }
            else if (baseS == 2 && baseD == 10)
            {
                BinaryToDecimal(num);
            }
            else if (baseS == 2 && baseD == 16)
            {
                BinaryToHexadecimal(num);
            }
            else if (baseS == 16 && baseD == 2)
            {
                HexadecimalToBinary(num);
            }
            else if (baseS == 16 && baseD == 10)
            {
                HexadecimalToDecimal(num);
            }
            else
            {
                Console.WriteLine("Enter correct number for base S and base D");
            }
        }


    }
    static void DecimalToBin(string number)
    {

        int decimalNum = Convert.ToInt32(number);
        string binaryString = Convert.ToString(decimalNum, 2);
        Console.WriteLine("{0} in binary format is {1}", decimalNum, binaryString);
    }
    static void DecimalToHexadecimal(string number)
    {

        int decimalNum = Convert.ToInt32(number);
        string hexadecimalString = Convert.ToString(decimalNum, 16);
        Console.WriteLine("{0} in hexadecimal format is {1}", decimalNum, hexadecimalString);
    }
    static void BinaryToDecimal(string number)
    {
        int decimalNum = Convert.ToInt32(number, 2);
        Console.WriteLine("{0} in decimal format is {1}", number, decimalNum);
    }
    static void BinaryToHexadecimal(string number)
    {
        string hexString = Convert.ToString(Convert.ToInt32(number, 2), 16);
        Console.WriteLine("{0} in hexadecimal is {1}", number, hexString);
    }
    static void HexadecimalToBinary(string number)
    {
        string binaryString = Convert.ToString(Convert.ToInt32(number, 16), 2);
        Console.WriteLine("{0} in binary format is {1}", number, binaryString);
    }
    static void HexadecimalToDecimal(string number)
    {
        int decimalNum = Convert.ToInt32(number, 16);
        Console.WriteLine("{0} in decimal format is {1}", number, decimalNum);
    }


}

