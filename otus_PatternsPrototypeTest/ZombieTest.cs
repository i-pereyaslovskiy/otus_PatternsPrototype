using otus_PatternsPrototype.Models;

namespace otus_PatternPrototypeTest
{
    [TestClass]
    public class ZombieTest
    {
        [TestMethod]
        public void Clone_CreateIdenticalInstance()
        {
            Zombie zombie = new Zombie()
            {
                MonsterName = "Zombie",
                AttackPower = 100,
                Health = 400,
                IsCanBeUpgraded = true,
                Skill = new Skill() { SkillName = "Bite", Damage = 25 }
            };

            Zombie? zombieClone = zombie.Clone() as Zombie;

            Assert.AreEqual(zombie.MonsterName, zombieClone?.MonsterName, "MonsterName not Equal");
            Assert.AreEqual(zombie.AttackPower, zombieClone?.AttackPower, "AttackPower not Equal");
            Assert.AreEqual(zombie.Health, zombieClone?.Health, "Health not Equal");
            Assert.AreEqual(zombie.IsCanBeUpgraded, zombieClone?.IsCanBeUpgraded, "IsCanByUpgraded not Equal");
            Assert.AreEqual(zombie.Skill.SkillName, zombieClone?.Skill?.SkillName, "SkillName not Equal");
            Assert.AreEqual(zombie.Skill.Damage, zombieClone?.Skill?.Damage, "Damage not Equal");
        }
    }
}