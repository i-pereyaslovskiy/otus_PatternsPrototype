using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace otus_PatternsPrototype.Models
{
    /// <summary>
    /// Represents the class as a division of monsters that are related to the undead
    /// </summary>
    public class Undead : MonsterBase, ICloneable
    {

        /// <summary>
        /// In our game, only undead can be upgraded
        /// </summary>
        public bool IsCanByUpgraded { get; set; }


        /// <summary>
        /// Creates a new UndeadClass that is a copy of the current instance.
        /// </summary>
        /// <returns>A new object that is a copy of this instance.</returns>
        public virtual object Clone()
        {
            return new Undead()
            {
                AttackPower = AttackPower,
                Health = Health,
                MonsterName = MonsterName,
                IsCanByUpgraded = IsCanByUpgraded
            };
        }
        public override void Attack()
        {
            Console.WriteLine("Monster attacks");
        }

        public override string ToString()
        {
            return $"{MonsterName}; Skill NoSkill; Stats {Health}, {AttackPower} ";
        }
    }
}
