using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _11.BitwiseExtractBitNo3
{
    class BitwiseExtract
    {
        static void Main(string[] args)
        {
            //Using bitwise operators, write an expression for finding the value of the bit #3 of a given unsigned integer.
            //The bits are counted from right to left, starting from bit #0.
            //The result of the expression should be either 1 or 0.
            Console.WriteLine("Enter unsigned integer:");
            uint n = uint.Parse(Console.ReadLine());
            byte bitAtPositionThree = (byte)((n >> 3) & 1);
            Console.WriteLine("bit at #3 is " + bitAtPositionThree);

        }
    }
}
