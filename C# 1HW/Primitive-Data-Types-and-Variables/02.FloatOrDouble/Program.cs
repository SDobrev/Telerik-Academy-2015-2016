using System;


namespace _02.FloatOrDouble
{
    class FloatOrDouble
    {
        static void Main()
        {
            // Which of the following values can be assigned to a variable of type float 
            //and which to a variable of type double: 34.567839023, 12.345, 8923.1234857, 3456.091?
            //Write a program to assign the numbers in variables and print them to ensure no precision is lost.
            double firstN = 34.567839023;
            float secondN = 12.345f;
            double thirdN = 8923.1234857;
            float fourthN = 3456.091f;
            Console.WriteLine("{0}\n{1}\n{2}\n{3}", firstN, secondN, thirdN, fourthN);
        }

    }
}
