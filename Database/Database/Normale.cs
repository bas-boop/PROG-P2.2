using System;
using System.Collections.Generic;
using System.Text;

namespace Database
{
    class Normale : Pokemon
    {
        private string type = "Normale";
        public Normale(string name, string aType) : base(name, aType)
        {
            type = aType;
        }

        public override string GetType()
        {
            return type;
        }
    }
}
