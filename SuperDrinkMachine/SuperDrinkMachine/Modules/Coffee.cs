using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SuperDrinkMachine.Modules
{
    internal class Coffee: CupDrink
    {
        public Coffee()
        {
            Description = "I am a coffee\n";
        }
      /*  public override string ToString()
        {
            return "I am a coffee\n";
        }*/
    }
}
