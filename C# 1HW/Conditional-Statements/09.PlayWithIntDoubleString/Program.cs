//Write a program that, depending on the user’s choice, inputs an int, double or string variable.
//If the variable is int or double, the program increases it by one.
//If the variable is a string, the program appends * at the end.
//Print the result at the console. Use switch statement.

using System;
 
 
namespace _09.PlayWithIntDoubleString
{
    class PlayWithIntDoubleString
    {
        static void Main()
        {
            Console.WriteLine("Please choose a type: \n 1 --> int \n 2 --> double \n 3 --> string");
            int type = int.Parse(Console.ReadLine());
            if (type == 1)
            {
                int num = int.Parse(Console.ReadLine());
                Console.WriteLine(num + 1);
            }
            else if (type == 2)
            {
                double num = double.Parse(Console.ReadLine());
                Console.WriteLine(num + 1);
            }
            else if (type == 3)
            {
                Console.WriteLine("Please enter a string: ");
                string str = Console.ReadLine();
                Console.WriteLine(str + '*' );
            }
            else
            {
                Console.WriteLine("Please choose between 1 to 3");
            }
        }
    }
}
