using System;

namespace Database
{
    class Pokemon
    {
        private string name;

        public Pokemon(string aName)
        {
            name = aName;
        }
        public string GetName()
        {
            return name;
        }
    }
}
