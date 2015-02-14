using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _12.NullValuesArithmetic
{
    class NullValuesArithmetic
    {
        static void Main(string[] args)
        {

           // Create a program that assigns null values to an integer and to a double variable.
           // Try to print these variables at the console.
           // Try to add some number or the null literal to these variables and print the result.

            int? xNull = null;
            double? yNull = null;
            Console.WriteLine("null:", xNull + Environment.NewLine + yNull);
            xNull += 8;
            yNull += 8;
            Console.WriteLine("null + 8:", xNull + Environment.NewLine + yNull);


        }
    }
}
