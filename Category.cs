using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Campo.Models
{
    public class Category
    {
        [key]
        public int categoryID { get; set; }
        public String categoryName { get; set; }

        public ICollection<Products> productsList { get; set; }

    }
}
