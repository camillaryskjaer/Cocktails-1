using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cocktails
{
    class Program
    {
        static void Main(string[] args)
        {
            using (var ctx = new BarTable())
            {

                /*ctx.cocktails.Add(
                    new Cocktail("White Russian", new List<Item>()
                    {
                        new Item(30, new Liquid("Fresh Cream", "White")),
                        new Item(30, new Alcohol("Kahlua", "Black", 35)),
                        new Item(90, new Alcohol("Vodka", "Transparent", 45))
                    }
                        )
                    );
                ctx.SaveChangesAsync().GetAwaiter().GetResult();

                Console.ReadKey();*/

                var test = from c in ctx.cocktails join o in ctx.items on c.Id equals o.Id join e in ctx.ingredients on o.Id equals e.Id select new { o.Unit, c.Name};

                var res = ctx.cocktails.Where(o=> o.Name == "White Russian");
                var res2 = ctx.items;
                var res3 = ctx.ingredients;
                foreach (var item in test)
                {
                    Console.WriteLine(item.Name + " " + item.Unit + " ml");                   
                    
                }

                Console.ReadKey();
            }
        }
    }
}
