using System;
using System.Collections.Generic;

namespace TpPokemon
{
	public enum PokeType
	{
		NONE,
		GRASS,
		FIRE,
		WATER,
		ELEK,
		ROCK
	}

	public enum AlterationStatus
	{
		NONE,
		BURNED,
		MADNESS,
		PARALYSED,
		SLEEP,
		POISONED
	}

	public class Pokemon
	{
		public string Name { get; }
		public PokeType PokeType { get; }

		public List<AbstractCapacity> Comps { get; set; }

		public int Hp { get; set; }

		public int HpMax { get; }

		public List<AlterationStatus> AlterationStatus { get; set; }

		public Pokemon(string name, PokeType pokeType, List<AbstractCapacity> comps, int hp)
		{
			Name = name;
			PokeType = pokeType;
			Comps = comps;
			Hp = hp;
			AlterationStatus = new List<AlterationStatus>();
			Comps = comps;
			HpMax = hp;
		}

		public AbstractCapacity SelectCapacity()
		{
			int i = 0;
			int choix;
			Console.WriteLine("Selectionner votre attaque : ");
			foreach (AbstractCapacity capacity in Comps)
			{
				Console.WriteLine($"{i} - {capacity}");
				i++;
			}

			choix = Utils.InputNumberPositiv();

			while (choix > Comps.Count - 1)
			{
				choix = Utils.InputNumberPositiv();
			}

			return Comps[choix];
		}

		public AbstractCapacity SelectRandomCapacity()
		{
			return Comps[Utils.RandomNumberParIsMaxValue(Comps.Count)];
		}
		public void PokemonTurn(Pokemon targetPokemon)
		{
			SelectRandomCapacity().Do(this, targetPokemon);
		}

		public override string ToString()
		{
			string temp = (Hp > 0) ? $"({Name} - {PokeType} - {Hp} / {HpMax})" : $"({Name} - {PokeType} - KO)";
			return temp;
		}
	}
}