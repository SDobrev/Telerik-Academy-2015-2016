using System;


namespace _09.PrintASequence
{
    class Program
    {
        static void Main()
        {

        int printNumber;
        for (int i = 2; i <= 11; i++)
        {
            if (i % 2 == 0)
            {
                printNumber = i;
            }
            else
            {
                printNumber = i * (-1);
            }
            Console.WriteLine(printNumber);
        }
        }
    }
}
