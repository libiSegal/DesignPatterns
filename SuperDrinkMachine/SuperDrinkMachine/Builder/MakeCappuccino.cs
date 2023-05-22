
using SuperDrinkMachine.Modules;

namespace SuperDrinkMachine.Builder
{
    internal class MakeCappuccino: IDrikMaker
    {
        Cappuccino drink;
        public MakeCappuccino(Cappuccino drink)
        {
            this.drink = drink;
        }

        public void AddIngredients()
        {
            drink.Prepare += "Put cappuccino Ingredients....\n";
        }

        public void AddWater()
        {
            drink.Prepare += "Put water....\n";
        }

        public string GetDrink()
        {
            return drink.Prepare;
        }

        public void Mix()
        {
            drink.Prepare += "Mix the drink....\n";
        }
    }
}
