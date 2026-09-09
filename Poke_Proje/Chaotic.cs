using System;
using System.Collections.Generic;
using System.Text;

namespace Poke_Proje
{
    public class Chaotic : Pokemon, IBattle, IHeal
    {

        public Chaotic(string name, string trainer, int level, int hp, int attack) : base(name, trainer, level, hp, attack) { }
    
        public override string Behavior()
        {
            Console.WriteLine();
            return "Ich bringe Chaos rein wie ein Pokémon mit WLAN und keiner Anleitung";
        }


    }
}
