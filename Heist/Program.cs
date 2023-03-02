using System;

namespace Heist
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Plan your Heist!");
            Console.WriteLine("Enter your team member's name.");
            string name = Console.ReadLine();
            Console.WriteLine($"Enter {name}'s skill level, 1-10");
            int skillLevel = int.Parse(Console.ReadLine());
            Console.WriteLine($"Enter {name}'s courage level, 1-10");
            double courage = double.Parse(Console.ReadLine());
            Console.WriteLine($"{name}'s skill level is {skillLevel} with a courage level of {courage}");
        }
    }
}
