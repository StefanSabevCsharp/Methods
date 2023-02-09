using System;

namespace _04._Printing_Triangle
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());

            for (int i = 1; i <= number; i++)
            {
                int currentNum = i;
                Printline(currentNum);
                Console.WriteLine();
            }

            for (int i = number -1; i >= 1; i--)
            {
                int currentNum = i;
                Printline(currentNum);
                Console.WriteLine();
            }
        }

        private static void Printline(int currentNum)
        {
            for (int j = 1; j <= currentNum; j++)
            {
                Console.Write(j + " ");
            }
        }
    }
}
