using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cocktails
{
    class Alcohol : Liquid
    {
        private int alcohol_percentage;

        public int Alcohol_Percentage
        {
            get { return alcohol_percentage; }
            set { alcohol_percentage = value; }
        }
        

        public Alcohol(string name, string colour, int percentage) : base(name, colour)
        {
            Alcohol_Percentage = percentage;
        }

        public Alcohol() { }
    }
}
