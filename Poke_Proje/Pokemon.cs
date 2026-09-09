using System;
using System.Collections.Generic;

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

        public List<Attack> attacks { get; set; } = new List<Attack>();

        protected Pokemon(string name, string trainer, int level, int hp, int attackDamage)
        {
            Name = name;
            Trainer = trainer;
            Level = level;
            HP = hp;
            MaxHP = hp;
            AttackDamage = attackDamage;
        }

        public abstract string Behavior();

        public void SetTrainer(string trainer)
        {
            Trainer = trainer;
        }

        public int GetCurrentHp()
        {
            return HP;
        }

        public int GetMaxHp()
        {
            return MaxHP;
        }

        public string GetBattleStatus()
        {
            return $"{Name}: HP {HP}/{MaxHP}";
        }

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
 
            HP -= damage;
            if (HP < 0) HP = 0;

            Console.WriteLine($"{Name} took {damage} damage. Current HP: {HP}/{MaxHP}");
        }

        public bool IsDefeated()
        {
            return HP <= 0;
        }

        public void Heal()
        {
            HP = MaxHP;
            Console.WriteLine($"{Name} has been fully healed! HP: {HP}/{MaxHP}");
        }

        public string ShowStatus()
        {
            return $"{Name} - {Trainer} - Lvl: [{Level}], HP: {HP}/{MaxHP}, ATK: {AttackDamage}\n";
        }
    }
}
