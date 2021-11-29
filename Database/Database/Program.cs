using System;
using System.Collections.Generic;
using System.Text;

namespace Database
{
    class Program
    {
        static void Main()
        {
            Pokedex dex = new Pokedex();

            Pokemon aPokemon = new Normale("Meowth", "Normale");

            dex.AddPokemon(aPokemon);

            foreach (Pokemon p in dex.GetPokemons())
            {
                Console.WriteLine(p.GetName());
                Console.WriteLine(p.GetType());
            }
        }
    }
}
