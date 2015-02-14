using System;


namespace _09.PrintASequence
{
    class Program
    {
        static void Main()
        {

            int PrintNumber;
            for (int i = 2; i <= 1001; i++)
            {
                if (i % 2 == 0)
                {
                    PrintNumber = i;
                }
                else
                {
                    PrintNumber = i * (-1);
                }
                Console.Write(PrintNumber+", ");
            }
        }
    }
}
