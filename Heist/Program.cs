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

            Console.WriteLine(@"What is the bank's difficulty level? (1, 2, or 3)
1: Easy
2: Medium
3: Hard");
            int ChosenLevel = int.Parse(Console.ReadLine());
        another:
            Console.WriteLine("Enter your team member's name.");
            string name = Console.ReadLine();
            Console.WriteLine($"Enter {name}'s skill level, 1-100");
            int skillLevel = int.Parse(Console.ReadLine());
            Console.WriteLine($"Enter {name}'s courage level, 0.0-2.0");
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
            Console.WriteLine("");
            Console.WriteLine("-------------");
        Retry:
            Console.WriteLine("How many times yall wanna try this? (1-5)");

            int TrialRuns = int.Parse(Console.ReadLine());

            foreach (var crewMem in HeistCrew)
            {
                Console.WriteLine(@$"
Name: {crewMem.Name},
Skill Level: {crewMem.SkillLevel},
Courage Factor: {crewMem.Courage}");
                Console.WriteLine("-------------");
            }

            int Successes = 0;
            int Failures = 0;

            while (TrialRuns > 0)
            {
                Random r = new Random();
                int Luck = r.Next(-10, 10);

                int BankSecurity = 100;
                BankSecurity += Luck;

                if (ChosenLevel == 1)
                {
                    BankSecurity += 0;
                }
                else if (ChosenLevel == 2)
                {
                    BankSecurity += 100;
                }
                else
                {
                    BankSecurity += 150;
                }

                int CrewSkill = 0;
                foreach (var crewMem in HeistCrew)
                {
                    CrewSkill += crewMem.SkillLevel;
                }
                Console.WriteLine($"The bank's security is {BankSecurity}, and your crew has {CrewSkill} skill.");

                if (CrewSkill > BankSecurity)
                {
                    Console.WriteLine("The Heist was a success! You made a clean getaway.");
                    TrialRuns--;
                    Successes += 1;
                }
                else
                {
                    Console.WriteLine($"{HeistCrew[0].Name} tripped the alarm! You were all arrested.");
                    TrialRuns--;
                    Failures += 1;
                }
            }

            Console.WriteLine("--------------");
            Console.WriteLine(@$"Yall had {Successes} successful robberies and
{Failures} Failed robberies.");
            Console.WriteLine("Do you wanna try again? (yes/no)");
            string SendIt = Console.ReadLine().ToLower();
            if (SendIt == "yes")
            {
                goto Retry;
            }
            else
            {
                Console.WriteLine(@$"Your squad is whack.");
            }
        }
    }
}
