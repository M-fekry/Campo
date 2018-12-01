using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Camping.Models
{
    public class Product_customer
    {
        public int ProductId { get; set; }
        //navigation
        public Product _product { get; set; }

        public int CustomerId { get; set;  }
        //navigation
        public Customer _cust { get; set; }

    }
}
