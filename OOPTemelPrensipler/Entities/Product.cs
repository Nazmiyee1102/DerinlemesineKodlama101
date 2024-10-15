using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPTemelPrensipler
{
    public  class Product
    {
        public int ProductId { get; set; }

        public string ProductName {  get; set; }

        public string Description { get; set; }

        public int StockQuantity { get; set; }

        public double UnitPrice { get; set; }

        internal void SellProduct(int v)
        {
            throw new NotImplementedException();
        }
    }
}
