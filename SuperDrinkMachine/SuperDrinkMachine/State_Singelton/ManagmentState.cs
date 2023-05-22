using SuperDrinkMachine.Modules;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SuperDrinkMachine.State
{
    public class ManagmentState
    {
        private State _state = null;
        public Stock Stock { get; set; }
        public Product SelectedProduct { get; set; }
        public ProductEnum ProductEnum { get; set; }
        public double Sum { get; set; }
        public ManagmentState(State state , Stock stock )
        {
            
            Stock = stock;
            TransitionTo(state);
        }
        public void TransitionTo(State state)
        {

            _state = state;
            _state.managmentState  = this;
        }
        public void HandleCurrentStateAction(Form1 form1)
        {
            _state.HandleAction(form1);
        }
        public void HandleCurrentStateButton(Form1 form1)
        {
            _state.HandleButton(form1);
        }
    }
}
