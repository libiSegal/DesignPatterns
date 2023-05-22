
using SuperDrinkMachine.Decoretor;
using SuperDrinkMachine.Modules;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DrinksVeSuperDrinkMachinendingMachine.Decoretor
{
    internal class BoxPacking : PackingDecoretor
    {
        public BoxPacking(Product product) : base(product)
        {
            product.Description += " with a box\n ";
        }


 /*       public override string AddToString()
        {
            return product.ToString() + " I have box";
        }*/
    }
}
