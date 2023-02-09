using System;

namespace _11._Math_operations
{
    class Program
    {
        static void Main(string[] args)
        {
            int first = int.Parse(Console.ReadLine());
            int second = int.Parse(Console.ReadLine());
            int third = int.Parse(Console.ReadLine());
            CalculateMin(first, second, third);

        }
        static void CalculateMin(int first, int second, int third)
        {
            if (first <= second && first <= third)
            {
                Console.WriteLine(first);
            }
            else if (second <= first && second <= third)
            {
                Console.WriteLine(second);
            }
            else if (third <= first && third <= second)
            {
                Console.WriteLine(third);
            }
        }
    }
}
