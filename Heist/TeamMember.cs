using System;

namespace Heist
{
    public class Member
    {
        public Member(string newName, int newSkill, double newCourage)
        {
            Name = newName;
            SkillLevel = newSkill;
            Courage = newCourage;
        }
        public string Name { get; set; }
        public int SkillLevel { get; set; }
        public double Courage { get; set; }
    }
}