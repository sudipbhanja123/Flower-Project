using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DataAccessLayer
{
    public class ProductDetails:Product
    {
        public string ProductNameOrTitle { get; set; }
        public string ProductDescription { get; set; }
        public string AdminId { get; set; }
        public DateTime ProductRegistrationDate { get; set; }

    }
}
