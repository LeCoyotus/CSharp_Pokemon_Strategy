using System;

namespace TpPokemon
{
    public static class Utils
    {
        static Random rng = new Random();

        public static int Roll()
        {
            return rng.Next(0, 101);
        }

        public static bool Rand()
        {
            return Roll() >= 50;
        }

        public static int RandomNumberParIsMaxValue(int n)
        {
	        return rng.Next(0, n);
        }

        public static int InputNumberPositiv()
        {
            int n = -1;

            while(n < 0)
            {
                try
                {
                    n = Int32.Parse(Console.ReadLine());
                }
                catch (Exception e)
                {
                    Console.WriteLine(e.Message);
                }
            }
            return n;
        }
    }
}
