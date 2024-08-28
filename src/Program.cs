using System;
using System.Runtime.ConstrainedExecution;
using System.Security.Cryptography;

namespace FunctionChallenges
{
    class Program
    {
        static void Main(string[] args)
        {
            // int challenge = 4; // Edit this to access the challenges
            for (int challenge = 1; challenge <= 4; challenge++)
            {
                Console.WriteLine($"======== Challenege {challenge} ========");
                switch (challenge)
                {
                    case 1:
                        Console.WriteLine(StringNumberProcessor("Hello", 100, 200, "World"));
                        Console.WriteLine(
                            StringNumberProcessor("Apple", "Banana", 50, 150, "Cherry")
                        );
                        Console.WriteLine(StringNumberProcessor(10, 20, 30));
                        Console.WriteLine(StringNumberProcessor(500, "Mixed", 1000, "Types", 300));
                        Console.WriteLine(StringNumberProcessor("Single", 1));
                        Console.WriteLine(StringNumberProcessor("Only", "Strings", "Here"));
                        break;
                    case 2:
                        GuessingGame();
                        break;
                    case 3:
                        Console.WriteLine(ReverseWords("This is the original sentence!")); // Expected Outcome: "sihT si eht lanigiro !ecnetnes"
                        Console.WriteLine(ReverseWords("Hello World")); // Expected Outcome: "olleH dlroW"
                        Console.WriteLine(ReverseWords("Apple Banana Cherry")); // Expected Outcome: "elppA ananaB yrrehC"
                        Console.WriteLine(ReverseWords("Programming is fun")); // Expected Outcome: "gnimmargorP si nuf"
                        Console.WriteLine(ReverseWords("Keep it simple")); // Expected Outcome: "peeK ti elpmis"
                        Console.WriteLine(ReverseWords("SingleWord")); // Expected Outcome: "droWelgniS"

                        break;
                    case 4:
                        UpdateProfile();
                        break;
                }
            }
        }

        private static void UpdateProfile()
        {
            string name = "John Doe",
                email = "john@gmail.com";
            int age = 28;
            Console.WriteLine("Initial Profile:");
            Console.WriteLine($"Name: {name}");
            Console.WriteLine($"Age: {age}");
            Console.WriteLine($"Email: {email}");
            UpdateProfileHelper(ref name, ref age, ref email);
            Console.WriteLine("updated Profile:");
            Console.WriteLine($"Name: {name}");
            Console.WriteLine($"Age: {age}");
            Console.WriteLine($"Email: {email}");
        }

        private static void UpdateProfileHelper(ref string name, ref int age, ref string email)
        {
            Console.Write("\nEnter your new name: ");
            name = Console.ReadLine();
            Console.WriteLine($"Name updated to: {name}");

            Console.Write("Enter your new age: ");
            age = Convert.ToInt16(Console.ReadLine());
            Console.WriteLine($"Age updated to: {age}");

            Console.Write("Enter your new email: ");
            email = Console.ReadLine();
            Console.WriteLine($"email updated to: {email}\n");
        }

        private static string ReverseWords(string str)
        {
            string[] words = str.Split(" ");
            string reversedWords = "";
            for (int i = 0; i < words.Length; i++)
            {
                for (int j = words[i].Length - 1; j >= 0; j--)
                {
                    reversedWords += words[i][j];
                }
                reversedWords += " ";
            }
            return reversedWords;
        }

        private static void GuessingGame()
        {
            int number = new Random().Next(10) + 1; // 1 to 10
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
