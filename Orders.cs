using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CampProj.Models
{
    public class Orders
    {
        [key]
        public int Order_ID { get; set; }
        public int prod_ID { get; set; }
        public int order_date { get; set; }
        [required]
        public int Quant { get; set; }


        // forgein key cutomer id 
        public int CustomerID { get; set; }
        public  Customers _Customers  {get; set; }


          //forgein key product id 
         public int ProductId { get; set; }
         public  products _Prod { get; set; }

    }
}
