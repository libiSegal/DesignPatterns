using SuperDrinkMachine.Modules;


namespace SuperDrinkMachine
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();
            List<Product> coffees = new List<Product>();
            for (int i = 0; i < 10; i++) { coffees.Add(new Coffee() { Name = "coffee", Price = 8 }); }

            List<Product> iceCoffees = new List<Product>();
            for (int i = 0; i < 10; i++) { iceCoffees.Add(new IceCoffee() { Name = "iceCoffees", Price = 15 }); }

            List<Product> cappuccinos = new List<Product>();
            for (int i = 0; i < 10; i++) { cappuccinos.Add(new Cappuccino() { Name = "cappuccino", Price = 18 }); }

            List<Product> snacks = new List<Product>();
            for (int i = 0; i < 10; i++) { snacks.Add(new Snack() { Name = "snack", Price = 12 }); }

            List<Product> cans = new List<Product>();
            for (int i = 0; i < 10; i++) { cans.Add(new Can() { Name = "can", Price = 6 }); }

            TaraSuplier taraSuplier = new TaraSuplier() { Name = "Tara" , Phone = "02234454546"};
            OsemSuplier osemSuplier = new OsemSuplier() { Name = "Osem", Phone = "09734t3546" };

            Dictionary<ProductEnum, Suplier> supliers = new();
            supliers.Add(ProductEnum.coffee, taraSuplier);
            supliers.Add(ProductEnum.iceCoffee, taraSuplier);
            supliers.Add(ProductEnum.cappuccino, taraSuplier);
            supliers.Add(ProductEnum.can, osemSuplier);
            supliers.Add(ProductEnum.snack, osemSuplier);

            Dictionary<ProductEnum, List<Product>> products = new();
            products.Add(ProductEnum.coffee, coffees);
            products.Add(ProductEnum.iceCoffee, iceCoffees);
            products.Add(ProductEnum.cappuccino, cappuccinos);
            products.Add(ProductEnum.snack, snacks);
            products.Add(ProductEnum.can, cans);

            Stock allStock = new Stock(products , supliers);
            Application.Run(new Form1(allStock));
        }
    }
}