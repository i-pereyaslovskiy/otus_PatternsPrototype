using otus_PatternsPrototype.Models;

Zombie zombie = new Zombie() { MonsterName = "Zombie", AttackPower = 100, Health = 400, IsCanBeUpgraded = true, Skill = new Skill() { SkillName = "Bite", Damage = 25 } };

Console.WriteLine(zombie);
zombie.UpgradeMonster();
var zombieBoss = zombie.MyClone();
Console.WriteLine(zombieBoss);

Console.WriteLine();

Skeleton skeleton = new Skeleton() { MonsterName = "Skeleton", AttackPower = 75, Health = 250, IsCanBeUpgraded = true, Skill = new Skill() { SkillName = "Hit", Damage = 15 } };
Console.WriteLine(skeleton);
skeleton.UpgradeMonster();
var skeletonBoss = skeleton.MyClone();
Console.WriteLine(skeletonBoss);


Console.ReadKey();