using System;
using System.Collections.Generic;
using System.Text;

namespace Database
{
    class Program
    {
        /// <summary>
        /// Mijn hele mooie Pokédex waar je meerde Pokémons in kan doen en kan vinden via hun naam types of evulotion state.
        /// </summary>

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
                Console.WriteLine("\nWil je een Pokémon toevoegen y/n? zo nee, dan ga je zoeken.");
                string vraag = Console.ReadLine();
                if (vraag == "y")
                {
                    string name, t1, t2, es;
                    Console.WriteLine("\nWat is de naam van jouw Pokémon?");
                    name = Console.ReadLine();
                    Console.WriteLine("\nEerste type?");
                    t1 = Console.ReadLine();
                    Console.WriteLine("\nTweede type? Als er geen is druk dan op enter");
                    t2 = Console.ReadLine();
                    Console.WriteLine("\nEvelution state?");
                    es = Console.ReadLine();
                    dex.AddPokemon(new Pokemon(name, t1, t2, es));
                }
                else if(vraag == "n")
                {
                    Console.WriteLine("\nJe kan Pokémons zoek met een hun naam, met hun type, of via hun evolotion state(First, Middle, Last)(vergeet geen Hoofdletter).");
                    string zoek = Console.ReadLine();
                    Console.WriteLine("\n");

                    foreach (Pokemon p in dex.GetPokemons())
                    {
                        if (zoek == p.GetName())
                        {
                            Console.WriteLine(p.GetName() + "\n" + p.GetType() + " " + p.GetType2() + "\nDe evolotion state is " + p.GetEvolotionState() + "\n");
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
                else if(vraag == "F")
                {
                    Console.WriteLine("\n\nF\n\n");
                }
                else
                {
                    Console.WriteLine("\n\nEY, je mag alleen y of n zeggen\n\n");
                }
            }           
        }
    }
}
