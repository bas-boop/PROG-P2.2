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

            dex.AddPokemon(new Pokemon("Charmander", "Fire", "", "First"));
            dex.AddPokemon(new Pokemon("Charmeleon", "Fire", "", "Middle"));
            dex.AddPokemon(new Pokemon("Charizard", "Fire", "Flying", "Last"));
            dex.AddPokemon(new Pokemon("Litwick", "Ghost", "Fire", "First"));

            //einde van alle geadded pokemons voor de dex

            /// <summary>
            /// Alle Debug test 'pokemon'
            /// dex.AddPokemon(new Pokemon("F", "Fire", "Fire", "First"));
            /// </summary>

            while (true)//Dit is Zoek() denk ik
            {
                string zoek;
                Console.WriteLine("\nJe kan Pokémons zoek met een hun naam, met hun type, of via hun evolotion state(First, Middle, Last)(vergeet geen Hoofdletter).");
                zoek = Console.ReadLine();
                Console.WriteLine("\n");

                foreach (Pokemon p in dex.GetPokemons())
                {
                    if (zoek == p.GetName())
                    {
                        Console.WriteLine(p.GetName() + "\n" + p.GetType() + " " + p.GetType2() + "\nDe evolotion state is " + p.GetEvolotionState());
                    }
                    if (zoek == p.GetType())
                    {
                        Console.WriteLine(p.GetName() + "\n" + p.GetType() + " " + p.GetType2() + "\nDe evolotion state is " + p.GetEvolotionState() + "\n");
                    }
                    if (zoek == p.GetType2())
                    {
                        Console.WriteLine(p.GetName() + "\n" + p.GetType() + " " + p.GetType2() + "\nDe evolotion state is " + p.GetEvolotionState() + "\n");
                    }
                    if (zoek == p.GetEvolotionState())
                    {
                        Console.WriteLine(p.GetName() + "\n" + p.GetType() + " " + p.GetType2() + "\nDe evolotion state is " + p.GetEvolotionState() + "\n");
                    }
                }
            }           
        }
    }
}
