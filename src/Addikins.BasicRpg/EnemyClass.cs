﻿using System.Collections.Generic;

namespace Addikins.BasicRpg
{
    public class EnemyClass
    {
        public static List<EnemyClass> AllClasses = new List<EnemyClass>
        {
            // Sets starting enemy stats
            new EnemyClass("Whelp", 20, 1, 2, 25),
            new EnemyClass("Bruiser", 100, 3, 4, 50),
        };

        public string Name { get; set; }
        public int Health { get; set; }
        public int Defense { get; set; }
        public int Attack { get; set; }
        public int Exp { get; set; }

        public EnemyClass(string name, int health, int defense, int attack, int exp)
        {
            Name = name;
            Health = health;
            Defense = defense;
            Attack = attack;
            Exp = exp;
        }

        public override string ToString()
        {
            return $"{Name} - Health: {Health}, Defense: {Defense}, Attack: {Attack}";
        }
    }
}
