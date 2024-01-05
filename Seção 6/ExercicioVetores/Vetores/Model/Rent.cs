using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vetores.Model
{
    internal class Rent
    {
        public string Name { get; set; }
        public string Email { get; set; }
       
        public override string ToString()
        {
            return Name + ", " + Email;
        }

    }
}
