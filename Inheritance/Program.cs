using System;

namespace Inheritance
{
    class Character {
        public string name;
        public short health;
        public short stamina;
        public short strength;
        public void ShowStats() {
            Console.WriteLine($"Name: {name} \nHealth: {health}\nStamina {stamina}\nStrength: {strength}");
        }
    } 

    class Archer: Character {
        public short rangedShot;
        public void Sneak() {
            Console.WriteLine("I am sneaking");
        }
    }

    class Mage: Character {
        public short lightningBolt;
        public void Cast() {
            Console.WriteLine("I am casting");
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Archer sidero = new Archer();
            sidero.name = "Sidero";
            sidero.health = 100;
            sidero.stamina = 100;
            sidero.rangedShot = 10;
            sidero.strength = 100;

            Mage medivh = new Mage();
            medivh.name = "Medivh";
            medivh.health = 70;
            medivh.stamina = 100;
            medivh.lightningBolt = 20;
            medivh.strength = 70;

            medivh.ShowStats();
            medivh.Cast();
            Console.WriteLine($"Lightning Bolt dealt {medivh.lightningBolt} damage.");

            sidero.ShowStats();
            sidero.Sneak();
            Console.WriteLine($"Sneak shot dealt {sidero.rangedShot} damage.");
        }
    }
}
