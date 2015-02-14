using System;

namespace _03.VariableInHexadecimalFormat
{
    class VariableInHexdecimal
    {
        static void Main(string[] args)
        {
            //Declare an integer variable and assign it with the value 254 in hexadecimal format (0x##).
            //Use Windows Calculator to find its hexadecimal representation.
            //Print the variable and ensure that the result is 254.
          
            int value = 0xFE ;
            Console.WriteLine(value);
            Console.WriteLine("Is the result correct?");
            Console.WriteLine((value == 254) ? true : false);

        }
    }
}
