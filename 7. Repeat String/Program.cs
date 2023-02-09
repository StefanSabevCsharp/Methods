using System;

namespace _7._Repeat_String
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            int repeatTimes = int.Parse(Console.ReadLine());
            string result = RepeatString(input, repeatTimes);
            Console.WriteLine(result);
            
        }

        private static string RepeatString(string input, int repeatTimes)
        {
            string result = "";
            for (int i = 1; i <=repeatTimes ; i++)
            {
                result += input;
            }
            return result;
        }
    }
}
