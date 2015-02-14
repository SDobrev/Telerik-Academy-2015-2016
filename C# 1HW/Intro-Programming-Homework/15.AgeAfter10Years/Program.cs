using System;


namespace _15.AgeAfter10Years
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Enter your birthday dd/MM/YYYY:");
            var bday = DateTime.ParseExact(Console.ReadLine(), "dd/MM/yyyy", System.Globalization.CultureInfo.InvariantCulture);
            int age = DateTime.Today.Year - bday.Year;
            if (bday > DateTime.Today.AddYears(-age)) age--;
            Console.WriteLine("You are now {0} years old, you will be {1} years old in 10 years.", age, age + 10);
            
        }
    }
}
