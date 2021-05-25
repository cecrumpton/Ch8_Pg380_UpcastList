using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ch8_Pg380_UpcastList
{
    class Shoe
    {
        public string Name { get; set; }
        public string Color { get; set; }
        public override string ToString()
        {
            return "A pair of " + Color + " " + Name;
        }
    }
}
