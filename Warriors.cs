using System;

public class Warrior : Human
{

    public Warrior(string name, int health) : base(name, health) { }

    public override void TakeDamage(int damage)
    {        
        Health -= damage;
        if (Health < 0)
        {
            Health = 0;
        }
        Console.WriteLine($"{Name} варвар получил {damage} ед. урона.");
    }

    public class LightWarrior : Human
    {
        public LightWarrior(string name ,int health) : base(name, health) { }

        public override void TakeDamage(int damage)
        {            
            int DamageLight = (int)(damage * 0.60);
            Health -= DamageLight;
            if (Health < 0)
            {
                Health = 0;
            }
            Console.WriteLine($"{Name} воин в легких доспехах получил {DamageLight} ед. урона.");
        }
    }

    public class HeavyWarrior : Human
    {
        public HeavyWarrior(string name ,int health) : base(name,health) { }

        public override void TakeDamage(int damage)
        {
            
            int DamageHeavy = (int)(damage * 0.5);
            Health -= DamageHeavy;
            if (Health < 0)
            {
                Health = 0;
            }
            Console.WriteLine($"{Name} воин в тяжелых доспеха поулчил {DamageHeavy} ед. урона.{Health}");
        }
    }

}