using System;

namespace Patterns_and_Best_Practices_ProdC
{
    class Program
    {
        public static string Who(bool hasConsent, string name, int? age)
        {
            if (!hasConsent)
            {
                return "No consent was given";
            }

            if (string.IsNullOrEmpty(name))
            {
                return age.HasValue ? $"A {age} years old person" : "Unknown";
            }

            return age.HasValue ? $"{name} ({age} years old)" : name;
        }

        static void Main(string[] args)
        {
            Console.WriteLine(Who(true, "Andrea", 33));
            Console.WriteLine(Who(true, "Andrea", null));
            Console.WriteLine(Who(true, null, 33));
            Console.WriteLine(Who(true, null, null));
            Console.WriteLine(Who(false, null, null));
        }
    }
    }
}
