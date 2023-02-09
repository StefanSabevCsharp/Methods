using System;

namespace Methods
{
    class Program
    {
        static void Main(string[] args)
        {
            int num = int.Parse(Console.ReadLine());
            Checkifpossitive(num);
        }

        private static void Checkifpossitive(int num)
        {
            if (num > 0)
            {
                Console.WriteLine($"The number {num} is positive.");
            }
            else if (num < 0)
            {
                Console.WriteLine($"The number {num} is negative.");
            }
            else if (num == 0)
            {
                Console.WriteLine($"The number {num} is zero.");
            }
        }
    }
}
