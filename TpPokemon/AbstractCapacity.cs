namespace TpPokemon
{
    public abstract class AbstractCapacity : IEffect
    {
        public string Name { get; }

        public PokeType CapacityType { get; set; }

        protected AbstractCapacity(string name, PokeType capacityType)
        {
	        Name = name;
            CapacityType = capacityType;
        }

        public abstract void Do(Pokemon pokeThrower, Pokemon pokeReceiver);

        public override string ToString()
        {
            string temp = $"[{ Name } - { CapacityType }]";
            return temp;
        }
    }
}
