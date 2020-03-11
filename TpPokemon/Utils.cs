using System;
using System.Collections.Generic;
using System.Text;

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

        public static int InputNumber()
        {
            int n = -1;

            while(n == -1)
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
