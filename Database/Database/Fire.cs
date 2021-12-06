using System;
using System.Collections.Generic;
using System.Text;

namespace Database
{
    class Fire : Pokemon
    {
        private string type = "Fire";
        public Fire(string name, string aType) : base(name, aType)
        {
            type = aType;
        }

        public override string GetType()
        {
            return type;
        }
    }
}
