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

            //alle pokemons adden voor de dex

            Pokemon meowth = new Normale("Meowth", "Normale");
            dex.AddPokemon(meowth);

            Pokemon snorlax = new Normale("Snorlax", "Normale");
            dex.AddPokemon(snorlax);

            Pokemon charmander = new Fire("Charmander", "Fire");
            dex.AddPokemon(charmander);

            Pokemon litwick = new Fire("Litwick", "Fire");
            dex.AddPokemon(litwick);

            while (true)
            {
                string zoek;
                Console.WriteLine("\nZoek een Pokémon op! (Met hoofdletter)");
                zoek = Console.ReadLine();
                Console.WriteLine("\n");

                foreach (Pokemon p in dex.GetPokemons())
                {
                    if (zoek == p.GetName())
                    {
                        Console.WriteLine(p.GetName());
                        Console.WriteLine(p.GetType());
                    }
                }
            }           
        }
    }
}
