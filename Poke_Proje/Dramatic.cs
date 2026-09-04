using System;
using System.Collections.Generic;
using System.Text;

namespace Poke_Proje
{
    public class Dramatic : Pokemon
    {
        public Dramatic(string name, string trainer, int level, int hp, int attack, int defense) : base (name, trainer, level, hp, attack, defense)
        {
   
        }
        public override string Behavior()
        {
            return "Rastet bei dem kleinsten Kratzer schon aus und heult";
        }


    }
}
