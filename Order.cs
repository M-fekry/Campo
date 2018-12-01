using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Camping.Models
{
    public class Order
    {

        [Key]
        public int OrderID { get; set; }
  
        public int OrderDate { get; set; }
        [Required]
        public int Quantity { get; set; }


        // forgein key customer id 
        public int CustomerID { get; set; }
        public Customer _Customers { get; set; }


        //forgein key product id 
        public int ProductId { get; set; }
        public Product _Prod { get; set; }

    }
}
