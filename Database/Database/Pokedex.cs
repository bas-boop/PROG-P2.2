using System;
using System.Collections.Generic;

namespace Database
{
    class Pokedex
    {
        private List<Pokemon> pokemons;

        public Pokedex()
        {
            pokemons = new List<Pokemon>();
        }

        public void AddPokemon(Pokemon aPokemon)
        {
            pokemons.Add(aPokemon);
        }
        public List<Pokemon> GetPokemons()
        {
            return pokemons;
        }
    }
}
