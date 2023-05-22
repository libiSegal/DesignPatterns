using DrinksVeSuperDrinkMachinendingMachine.Decoretor;
using SuperDrinkMachine.Builder;
using SuperDrinkMachine.Decoretor;
using SuperDrinkMachine.Modules;
using SuperDrinkMachine.TemplateMethod;

namespace SuperDrinkMachine.State
{
    internal class ProcessState : State
    {
        //use singleton DP;
        private static ProcessState _instance;
        private ProcessState()
        {
                
        }
        public static ProcessState GetInstance()
        {
            if (_instance == null)
            {
                _instance = new ProcessState();
            }
            return _instance;
        }
        //use the Builder DP;
        public override void HandleAction(Form1 form1)
        {
            managmentState.SelectedProduct = managmentState.Stock.GetProduct(managmentState.ProductEnum);
            ReportsSaver.AddReport(managmentState.SelectedProduct.Name);
            DrinkMaker drinkMaker = new();
            HandleButton(form1);
            form1.LabelShowProduct.Text = "";
            switch (managmentState.ProductEnum)
            {
                case ProductEnum.can:
                  PackingProduct(form1);
                  break;

                case ProductEnum.snack:
                    PackingProduct(form1);
                    break;

                case ProductEnum.coffee:
                    Coffee coffee =  (Coffee)managmentState.SelectedProduct;
                    drinkMaker.SetMaker(new MakeCoffee(coffee));
                    form1.LabelShowProduct.Text = drinkMaker.Make();                   
                    PackingProduct(form1);
                    break;

                case ProductEnum.iceCoffee:
                    IceCoffee iceCoffee = (IceCoffee)managmentState.SelectedProduct;
                    drinkMaker.SetMaker(new MakeIceCoffee(iceCoffee));
                    form1.LabelShowProduct.Text =  drinkMaker.Make();
                    PackingProduct(form1);

                    break;
                case ProductEnum.cappuccino:
                    Cappuccino cappuccino = (Cappuccino)managmentState.SelectedProduct;
                    drinkMaker.SetMaker(new MakeCappuccino(cappuccino));
                    form1.LabelShowProduct.Text =  drinkMaker.Make();
                    PackingProduct(form1);
                    break;
            }
            form1.LabelShowProduct.Text += $"{managmentState.SelectedProduct.Description}\nThanks for baying";

        }

        //use the Decoretor DP;
        public void PackingProduct(Form1 form1)
        {
            if (form1.Box.Checked)
            {
                new BoxPacking(managmentState.SelectedProduct);

            }
            if (form1.Bag.Checked)
            {
                new BagPacking(managmentState.SelectedProduct);
 
            }
        }


        public override void HandleButton(Form1 form1)
        {
            form1.SelectProduct.Hide();
            form1.ProductList.Hide();
            form1.Bag.Hide();
            form1.Box.Hide();
            form1.Payment.Hide();
            //form1.LabelShowPrice.Hide();
            form1.ButtonToProcess.Hide();
            form1.MoneyForPay.Hide();
            form1.LabelShowProduct.Show();
        }

       
    }
}
