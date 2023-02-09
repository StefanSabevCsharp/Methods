using System;

namespace _8._Math_Power
{
    class Program
    {
        static void Main(string[] args)
        {
            int baseNumber = int.Parse(Console.ReadLine());
            int powerNumber = int.Parse(Console.ReadLine());
            double result = Powermethod(baseNumber, powerNumber);
            Console.WriteLine(result);
        }
        private static double Powermethod(int baseNumber, int powerNumber)
        {
            double result = Math.Pow(baseNumber, powerNumber);
            return result;
           

        }
    }
}
