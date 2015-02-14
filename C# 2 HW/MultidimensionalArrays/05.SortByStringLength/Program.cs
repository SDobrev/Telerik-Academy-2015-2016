//You are given an array of strings. 
//Write a method that sorts the array by the length of its elements (the number of characters composing them).

using System;

namespace _05.SortByStringLength
{
    class SortByStringLength
    {
        static void Main()
        {
            string[] carMakes = {"Opel", "Volkswagen", "Mercedes", "Ferrari",
                                  "BMW", "Renault", "Alfa Romeo"};

            Array.Sort(carMakes, (x, y) => x.Length.CompareTo(y.Length));

            foreach (var carMake in carMakes)
            {
                Console.WriteLine(carMake);
            }

        }
    }
}
