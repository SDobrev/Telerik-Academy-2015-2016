using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _13.CheckBitAtGivenPosition
{
    class CheckBitAtGivenPosition
    {
        static void Main(string[] args)
        {
            //Write a Boolean expression that returns if the bit at position p (counting from 0, starting from the right) in given integer number n, has value of 1.
            Console.WriteLine("Enter integer:");
            int n = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter index p:");
            int p = int.Parse(Console.ReadLine());
            bool bitAtPosition = (byte)((n >> p) & 1) == 1;
            Console.WriteLine("Is bit at position {0} = 1 ? ------ {1}", p, bitAtPosition);
        }
    }
}
