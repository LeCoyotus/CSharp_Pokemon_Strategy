using System;
using System.Collections.Generic;
using System.Text;

namespace TpPokemon
{
    public abstract class AbstractCapacity : IEffect
    {
        public string Nom { get; }

        public PokeType CapacityType { get; set; }

        protected AbstractCapacity(string nom, PokeType capacityType)
        {
            Nom = nom;
            CapacityType = capacityType;
        }

        public abstract void Do(Pokemon pokeThrower, Pokemon pokeReceiver);

        public override string ToString()
        {
            string temp = $"[{ Nom } - { CapacityType }";
            return temp;
        }
    }
}
