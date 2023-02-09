using System;

namespace _05._Orders
{
    class Program
    {
        static void Main(string[] args)
        {
            string productName = Console.ReadLine();
            int quantity = int.Parse(Console.ReadLine());

            Calculate( productName,quantity);
            
        }

        static void Calculate(string productName,int quantity)
        {
            double coffeePrice = 1.5;
            double waterPrice = 1.0;
            double cokePrice = 1.40;
            double snacksPrice = 2.00;
            double result = 0;
            switch (productName)
            {
                case "coffee":
                    result = quantity * coffeePrice;
                    break;
                case "water":
                    result = quantity * waterPrice;
                    break;
                case "snacks":
                    result = quantity * snacksPrice;
                    break;
                case "coke":
                    result = quantity * cokePrice;
                    break;

                default:
                    break;
            }
            Console.WriteLine($"{result:f2}");

        }
    }
}
