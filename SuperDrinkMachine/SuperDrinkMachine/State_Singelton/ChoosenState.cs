using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SuperDrinkMachine.State
{
    internal class ChoosenState : State
    {
        private static ChoosenState _instance;
        private  ChoosenState()
        {
          
        }
        public static ChoosenState GetInstance()
        {
            if (_instance == null)
            {
                _instance = new ChoosenState();
            }
            return _instance;
        }
        public override void HandleAction(Form1 form1)
        {
            HandleButton(form1);
        }

        public override void HandleButton(Form1 form1)
        {
            form1.SelectProduct.Show();
            form1.ProductList.Show();
            form1.Bag.Show();
            form1.Box.Show();
            form1.Payment.Show();
            form1.ButtonToProcess.Hide();
            form1.MoneyForPay.Hide();
            form1.LabelShowProduct.Hide();
    
        }
    }
}
