using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_3_3
{
    internal class Program
    {
        enum Points
        {
            A, B, C, D, E
        }
        static void Main(string[] args)
        {           
            int numberOfSides;
            int[,] coordinates = new int[5,2];
            int x, y;

            Console.WriteLine("Enter the number of sides:");
            numberOfSides = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the coordinates of point:");
            for (int i = 0; i < numberOfSides; i++)
            {
                Console.WriteLine($"Side {(Points)(i)}:");
                Console.Write("x = ");
                x = Convert.ToInt32(Console.ReadLine());                
                Console.Write("y = ");
                y = Convert.ToInt32(Console.ReadLine());
                coordinates[i, 0] = x;
                coordinates[i, 1] = y;
            }
            switch (numberOfSides)
            {
                case 3:
                    {
                        Point pointA = new Point(coordinates[0, 0], coordinates[0, 1]);
                        Point pointB = new Point(coordinates[1, 0], coordinates[1, 1]);
                        Point pointC = new Point(coordinates[2, 0], coordinates[2, 1]);
                        Figure figure = new Figure(pointA, pointB, pointC);
                        Console.WriteLine(figure.Name);
                        figure.PerimeterCalculator(numberOfSides);
                        break;
                    }
                case 4:
                    {
                        Point pointA = new Point(coordinates[0, 0], coordinates[0, 1]);
                        Point pointB = new Point(coordinates[1, 0], coordinates[1, 1]);
                        Point pointC = new Point(coordinates[2, 0], coordinates[2, 1]);
                        Point pointD = new Point(coordinates[3, 0], coordinates[3, 1]);
                        Figure figure = new Figure(pointA, pointB, pointC, pointD);
                        Console.WriteLine(figure.Name);
                        figure.PerimeterCalculator(numberOfSides);
                        break;
                    }
                case 5:
                    {
                        Point pointA = new Point(coordinates[0, 0], coordinates[0, 1]);
                        Point pointB = new Point(coordinates[1, 0], coordinates[1, 1]);
                        Point pointC = new Point(coordinates[2, 0], coordinates[2, 1]);
                        Point pointD = new Point(coordinates[3, 0], coordinates[3, 1]);
                        Point pointE = new Point(coordinates[4, 0], coordinates[4, 1]);
                        Figure figure = new Figure(pointA, pointB, pointC, pointD, pointE);
                        Console.WriteLine(figure.Name);
                        figure.PerimeterCalculator(numberOfSides);
                        break;
                    }
                default:
                    {
                        Console.WriteLine("Incorrect number of sides entered. Can be from 3 to 5 sides.");
                        break;
                    }
            }
        }
    }
}
