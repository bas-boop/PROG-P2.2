using System;

namespace Database
{
    abstract class Pokemon
    {
        private string name;

        public Pokemon(string aName, string aType)
        {
            name = aName;
        }
        public string GetName()
        {
            return name;
        }
        abstract public string GetType();
    }
}
