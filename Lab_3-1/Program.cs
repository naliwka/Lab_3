using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_3_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double side1, side2;
            Console.WriteLine("Enter the first side:");
            side1 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Enter the second side:");
            side2 = Convert.ToDouble(Console.ReadLine());

            Rectangle rectangle = new Rectangle(side1, side2);
            double area = rectangle.Area;
            double perimeter = rectangle.Perimeter;
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine($"Area = {area}\nPerimeter = {perimeter}");
            Console.ForegroundColor = ConsoleColor.White;
        }
    }
}
