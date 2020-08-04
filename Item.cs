using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cocktails
{
    class Item : Entity
    {
        private int unit;
        private Ingredient ingredient;

        public Ingredient Ingredient
        {
            get { return ingredient; }
            set { ingredient = value; }
        }

        public int Unit
        {
            get { return unit; }
            set { unit = value; }
        }

        public Item(int unit, Ingredient ingredient)
        {
            Unit = unit;
            Ingredient = ingredient;
        }

        public Item() { }

    }
}
