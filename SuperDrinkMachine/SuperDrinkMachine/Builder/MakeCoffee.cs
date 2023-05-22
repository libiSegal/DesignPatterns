
using SuperDrinkMachine.Modules;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SuperDrinkMachine.Builder
{
    internal class MakeCoffee : IDrikMaker
    {
         Coffee drink;
        public MakeCoffee(Coffee drink)
        {
            this.drink = drink;
        }

        public void AddIngredients()
        {
            drink.Prepare += "Put coffe Ingredients....\n";
        }

        public void AddWater()
        {
            drink.Prepare += "Put water....\n";
        }

        public void Mix()
        {
            drink.Prepare += "Mix the drink....\n";
        }

        public string GetDrink()
        {
            return drink.Prepare;
        }

    }
}
