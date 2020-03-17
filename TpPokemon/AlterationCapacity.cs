namespace TpPokemon
{
    class AlterationCapacity : AbstractCapacity
    {
        AlterationStatus Alteration { get; set; }
        public AlterationCapacity(string name, PokeType capacityType, AlterationStatus alteration) : base(name, capacityType)
        {
            Alteration = alteration;
        }

        public override void Do(Pokemon pokeThrower, Pokemon pokeReceiver)
        {
            if (Utils.Rand()) pokeReceiver.AlterationStatus.Add(Alteration);
        }

        public override string ToString()
        {
            return base.ToString() + " Chance to apply " + Alteration + "]";
        }
    }
}
