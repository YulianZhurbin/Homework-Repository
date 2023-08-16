using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdditionalTask.Model
{
    public class Sale
    {
        public string Product { get; set; }
        public string Buyer { get; set; }

        public Sale(string product, string buyer)
        {
            Product = product;
            Buyer = buyer;
        }
    }
}
