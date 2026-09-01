using System;
using System.Collections.Generic;
using System.Text;

namespace Poke_Proje
{
    public class Attack
    {
        public string Name { get; set; }
        public int Damage { get; set; }

        public Attack(string name, int damage)
        {
            Name = name;
            Damage = damage;
        }
    }
}
