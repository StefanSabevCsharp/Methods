using System;

namespace _03._Calculations
{
    class Program
    {
        static void Main(string[] args)
        {
            string command = Console.ReadLine();
            double numA = double.Parse(Console.ReadLine());
            double numB = double.Parse(Console.ReadLine());

            switch (command)
            {
                case "add":
                    Addmethod(numA, numB);
                    break;
                case "multiply":
                    Multiplymethod(numA, numB);
                    break;
                case "substract":
                    Substractmethod(numA, numB);
                    break;
                case "divide":
                    Dividemethod(numA, numB);
                    break;
                default:
                    break;
            }
        }

        private static void Dividemethod(double numA, double numB)
        {
            Console.WriteLine(numA/numB);
        }

        private static void Substractmethod(double numA, double numB)
        {
            Console.WriteLine(numA-numB);
        }

        private static void Multiplymethod(double numA, double numB)
        {
            Console.WriteLine(numA*numB);
        }

        private static void Addmethod(double numA, double numB)
        {
            Console.WriteLine(numA + numB);
        }
    }
}
