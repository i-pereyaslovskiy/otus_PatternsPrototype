using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace otus_PatternsPrototype.Models
{   /// <summary>
    /// A basic abstract class that will be the parent of all monster classes.
    /// </summary>
    public abstract class MonsterBase
    {
        public string? MonsterName { get; set; }
        public int Health { get; set; }
        public int AttackPower { get; set; }
        public abstract void Attack();
    }
}
