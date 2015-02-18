//Write a method that asks the user for his name and prints “Hello, <name>”
//Write a program to test this method.

using System;

namespace _01.SayHello
{
    class SayHello
    {
        static void PrintHello()
        {
            Console.WriteLine("Enter your name");
            string name = Console.ReadLine();
            Console.WriteLine("Hello, {0}!", name);
        }

        static void Main()
        {
            PrintHello();
        }
    }
}
