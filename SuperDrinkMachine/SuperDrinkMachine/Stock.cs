
using SuperDrinkMachine.Modules;


namespace SuperDrinkMachine
{
    public class Stock
    {

        public Dictionary<ProductEnum, List<Product>> Inventory { get; set; }
        public Dictionary<ProductEnum, Suplier> Supliers { get; set; }

        public Stock(Dictionary<ProductEnum, List<Product>> inventory, Dictionary<ProductEnum, Suplier> supliers)
        {
            Inventory = inventory;
            Supliers = supliers;
        }
        public Product GetProduct(ProductEnum productEnum)
        {
            Product product = null;

            if (Inventory.ContainsKey(productEnum))
            {
                if (Inventory[productEnum].Count > 0)
                {
                    product = Inventory[productEnum][0];
                    Inventory[productEnum].RemoveAt(0);
                }
                if (Inventory[productEnum].Count == 5)
                {
                    //use the observer DP;
                    Supliers[productEnum].UpdateSuplier();
                }

            }
            return product;
        }

    }
}
