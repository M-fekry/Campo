using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Campo.Models
{
    public class Customer
    {
        public int CustomerId { get; set; }
        public string CustomerName {get;set;}  
        public string Password {get;set;}
        public string Email { get; set; }
        public int VisaNumber {get;set;} 
        public string Phone { get; set; }
        public string Address  {get; set;}

        public List<Order> OrdersList { get; set; }
        public List<Product> productsList { get; set; }
    }
}
