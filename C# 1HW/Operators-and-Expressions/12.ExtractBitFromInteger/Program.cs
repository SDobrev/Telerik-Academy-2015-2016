using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _12.ExtractBitFromInteger
{
    class ExtractBitFromInteger
    {
        static void Main(string[] args)
        {
            //Write an expression that extracts from given integer n the value of given bit at index p.
            Console.WriteLine("Enter integer:");
            int n = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter index p:");
            int p = int.Parse(Console.ReadLine());
            byte bitAtPositionP = (byte)((n >> p) & 1);
            Console.WriteLine("bit at position {0} is {1} ", p, bitAtPositionP);

   
        }
    }
}
