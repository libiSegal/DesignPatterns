using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SuperDrinkMachine
{
    public abstract class Suplier
    {
        public string Name { get; set; }
        public string Phone { get; set; }

        public abstract void UpdateSuplier();
    }
}
