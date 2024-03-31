using otus_PatternsPrototype.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace otus_PatternsPrototype.Models
{
    public class Zombie : Undead, IMyCloneable<Zombie>
    {
        /// <summary>
        /// The zombie class that we use in the game
        /// Based on Undead class and used IMyCloneable interface
        /// </summary>
        public Skill? Skill { get; set; } = null!;
        public void UpgradeMonster()
        {
            if (IsCanByUpgraded)
            {
                Console.WriteLine($"{MonsterName} was Upgraded");
                Skill.SkillName = $"Strong{Skill.SkillName}";
                MonsterName = $"{MonsterName}Boss";
                Health += 200;
                AttackPower += 35;
            }
            else
                Console.WriteLine($"{MonsterName} cannot be upgraded");
        }
        public Zombie MyClone()
        {
            return new Zombie
            {
                AttackPower = AttackPower,
                Health = Health,
                MonsterName = MonsterName,
                Skill = Skill,
                IsCanByUpgraded = IsCanByUpgraded
            };
        }
        public override object Clone()
        {
            return MyClone();
        }

        public override string ToString()
        {
            return $"{MonsterName}; Skill: '{Skill?.SkillName}'; Heath: '{Health}',  AttackPower:'{AttackPower}'";
        }
    }
}
