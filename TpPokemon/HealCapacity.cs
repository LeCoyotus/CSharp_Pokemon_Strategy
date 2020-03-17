using System;

namespace TpPokemon
{
    public class HealCapacity : AbstractCapacity
    {
        public int Value { get; set; }
        public HealCapacity(string name, PokeType capacityType, int value) : base(name, capacityType)
        {
            Value = value;
        }

        public override void Do(Pokemon pokeThrower, Pokemon pokeReceiver)
        {
            pokeThrower.Hp += Value;
            Console.WriteLine($" {pokeThrower.Name } se soigne de { Value }");
        }

        public override string ToString()
        {
            return base.ToString() + " Soins : " + Value + "]";
        }
    }
}
