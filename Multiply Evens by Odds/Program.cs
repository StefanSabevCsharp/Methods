using System;

namespace Multiply_Evens_by_Odds
{
    class Program
    {
        static void Main(string[] args)
        {
            int number =Math.Abs( int.Parse(Console.ReadLine()));
            int sumOFevenDigits = GetsumofEvenDigits(number);
            int sumOfOddDigits = GetSumofOddDigits(number);
            Console.WriteLine(Math.Abs(sumOFevenDigits) * Math.Abs(sumOfOddDigits));
        }

        private static int GetSumofOddDigits(int number)
        {
            int oddSum = 0;
            while (number > 0)
            {
                int currentNumber = number % 10;
                if (currentNumber % 2 == 1)
                {
                    oddSum += currentNumber;
                }
                number = number / 10;

            }
            return oddSum;

            
        }
        static int GetsumofEvenDigits(int number)
        {
            int evenSum = 0;
            while (number > 0)
            {
                int currentNumber = number % 10;
                if (currentNumber % 2 == 0)
                {
                    evenSum += currentNumber;
                }
                number = number / 10;

            }

            return evenSum;
        }
    }
}
