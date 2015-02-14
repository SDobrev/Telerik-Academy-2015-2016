using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _14.PrintTheASCII_Table
{
    class ASCIITable
    {
        static void Main(string[] args)
        {
            //Find online more information about ASCII (American Standard Code for Information Interchange)
            //and write a program that prints the entire ASCII table of characters on the console (characters from 0 to 255).

            for (int i = 0; i <= 255; i++)
            {
                System.Console.WriteLine("{0} = {1}", i, (char)i);
            }
        }
    }
}
