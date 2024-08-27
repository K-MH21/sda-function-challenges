using System;
using System.Security.Cryptography;

namespace FunctionChallenges
{
    class Program
    {
        static void Main(string[] args)
        {
            int challenge = 2; // Edit this to access the challenges
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
                    GuessingGame();
                    break;
                case 3:
                    break;
                case 4:
                    break;
            }
        }

        private static void GuessingGame()
        {
            int number = new Random().Next(9) + 1; // 1 to 10
            Console.WriteLine("Guess a number between 1 and 10");
            while (true)
            {
                int guess = Convert.ToInt16(Console.ReadLine());
                if (1 > guess | guess > 10)
                {
                    Console.WriteLine("Wrong input");
                    continue;
                }
                switch (guess.CompareTo(number))
                {
                    case -1:
                        Console.WriteLine("Your guess is smaller; guess a larger number");
                        break;
                    case 0:
                        Console.WriteLine("You guessed the number correctely!");
                        return;
                    case 1:
                        Console.WriteLine("Your guess is larger; guess a smaller number");
                        break;
                }
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
