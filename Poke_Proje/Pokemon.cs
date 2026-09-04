using System;
using System.Collections.Generic;
using System.Text;

namespace Poke_Proje
{
    public abstract class Pokemon : IBattle, IHeal
    {
        public string Name { get; set; }
        protected string Trainer { get; set; }
        protected int Level { get; set; }
        protected int HP { get; set; }
        protected int MaxHP { get; set; }
        protected int AttackDamage { get; set; }
        protected int Defense { get; set; }

        public List<Attack> attacks { get; set; } = new List<Attack>();

        protected Pokemon(string name, string trainer, int level, int hp, int attackDamage, int defense)
        {
            Name = name;
            Trainer = trainer;
            Level = level;
            HP = hp;
            MaxHP = hp;
            AttackDamage = attackDamage;
            Defense = defense;
        }

        public abstract string Behavior();

        // using the objekt direcly
      
        public void AddAttack(string name, int damage)
        {
            if (attacks.Count >= 4)
            {
                Console.WriteLine($"{Name} already knows 4 attacks, chill brudi");
                return;
            }
            attacks.Add(new Attack(name, damage));
        }

        public int Attack(Pokemon p2, Attack attack)
        {
            Console.WriteLine();
            Console.WriteLine($"{Name} uses {attack.Name} to annihilate {p2.Name}");
            return attack.Damage;
        }

        public void TakeDamage(int damage)
        {
            // substracting the damage from defense
            // like you attack 1 million and p2 has 2millions then you did just 1million dmg okk????
            damage -= Defense;  
            if (damage < 0) damage = 0;

            // this subtracts damage from hp pretty understandable right?????
            HP -= damage;
            if (HP < 0) HP = 0; // no negative hp bihh
            
            Console.WriteLine($"{Name} got {damage} damage lol - New HP: {HP}");
        }


        // if hp more than 0 then gg we rollin
        // if hp same or less 0 LOSEEERRR LOLOLOL LOOSTTT
        public bool IsDefeated()
        {
            return HP <= 0;

            // could´ve written this bs with if else but who has the time for it
            // actually took me more time to comment this shi 

            // if( HP <= 0) return true
            // else return false
        }

        public void Heal()
        {
            // setting current hp to full hp
            HP = MaxHP;
            Console.WriteLine($"{Name} has been fully healed! HP: {HP}/{MaxHP}");
        }

        public string ShowStatus()
        {
            
            return $"{Name} - {Trainer} - Lvl: [{Level}], HP: {HP}/{MaxHP}, ATK: {AttackDamage}, DEF: {Defense}\n";
            
        }
    }
}
