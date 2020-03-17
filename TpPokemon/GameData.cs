using System.Collections.Generic;
using System.IO;
using Newtonsoft.Json;

namespace TpPokemon
{
	public class GameData
	{
		public List<AttackCapacity> AttackCapacitiesTable { get; set; }
		public List<Pokemon> PokemonsTable { get; set; }

		public GameData()
		{
			AttackCapacitiesTable = new List<AttackCapacity>();
			PokemonsTable = new List<Pokemon>();
		}
		public void Deserialize()
		{
			string jsonStringCapacity = File.ReadAllText(@"AttackTable.json");

			var attackDeserializeObject = JsonConvert.DeserializeObject<List<AttackSerialized>>(jsonStringCapacity);

			foreach (AttackSerialized attackElt in attackDeserializeObject)
			{
				AttackCapacitiesTable.Add(attackElt.CreateAttackCapacity()); 
			}


			string jsonStringPokemon = File.ReadAllText(@"PokemonTable.json");

			var pokemonDeserializeObject = JsonConvert.DeserializeObject<List<PokemonSerialized>>(jsonStringPokemon);

			foreach (PokemonSerialized pokemonElt in pokemonDeserializeObject)
			{
				PokemonsTable.Add(pokemonElt.CreatePokemon(this.AttackCapacitiesTable));
			}
		}

	}
}
