using System;

namespace Example
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
            Console.WriteLine("Hello, VTC");

            Console.WriteLine("Your name:");
            string? name = Console.ReadLine();
            Console.WriteLine("Hi " + name + ", welcome to VTC");

            GreetUser(name);
        }

        static void GreetUser(string? name)
        {
            Console.WriteLine($"Hi, {name}!");
        }
    }
}

