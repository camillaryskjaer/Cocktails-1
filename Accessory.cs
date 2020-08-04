using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cocktails
{
    class Accessory : Ingredient
    {
        private Type type;

        public Type Type
        {
            get { return type; }
            set { type = value; }
        }

        public Accessory(string name, string type) : base(name)
        {
        }

        public Accessory() { }
    }
}
