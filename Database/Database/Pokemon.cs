using System;

namespace Database
{
    public class Pokemon
    {
        public string name { get; private set; }
        public string type { get; private set; }
        public string type2 { get; private set; }
        public string evolotionState { get; private set; }

        public Pokemon(string aName, string aType, string bType, string es)
        {
            name = aName;
            type = aType;
            type2 = bType;
            evolotionState = es;
        }
        public string GetName()
        {
            return name;
        }
        public string GetType()
        {
            return type;
        }
        public string GetType2()
        {
            return type2;
        }
        public string GetEvolotionState()
        {
            return evolotionState;
        }
    }
}
