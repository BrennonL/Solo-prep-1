// See https://aka.ms/new-console-template for more information

using System;

namespace game

{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("What is your first name?");
            string first = Console.ReadLine();

            Console.WriteLine("What is your last name?");
            string last = Console.ReadLine();

            Console.Write($"Your name is {last}, {first} {last}.");
        }
    }
}


