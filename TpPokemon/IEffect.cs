using System;
using System.Collections.Generic;
using System.Text;

namespace TpPokemon
{
    public interface IEffect
    {
        void Do(Pokemon pokeThrower, Pokemon pokeReceiver) { }
    }
}
