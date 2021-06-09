using System;

namespace Patterns_and_Best_Practices_ProdC
{
    class Program
    {
        public static void PrintStringInfo(string s)
        {
            if (string.IsNullOrEmpty(s))
            {
                Console.WriteLine($"'{s}' is null or empty");
            }

            if (string.IsNullOrWhiteSpace(s))
            {
                Console.WriteLine($"'{s}' is null or whitespace");
            }

            Console.WriteLine();
        }

        static void Main(string[] args)
        {
            PrintStringInfo(null);
            PrintStringInfo("");
            PrintStringInfo("   ");
            PrintStringInfo("Andrea");
        }
    }
}
