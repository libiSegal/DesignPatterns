using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SuperDrinkMachine.State
{
    public abstract class State
    {
        public ManagmentState managmentState { get; set; }

        public abstract void HandleButton(Form1 form1);
        public abstract void HandleAction(Form1 form1);
    }
}
