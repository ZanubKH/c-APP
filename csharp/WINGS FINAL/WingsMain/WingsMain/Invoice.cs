using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DatabaseConnection
{
 public   class Invoice
    {
        public Product Pro { get; set; }
        public int Quantity { get; set; }
        public Invoice(Product pro, int quantity)
        {
            Pro = pro;
            Quantity = quantity;
        }
        public double totalprice()
        {
            double total = this.Pro.Price * this.Quantity;
            return total;

        }
        public override string ToString()
        {
            return Pro + "   " + Quantity;
        }
    }
}
