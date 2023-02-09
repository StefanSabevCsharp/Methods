using System;

namespace _9._Greater_of_Two_Values
{
    class Program
    {
        static void Main(string[] args)
        {
            //string s1 = "hello";
            //string s2 = "hello";
            //string s3 = "csharp";
            //string s4 = "mello";

            //Console.WriteLine(string.Compare(s1, s2));
            //Console.WriteLine(string.Compare(s2, s3));
            //Console.WriteLine(string.Compare(s3, s4));

            string input = Console.ReadLine();

            switch (input)
            {
                case "int":
                    int a = int.Parse(Console.ReadLine());
                    int b = int.Parse(Console.ReadLine());
                    int max = GetType(a, b);
                    Console.WriteLine(max);
                    break;
                case "char":
                    char charA = char.Parse(Console.ReadLine());
                    char charB = char.Parse(Console.ReadLine());
                    char maxValue = (char)GetTypeChar(charA, charB);
                    Console.WriteLine(maxValue);
                    break;
                case "string":
                    string firstString = Console.ReadLine();
                    string secondString = Console.ReadLine();
                    string maxValueString = GetTypeString(firstString, secondString);
                    Console.WriteLine(maxValueString);
                    break;
                default:
                    break;
            }
            ;

        }

        private static int GetTypeChar(char charA, char charB)
        {
            if (charA > charB)
            {
                return charA;
            }
            return charB;
        }

        private static string GetTypeString(string firstString, string secondString)
        {
            int result = string.Compare(firstString, secondString);

            if (result > 0)

            {
                return firstString;
            }
            
                return secondString;
            
            
        }

        private static int GetType(int a, int b)
        {
            if (a > b)
            {
                return a;
            }
            else
            {
                return b;
            }


        }
       
    }
}
