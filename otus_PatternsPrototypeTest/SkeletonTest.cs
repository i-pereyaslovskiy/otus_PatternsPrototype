using otus_PatternsPrototype.Models;

namespace otus_PatternPrototypeTest
{
    [TestClass]
    public class SkeletonTest
    {
        [TestMethod]
        public void Clone_CreateIdenticalInstance()
        {
            Skeleton skeleton = new Skeleton()
            {
                MonsterName = "Skeleton",
                AttackPower = 75,
                Health = 250,
                IsCanByUpgraded = true,
                Skill = new Skill() { SkillName = "Hit", Damage = 15 }
            };

            Skeleton? skeletonClone = skeleton.Clone() as Skeleton;

            Assert.AreEqual(skeleton.MonsterName, skeletonClone?.MonsterName, "MonsterName not Equal");
            Assert.AreEqual(skeleton.Health, skeletonClone?.Health, "Health not Equal");
            Assert.AreEqual(skeleton.AttackPower, skeletonClone?.AttackPower, "AttackPower not Equal");
            Assert.AreEqual(skeleton.IsCanByUpgraded, skeletonClone?.IsCanByUpgraded, "IsCanByUpgraded not Equal");
            Assert.AreEqual(skeleton.Skill.SkillName, skeletonClone?.Skill?.SkillName, "SkillName not Equal");
            Assert.AreEqual(skeleton.Skill.Damage, skeletonClone?.Skill?.Damage, "Damage not Equal");
        }
    }
}
