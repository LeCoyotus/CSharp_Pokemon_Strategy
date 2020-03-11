﻿using System;
using System.Collections.Generic;
using System.Text;

namespace TpPokemon
{
    public class ComboCapacity : AbstractCapacity
    {
        public List<AbstractCapacity> CumulatedCapacities { get; set; }
        public ComboCapacity(string nom, PokeType capacityType, List<AbstractCapacity> cumulatedCapacities) : base(nom, capacityType)
        {
            CumulatedCapacities = cumulatedCapacities;
        }

        public override void Do(Pokemon pokeThrower, Pokemon pokeReceiver)
        {
            foreach(AbstractCapacity capacity in CumulatedCapacities)
            {
                capacity.Do(pokeThrower, pokeReceiver);
            }
        }

        public override string ToString()
        {
            string temp = "";
            foreach(AbstractCapacity capacity in CumulatedCapacities)
            {
                temp += capacity.ToString();
            }
            return temp;
        }
    }
}
