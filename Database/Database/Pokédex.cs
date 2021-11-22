using System;

namespace Database
{
    class Pokédex
    {
        private List<Pokémons> pokémon;

        public Pokédex()
        {
            pokémon = new List<Pokémons>();
        }

        public void AddPokémon(Pokémons pokémon)
        {
            Pokémon.Add(pokémon);
        }

        public Pokémons GetPokémon()
        {
            return pokémon[0];
        }
    }
}
