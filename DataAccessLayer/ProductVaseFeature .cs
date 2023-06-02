using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DataAccessLayer
{
   public class ProductVaseFeature : ProductPrice
    {
        public string VaseIncluded { get; set; }
        public string VaseMaterial { get; set; }
    }


}
