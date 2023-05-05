using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _54bconsole
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter Num1: ");
            int Num1 = int.Parse(Console.ReadLine());
            Console.Write("Enter Num2: ");
            int Num2 = int.Parse(Console.ReadLine());
            Console.Write("Enter Num3: ");
            int Num3 = int.Parse(Console.ReadLine());
            Console.Write("Enter Num4: ");
            int Num4 = int.Parse(Console.ReadLine());
            double total = Num1 + Num2 + Num3 + Num4;
            double average = total / 4;
            Console.WriteLine("Total: " + total.ToString());
            Console.WriteLine("Average: " + average.ToString());
            Console.ReadKey();
        }
    }
}
