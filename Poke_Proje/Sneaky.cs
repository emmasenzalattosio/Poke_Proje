using System;
using System.Collections.Generic;
using System.Text;

namespace Poke_Proje
{
    public class Sneaky : Pokemon
    {
        public Sneaky(string name, string owner, int level, int hp, int attackdamage, int defense) : base(name, owner, level, hp,  attackdamage, defense)
        {

        }

        public override string Behavior()
        {
            return $"Ist halt einfach da aber niemand merkt es";
        }
    }
}
