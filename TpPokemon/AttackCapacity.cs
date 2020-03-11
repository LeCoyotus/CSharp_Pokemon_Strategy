using System;
using System.Collections.Generic;
using System.Text;

namespace TpPokemon
{
    class AttackCapacity : AbstractCapacity
    {
        public int Value { get; set; }
        public AttackCapacity(string nom, PokeType capacityType, int value) : base(nom, capacityType)
        {
            Value = value;
        }

        public override void Do(Pokemon pokeThrower, Pokemon pokeReceiver)
        {
            if (IsStrongerAgainst(pokeReceiver))
            {
                pokeReceiver.Hp -= Value * 2;
            }
            else if (IsWeakerAgainst(pokeReceiver))
            {
                pokeReceiver.Hp -= Value / 2;
            }
            else
            {
                pokeReceiver.Hp -= Value;
            }
        }

        public bool IsStrongerAgainst(Pokemon pokeReceiver)
        {
            bool IsStronger = false;
            PokeType capacityType = CapacityType;

            switch (capacityType)
            {
                case PokeType.WATER:
                    IsStronger = (pokeReceiver.PokeType == PokeType.FIRE) ? true : false;
                    break;
                case PokeType.FIRE:
                    IsStronger = (pokeReceiver.PokeType == PokeType.GRASS) ? true : false;
                    break;
                case PokeType.GRASS:
                    IsStronger = (pokeReceiver.PokeType == PokeType.WATER) ? true : false;
                    break;
            }
            return IsStronger;
        }

        public bool IsWeakerAgainst(Pokemon pokeReceiver)
        {
            bool IsWeaker = false;
            PokeType capacityType = CapacityType;

            switch (capacityType)
            {
                case PokeType.WATER:
                    IsWeaker = (pokeReceiver.PokeType == PokeType.GRASS) ? true : false;
                    break;
                case PokeType.FIRE:
                    IsWeaker = (pokeReceiver.PokeType == PokeType.WATER) ? true : false;
                    break;
                case PokeType.GRASS:
                    IsWeaker = (pokeReceiver.PokeType == PokeType.FIRE) ? true : false;
                    break;
            }
            return IsWeaker;
        }

        public override string ToString()
        {
            return base.ToString() + " Damage : " + Value + "]";
        }
    }
}
