using System;
using System.Collections.Generic;
using System.Text;

namespace Poke_Proje
{
    public class Sneaky : Pokemon
    {
        public Sneaky(string name, string trainer, int level, int hp, int attackdamage) : base(name, trainer, level, hp,  attackdamage)
        {

        }

        public override string Behavior()
        {
            Console.WriteLine();
            return $"Ist halt einfach da aber niemand merkt es";
        }
    }
}
