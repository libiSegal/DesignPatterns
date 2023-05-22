
using SuperDrinkMachine.Modules;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SuperDrinkMachine.Builder
{
    internal class DrinkMaker
    {
        IDrikMaker drikMaker;


        public void SetMaker(IDrikMaker drikMaker)
        {
            this.drikMaker = drikMaker;
        }


        public string Make()
        {
            drikMaker.AddWater();
            drikMaker.AddIngredients();
            drikMaker.Mix();
            return drikMaker.GetDrink();

        }

    }
}
