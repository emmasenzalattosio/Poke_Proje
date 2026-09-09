using System;
using System.Collections.Generic;
using System.Text;

namespace Poke_Proje
{
    public class TeamWH : Trainer
    {
        //private string[] evilQuotes;
        //private Random rnd;

        public TeamWH(string name) : base(name)
        {
            //    //rnd = new Random();
            //    evilQuotes = new string[]
            //    {
            //        "Wir wollen über die Erde regieren!!! Und unseren eigene Staat Kreiren!!!",
            //        "Liebe und Wahrheit verurteilen wir!!! Mehr und Mehr Macht, das wollen wir!!!",
            //        "Tommy und Heidi",
            //        "Team WH so schnell wie das Licht, Gebt lieber auf und bekämpft uns nicht!!!",
            //        "Miauz Genau!!!"
            //    };
        }

        public List<string> StealPokemon(Trainer victim)
        {
            List<string> lines = new List<string>
            {
                "!!! TEAM WH IST AUS DEM NICHTS AUFGETAUCHT !!!",
                $">> {Name} <<",
                "",
                "Wir wollen über die Erde regieren!!! Und unseren eigene Staat Kreiren!!!",
                "",
                "Liebe und Wahrheit verurteilen wir!!! Mehr und Mehr Macht, das wollen wir!!!",
                "",
                "Tommy und Heidi",
                "",
                "Team WH so schnell wie das Licht, Gebt lieber auf und bekämpft uns nicht!!!",
                "",
                "Miauz Genau!!!",
                "",
                "",
            };

            if (!victim.HasPokemon())
            {
                lines.Add($"{Name}: \"Bruh du bist broke, nicht mal Pokemon zum klauen hast du\"");
                lines.Add("*Team WH rennt entäuschent weg*");
                return lines;
            }

            // yoink all the pokeon
            List<Pokemon> stolenGoods = new List<Pokemon>(victim.ass_poke);
            victim.ClearTeam();

            foreach (Pokemon p in stolenGoods)
            {
                this.ass_poke.Add(p);
                p.SetTrainer(this.Name);
                lines.Add($"{Name} klaut {p.Name}!! *yoink*");
            }

            lines.Add(string.Empty);
            lines.Add($"{Name}: \"Willst du ein echter trainer sein?? Dann komm und hol sie dir zurück!!\"");
            lines.Add($"{Name}: \"Aber vorher Git Gud lol!\"");
            return lines;
        }
    }
}