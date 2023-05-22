using SuperDrinkMachine.Modules;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SuperDrinkMachine.State
{
    internal class PaymentState : State
    {
        private static PaymentState _instance;

        private PaymentState()
        {

        }
        public static PaymentState GetInstance()
        {
            if (_instance == null)
            {
                _instance = new PaymentState();
            }
            return _instance;
        }
        public override void HandleAction(Form1 form1)
        {
            double num = Decimal.ToDouble(form1.MoneyForPay.Value) - managmentState.Stock.Inventory[managmentState.ProductEnum][0].Price;
            if (num < 0)
            {
                MessageBox.Show($"not enough {Math.Abs(num)}");
                return;
            }
            if (num > 0)
            {
                MessageBox.Show($"the surplus is {num}");

            }
            managmentState.TransitionTo(ProcessState.GetInstance());
            managmentState.HandleCurrentStateAction(form1);


        }


        public override void HandleButton(Form1 form1)
        {
            form1.SelectProduct.Hide();
            form1.ProductList.Hide();
            form1.Bag.Hide();
            form1.Box.Hide();
            form1.Payment.Hide();
            form1.LabelShowProduct.Hide();
            form1.ButtonToProcess.Show();
            form1.MoneyForPay.Show();

        }
    }
}
