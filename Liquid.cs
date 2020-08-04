using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cocktails
{
    class Liquid : Ingredient
    {
        private string colour;
        
        public string Colour
        {
            get { return colour; }
            set { colour = value; }
        }

        public Liquid(string name, string colour) : base(name)
        {
            Colour = colour;
        }

        public Liquid() { }

    }
}
