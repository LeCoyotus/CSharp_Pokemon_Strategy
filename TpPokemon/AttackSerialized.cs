using System;

namespace TpPokemon
{
	public class AttackSerialized
	{
		public string Name { get; set; }

		public string CapacityType { get; set; }

		public string Value { get; set; }


		public AttackCapacity CreateAttackCapacity()
		{

			AttackCapacity toReturn = new AttackCapacity(Name, (PokeType)Enum.Parse(typeof(PokeType), CapacityType), int.Parse(Value));

			return toReturn;
		}

	}
}
