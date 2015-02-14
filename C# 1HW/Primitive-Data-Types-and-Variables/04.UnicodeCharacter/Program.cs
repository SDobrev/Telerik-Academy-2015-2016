using System;


namespace _04.UnicodeCharacter
{
    class UnicodeCharacter
    {
        static void Main()
        {
            // Declare a character variable and assign it with the symbol that has Unicode code 42 (decimal) using the \u00XX syntax, and then print it.
            char uniChar = '\u002A';
            Console.WriteLine(uniChar);
        }
    }
}
