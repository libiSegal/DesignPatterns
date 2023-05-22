using SuperDrinkMachine.State;
using SuperDrinkMachine.TemplateMethod;

namespace SuperDrinkMachine
{
    public partial class Form1 : Form
    {
        
        private TaskSchedulerReport taskSchedulerReport;
        public Stock StockForm { get; set; }
        public ManagmentState ManagmentState { get; set; }
        public ComboBox ProductList;
        public Button Payment;
        public CheckBox Bag;
        public CheckBox Box;
        public Label SelectProduct;
        public Label LabelShowPrice;
        public Label LabelShowProduct;
        public MessageBox Messages;
        public NumericUpDown MoneyForPay;
        public Button ButtonToProcess;
        public Form1(Stock stock)
        {
            InitializeComponent();

            StockForm = stock;
            taskSchedulerReport = new TaskSchedulerReport();
            ProductList = products;
            Payment = patmentButton;
            Box = boxPacking;
            Bag = bagPacking;
            SelectProduct = selecdProduct;
            ButtonToProcess = Toprocess;
            MoneyForPay = numericUpDownToPay;
            LabelShowProduct = showResult;

            List<string> productList = new List<string>();
            for (int i = 0; i < stock.Inventory.Count; i++)
            {
                productList.Add((ProductEnum)i + "  " + stock.Inventory[(ProductEnum)i][0].Price.ToString());
            }
            products.DataSource = productList;

            //use the sate DP;
            ManagmentState = new ManagmentState(ChoosenState.GetInstance(), StockForm);
            ManagmentState.HandleCurrentStateAction(this);

            //use the template method DP;
            taskSchedulerReport.ScheduleTask(00, 59, 00,
           () => { ReportTxtSaver.WriteReport(); });
        }

        private void Toprocess_Click(object sender, EventArgs e)
        {
            //use the sate DP;
            ManagmentState.HandleCurrentStateAction(this);
        }
        private void patmentButton_Click(object sender, EventArgs e)
        {
            //use the sate DP;
            ManagmentState.TransitionTo(PaymentState.GetInstance());
            ManagmentState.ProductEnum = (ProductEnum)products.SelectedIndex;
            ManagmentState.HandleCurrentStateButton(this);

        }

        private void products_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void selecdProduct_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void moneyForPay_ValueChanged(object sender, EventArgs e)
        {


        }


        private void numericUpDownToPay_ValueChanged(object sender, EventArgs e)
        {



        }
    }
}