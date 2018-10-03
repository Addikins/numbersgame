﻿using System;

namespace CodingwithPSVM
{
    public class Hero
    {
        public Hero(string name, HeroClass heroClass, Armor armor, Weapon weapon)
        {
            Name = name;
            HeroClass = heroClass;
            Armor = armor;
            Weapon = weapon;

            MaxHealth = heroClass.Health;
            Health = heroClass.Health;
            Defense = heroClass.Defense;
            Attack = heroClass.Attack;
        }

        public string Name { get; set; }
        public HeroClass HeroClass { get; set; }
        public Armor Armor { get; set; }
        public Weapon Weapon { get; set; }
        public Inventory Inventory { get; set; }

        public int MaxHealth { get; set; }
        public int Health { get; set; }
        public int Defense { get; set; }
        public int Attack { get;  set; }
        public int Level { get; set; }
        public int Exp { get; set; }
    
        private void LevelUp()
        {
            Inventory.MaxSize++;
            Level++;
            MaxHealth += 100;
        }
        
        public void Heal(int amount)
        {
            Health += amount;
            if (Health > MaxHealth)
            {
                Health = MaxHealth;
            }
        }
        public void AddExp(int amount)
        {
                Exp += amount;
            while(Exp > Math.Pow(Level*10, 1.25))
            {
                LevelUp();
            }
        }
        public string GetStatus()
        {
            return $@"Status:
{Name} the {HeroClass.Name}
Level:{Level} Exp:{Exp}
Health:{Health}/{MaxHealth}    Defense:{Defense}    Attack:{Attack}
Armorset: {Armor.Name} ({Armor.Description})
Weapon: {Weapon.Name} ({Weapon.Description})";
        }
    }
}