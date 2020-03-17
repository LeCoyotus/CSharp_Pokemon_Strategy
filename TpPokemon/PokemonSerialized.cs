using System;
using System.Collections.Generic;

namespace TpPokemon
{
	public class PokemonSerialized
	{
		public string Name { get; set; }
		public string PokeType { get; set; }

		public List<string> Comps { get; set; }

		public Pokemon CreatePokemon(List<AttackCapacity> listCapacities)
		{
			List<AbstractCapacity> temp = new List<AbstractCapacity>();

			foreach (var AtkCapacity in listCapacities)
			{
				if(Comps.Contains(AtkCapacity.Name)) temp.Add(AtkCapacity);
			}

			var toReturn = new Pokemon(Name, (PokeType)Enum.Parse(typeof(PokeType), PokeType), temp, 300);

			return toReturn;
		}
	}
}
