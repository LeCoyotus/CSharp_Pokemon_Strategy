using System;
using System.Collections.Generic;

namespace TpPokemon
{
    class Program
    {
        static void Main(string[] args)
        {
            AttackCapacity Flammeche = new AttackCapacity("Flammeche", PokeType.FIRE, 30);
            AttackCapacity LanceFlamme = new AttackCapacity("Lance-Flamme", PokeType.FIRE, 50);

            AttackCapacity Eclair = new AttackCapacity("Eclair", PokeType.ELEK, 35);
            AttackCapacity Electrocharge = new AttackCapacity("Electrocharge", PokeType.ELEK, 55);

            HealCapacity Soins = new HealCapacity("Soins", PokeType.GRASS, 30);
            AttackCapacity FouetLiane = new AttackCapacity("Fouet-Liane", PokeType.GRASS, 20);
            ComboCapacity DrainDeVie = new ComboCapacity("Drain de Vie", PokeType.GRASS, new List<AbstractCapacity>() { FouetLiane, Soins });


            List<AbstractCapacity> CapacityFire = new List<AbstractCapacity>() { Flammeche, LanceFlamme };
            List<AbstractCapacity> CapacityElek = new List<AbstractCapacity>() { Eclair, Electrocharge };
            List<AbstractCapacity> CapacityGrass = new List<AbstractCapacity>() { Soins, DrainDeVie };

            Pokemon Salameche = new Pokemon("Salameche", PokeType.FIRE, CapacityFire, 160);
            Pokemon Pikachu = new Pokemon("Pikachu", PokeType.ELEK, CapacityElek, 200);
            Pokemon Herbizarre = new Pokemon("Herbizarre", PokeType.GRASS, CapacityGrass, 220);

            PokeFight(Salameche, Herbizarre);

        }

        static void PokeFight(Pokemon firstPoke, Pokemon secondPoke)
        {
            Console.WriteLine($"Un combat acharné se lance entre { firstPoke } et { secondPoke }");

            while (firstPoke.Hp > 0 && secondPoke.Hp > 0)
            {
                firstPoke.PokemonTurn(secondPoke);
                secondPoke.PokemonTurn(firstPoke);

                Console.WriteLine(firstPoke);
                Console.WriteLine(secondPoke);
            }

            if(firstPoke.Hp < 0)
            {
                Console.WriteLine(firstPoke.Nom + " is dead...");
            }
            else
            {
                Console.WriteLine(secondPoke.Nom + " is dead...");
            }
        }
    }
}
