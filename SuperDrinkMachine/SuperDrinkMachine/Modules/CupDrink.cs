using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SuperDrinkMachine.Modules
{
    internal class CupDrink :Product
    {
        public string? Ingredients { get; set; }

        public string Prepare { get; set; }
        public CupDrink()
        {
            Prepare = "";
        }

    }
}
