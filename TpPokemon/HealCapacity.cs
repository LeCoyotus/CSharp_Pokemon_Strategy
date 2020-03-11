using System;
using System.Collections.Generic;
using System.Text;

namespace TpPokemon
{
    public class HealCapacity : AbstractCapacity
    {
        public int Value { get; set; }
        public HealCapacity(string nom, PokeType capacityType, int value) : base(nom, capacityType)
        {
            Value = value;
        }

        public override void Do(Pokemon pokeThrower, Pokemon pokeReceiver)
        {
            pokeThrower.Hp += Value;
            Console.WriteLine($" {pokeThrower.Nom } se soigne de { Value }");
        }

        public override string ToString()
        {
            return base.ToString() + " Soins : " + Value + "]";
        }
    }
}
