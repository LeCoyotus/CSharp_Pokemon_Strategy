using System;
using System.Collections.Generic;
using System.Threading;

namespace TpPokemon
{
	internal class Program
	{
		private static void Main(string[] args)
		{
			var gameData = new GameData();
			gameData.Deserialize();

			DisplayAllPokemon(gameData.PokemonsTable);
			DisplayAllCapacities(gameData.AttackCapacitiesTable);

			Pokemon[] temp = SelectFighters(gameData.PokemonsTable);
			PokeFight(temp[0], temp[1]);

		}

		private static Pokemon[] SelectFighters(List<Pokemon> potentialFighters)
		{
			Pokemon[] selection = {null, null};
			int i = 0;

			foreach (Pokemon pokemon in potentialFighters)
			{
				Console.WriteLine($"[ { i++ } ] - { pokemon }");
			}

			while (selection[0] == null)
			{
				try
				{
					Console.Write("Choix du premier Pokemon : ");
					selection[0] = potentialFighters[Utils.InputNumberPositiv()];
				}
				catch (Exception e)
				{
					Console.WriteLine(e);
				}
			}
			while (selection[1] == null)
			{
				try
				{
					Console.Write("Choix du second Pokemon : ");
					selection[1] = potentialFighters[Utils.InputNumberPositiv()];
				}
				catch (Exception e)
				{
					Console.WriteLine(e);
				}
			}
			return selection;
		}
		private static void PokeFight(Pokemon firstPoke, Pokemon secondPoke)
		{
			Console.WriteLine($"Un combat acharné se lance entre {firstPoke} et {secondPoke}");

			while (firstPoke.Hp > 0 && secondPoke.Hp > 0)
			{
				firstPoke.PokemonTurn(secondPoke);
				Thread.Sleep(1000);

				secondPoke.PokemonTurn(firstPoke);
				Thread.Sleep(1000);
			}

			Console.WriteLine($"{ firstPoke } // { secondPoke }");
		}

		private static void DisplayAllCapacities(List<AttackCapacity> listToDisplay)
		{
			Console.WriteLine("Liste de toutes les capacités : ");
			foreach (var atk in listToDisplay) Console.WriteLine(atk);
		}

		private static void DisplayAllPokemon(List<Pokemon> ourPokemons)
		{
			foreach (var pokemon in ourPokemons)
			{
				Console.WriteLine(pokemon);
				foreach (var capacity in pokemon.Comps) Console.WriteLine("\t" + capacity);
			}
		}
	}
}