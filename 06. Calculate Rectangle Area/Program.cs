using System;

namespace _06._Calculate_Rectangle_Area
{
    class Program
    {
        static void Main(string[] args)
        {
            double widht = double.Parse(Console.ReadLine());
            double height = double.Parse(Console.ReadLine());
            double area = CalculateRectangleArea(widht, height);

            Console.WriteLine(area);
            

        }

        private static double CalculateRectangleArea(double w,double h)
        {
            double result = w * h;
            return result;
        }
    }
}
