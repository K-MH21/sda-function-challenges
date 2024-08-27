using System;

namespace FunctionChallenges
{
    class Program
    {
        static void Main(string[] args)
        {
            int challenge = 1; // Edit this to access the challenges
            switch (challenge)
            {
                case 1:
                    Console.WriteLine(StringNumberProcessor("Hello", 100, 200, "World"));
                    Console.WriteLine(StringNumberProcessor("Apple", "Banana", 50, 150, "Cherry"));
                    Console.WriteLine(StringNumberProcessor(10, 20, 30));
                    Console.WriteLine(StringNumberProcessor(500, "Mixed", 1000, "Types", 300));
                    Console.WriteLine(StringNumberProcessor("Single", 1));
                    Console.WriteLine(StringNumberProcessor("Only", "Strings", "Here"));
                    break;
                case 2:
                    break;
                case 3:
                    break;
                case 4:
                    break;
            }
        }

        private static string StringNumberProcessor(params object[] args)
        {
            string words = "";
            double numbers = 0;
            for (int i = 0; i < args.Length; i++)
            {
                if (args[i] is string)
                    words += " " + args[i];
                else
                    numbers += Convert.ToDouble(args[i]);
            }
            return $"{words};{numbers}";
        }
    }
}
