using OOPTemelPrensipler.Entities;

namespace OOPTemelPrensipler
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Product product = new Product()
            {
                ProductId = 1,
                ProductName = "Iphone 14 Pro Max",
                Description = "Elektronik",
                StockQuantity = 15,
                UnitPrice = 8500
            };

            product.SellProduct(1);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Customer customer1 = new Customer();


        }
    }
}
