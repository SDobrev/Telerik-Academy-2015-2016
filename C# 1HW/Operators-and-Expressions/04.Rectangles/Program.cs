using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04.Rectangles
{
    class Rectangles
    {
        static void Main(string[] args)
        {
            //Write an expression that calculates rectangle’s perimeter and area by given width and height.
            Console.WriteLine("Enter rectagnle width");
            double width = double.Parse(Console.ReadLine());
            Console.WriteLine("Enter rectangle height");
            double height = double.Parse(Console.ReadLine());
            double area = width * height;
            double perimeter = (2 * width) + (2 * height);
            Console.WriteLine("Rectangle area = {0} perimeter = {1}", area, perimeter);
           

        }
    }
}
