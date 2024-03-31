using otus_PatternsPrototype.Interfaces;
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
    public class Undead : MonsterBase, ICloneable, IMyCloneable<Undead>
    {

        /// <summary>
        /// In our game, only undead can be upgraded
        /// </summary>
        public bool IsCanBeUpgraded { get; set; }

        /// <summary>
        /// Creates a new UndeadClass that is a copy of the current instance.
        /// </summary>
        /// <returns>A new object that is a copy of this instance.</returns>
        public virtual object Clone()
        {
            return MyClone();
        }

        public virtual Undead MyClone()
        {
            return new Undead()
            {
                AttackPower = AttackPower,
                Health = Health,
                MonsterName = MonsterName,
                IsCanBeUpgraded = IsCanBeUpgraded
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
