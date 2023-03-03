using System;
using System.Collections.Generic;

namespace Heist
{
    class Program
    {
        static void Main(string[] args)
        {

            List<Member> HeistCrew = new List<Member>();

            Console.WriteLine("Plan your Heist!");

            another:
            Console.WriteLine("Enter your team member's name.");
            string name = Console.ReadLine();
            Console.WriteLine($"Enter {name}'s skill level, 1-10");
            int skillLevel = int.Parse(Console.ReadLine());
            Console.WriteLine($"Enter {name}'s courage level, 1-10");
            double courage = double.Parse(Console.ReadLine());
            Console.WriteLine($"{name}'s skill level is {skillLevel} with a courage level of {courage}");

            Member member = new Member(name, skillLevel, courage);
            HeistCrew.Add(member);

            Console.WriteLine("Do you need add another member? (yes/no)");
            string answer = Console.ReadLine().ToLower();
            if (answer == "yes")
            {
                goto another;
            }
            else 
            {
                Console.WriteLine("---------------");
                Console.Clear();
                Console.WriteLine($"You have {HeistCrew.Count} team Members.");
            }
            foreach (var crewMem in HeistCrew)
            {
                Console.WriteLine(@$"
Name: {crewMem.Name},
Skill Level: {crewMem.SkillLevel},
Courage Factor: {crewMem.Courage}");
                Console.WriteLine("-------------");
            }
            int BankSecurity = 100;
            int CrewSkill = 0;
            foreach (var crewMem in HeistCrew)
            {
                CrewSkill += crewMem.SkillLevel;
            }
            if (CrewSkill > BankSecurity)
            {
                Console.WriteLine("The Heist was a success! You made a clean getaway.");
            }
            else{
                Console.WriteLine($"{HeistCrew[0].name} tripped the alarm! You were all arrested.")
            }
        }
    }
}
