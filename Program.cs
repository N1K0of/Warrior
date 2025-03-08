using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Warriors
{
    internal class Program 
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Дайте имя воину: ");
            string name = Console.ReadLine();

            Console.WriteLine("Выберите класс:");
            Console.WriteLine("1. Варвар");
            Console.WriteLine("2. Воин в легких доспехах");
            Console.WriteLine("3. Воин в тяжелых доспехах");
            int choice = int.Parse(Console.ReadLine());

            Console.WriteLine("Введите изначальынй HP воина:");
            int health = int.Parse(Console.ReadLine());

            Console.WriteLine("Нанесите урон:");
            int damage = int.Parse(Console.ReadLine());

            Human warrior = null;

            switch (choice)
            {
                case 1:
                    warrior = new Warrior(name, health);
                    break;
                case 2:
                    warrior = new Warrior.LightWarrior(name, health);
                    break;
                case 3:
                    warrior = new Warrior.HeavyWarrior(name, health);
                    break;
                default:
                    Console.WriteLine("Невернный ввод");
                    return;
            }

            warrior.TakeDamage(damage);
        }
    }
    
}
