using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_3_3
{
    internal class Figure
    {
        public Point a, b, c, d, e;
        private string figureName;
        public string Name 
        { 
            get 
            {
                return figureName;
            } 
        }
        public Figure (Point a, Point b, Point c)
        {
            this.a = a;
            this.b = b;
            this.c = c;
            this.figureName = "triangle";
        }
        public Figure(Point a, Point b, Point c, Point d)
        {
            this.a = a;
            this.b = b;
            this.c = c;
            this.d = d;
            this.figureName = "rectangle";
        }
        public Figure(Point a, Point b, Point c, Point d, Point e)
        {
            this.a = a;
            this.b = b;
            this.c = c;
            this.d = d;
            this.e = e;
            this.figureName = "pentagon";
        }
        public double LengthSide (Point a, Point b)
        {
            return Math.Sqrt(Math.Pow(Math.Abs(a.X - b.X), 2) + Math.Pow(Math.Abs(a.Y - b.Y), 2));
        }
        public void PerimeterCalculator(int numbersOfSides)
        {
            double perimeter;
            switch (numbersOfSides)
            {
                case 3:
                    {
                        perimeter = LengthSide(this.a, this.b) +
                            LengthSide(this.b, this.c) +
                            LengthSide(this.c, this.a);
                        Console.WriteLine($"Perimeter = {perimeter}");
                        break;
                    }
                case 4:
                    {
                        perimeter = LengthSide(this.a, this.b) +
                            LengthSide(this.b, this.c) +
                            LengthSide(this.c, this.d) +
                            LengthSide(this.d, this.a);
                        Console.WriteLine($"Perimeter = {perimeter}");
                        break;
                    }
                case 5:
                    {
                        perimeter = LengthSide(this.a, this.b) +
                            LengthSide(this.b, this.c) +
                            LengthSide(this.c, this.d) +
                            LengthSide(this.d, this.e) +
                            LengthSide(this.e, this.a);
                        Console.WriteLine($"Perimeter = {perimeter}");
                        break;
                    }
            }           
        }
    }
}
