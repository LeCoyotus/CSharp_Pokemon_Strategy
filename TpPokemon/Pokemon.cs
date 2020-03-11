using System;
using System.Collections.Generic;
using System.Text;

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
        public string Nom { get; }
        public PokeType PokeType { get; }

        List<AbstractCapacity> Comps { get; set; }

        public int Hp { get; set; }

        public List<AlterationStatus> AlterationStatus { get; set; }

        public Pokemon(string nom, PokeType pokeType, List<AbstractCapacity> comps, int hp)
        {
            Nom = nom;
            PokeType = pokeType;
            Comps = comps;
            Hp = hp;
            AlterationStatus = new List<AlterationStatus>();
            Comps = comps;
        }

        public AbstractCapacity SelectCapacity()
        {
            int i = 0;
            int choix;
            Console.WriteLine("Selectionner votre attaque : ");
            foreach(AbstractCapacity capacity in Comps)
            {
                Console.WriteLine($"{i} - { capacity }");
                i++;
            }

            choix = Utils.InputNumber();

            while(choix > Comps.Count - 1)
            {
                choix = Utils.InputNumber();
            }
            return Comps[choix];
        }

        public void PokemonTurn(Pokemon targetPokemon)
        {
            SelectCapacity().Do(this, targetPokemon);
        }

        public override string ToString()
        {
            string temp = $"({ Nom } - { PokeType } - { Hp })";
            return temp;
        }
    }
}
