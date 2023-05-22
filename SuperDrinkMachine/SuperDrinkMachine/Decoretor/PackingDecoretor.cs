
using SuperDrinkMachine.Modules;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SuperDrinkMachine.Decoretor
{
    internal abstract class PackingDecoretor
    {
        protected Product product;
        public PackingDecoretor(Product product)
        {
            this.product = product;
        }

        public  virtual string AddToString()
        {
            return product.ToString();
        }

    }
}
