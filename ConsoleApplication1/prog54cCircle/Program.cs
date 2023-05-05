using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace prog54cCircle
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter Radius: ");
            int rad = int.Parse(Console.ReadLine());
            double pi = 3.14;
            double area = pi * Math.Pow(rad, 2);
            double circum = 2 * pi * rad;
            Console.WriteLine("Area of the circle: " + area);
            Console.WriteLine("Circumference of the circle: " + circum);
            Console.ReadKey();
        }
    }
}
