using System;

namespace GreetingApp
{
    #pragma warning disable CS8600
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome!");
            Console.Write("Please enter your name: ");

            string name = Console.ReadLine();

            Console.Write($"Hello, {name}! Please enter your age: ");
            int age;
            while (!int.TryParse(Console.ReadLine(), out age) || age < 0)
            {
                Console.Write("Invalid input. Please enter a valid age: ");
            }

            Console.WriteLine($"Hello, {name}! You are {age} years old.");

            if (age < 18)
            {
                Console.WriteLine("You are under 18 years old!");
            }
            else if (age >= 18 && age < 65)
            {
                Console.WriteLine("You are an adult!");
            }
            else
            {
                Console.WriteLine("You are a senior citizen!");
            }
        }
    }
}
