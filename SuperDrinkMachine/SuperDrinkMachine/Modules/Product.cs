using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SuperDrinkMachine.Modules
{
    public  class Product
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public double Price { get; set; }

        public Product()
        {
            Name = "";
            Description = "";

        }

   
        
    }
}
