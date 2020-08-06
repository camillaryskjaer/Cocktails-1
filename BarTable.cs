using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cocktails
{
    class BarTable : DbContext
    {
        public DbSet<Cocktail> cocktails { get; set; }
        public DbSet<Item> items { get; set; }
        public DbSet<Ingredient> ingredients { get; set; }

        public BarTable() : base()
        {

        }
    }
}
