using System;
using System.Collections.Generic;
using System.Text;

namespace Poke_Proje
{
    public interface IBattle
    {

        // not void because need to return value
        // need parameter to know who tf we gonna smack up lol
        // When we gonna make two pokemon combat we gonna need to give some shit
        // like pokemon 1 Attacking (pokemon 2)
        int Attack(Pokemon p2);
        bool IsDefeated();
    }
}
