using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cocktails
{
    class Cocktail : Entity
    {
        private string name;
        private List<Item> items;

        public List<Item> Items
        {
            get { return items; }
            set { items = value; }
        }
        
        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        public Cocktail(string name, List<Item> items)
        {
            Name = name;
            Items = items;
        }

        public Cocktail() { }
    }
}
