using System;


public class Human
{
    public int Health { get; set; }
    public string Name { get; set; }

    public Human(string name, int health)
    {
        Name = name;
        Health = health;
    }
    public virtual void TakeDamage(int damage)
    {
        
    }
}