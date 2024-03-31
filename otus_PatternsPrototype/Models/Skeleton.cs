using otus_PatternsPrototype.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace otus_PatternsPrototype.Models
{
    /// <summary>
    /// The skeleton class that we use in the game
    /// Based on Undead class and used IMyCloneable interface
    /// </summary>
    public class Skeleton : Undead, IMyCloneable<Skeleton>
    {
        public Skill? Skill { get; set; }

        public void UpgradeMonster()
        {

            if (IsCanBeUpgraded)
            {
                Console.WriteLine($"{MonsterName} was Upgraded");
                Skill.SkillName = $"Strong{Skill.SkillName}";
                MonsterName = $"{MonsterName}Boss";
                Health += 100;
                AttackPower += 50;
            }
            else
                Console.WriteLine($"{MonsterName} cannot be upgraded");

        }
        public override Skeleton MyClone()
        {
            return new Skeleton
            {
                AttackPower = AttackPower,
                Health = Health,
                MonsterName = MonsterName,
                IsCanBeUpgraded = IsCanBeUpgraded,
                Skill = new Skill { Damage = Skill.Damage, SkillName = Skill.SkillName }
            };
        }

        public override object Clone()
        {
            return MyClone();
        }

        public override string ToString()
        {
            return $"{MonsterName}; Skill: '{Skill?.SkillName}'; Health: '{Health}',  AttackPower:'{AttackPower}'";
        }
    }
}
