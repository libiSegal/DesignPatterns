
using SuperDrinkMachine.Modules;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SuperDrinkMachine.Decoretor
{
    internal class BagPacking : PackingDecoretor
    {
        public BagPacking(Product product) : base(product)
        {
            product.Description += "with a bag\n";
        }


      /*  public override string AddToString()
        {
            return product.ToString() + " I have bag";
        }*/
    }
}
