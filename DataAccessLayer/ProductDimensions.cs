using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DataAccessLayer
{
    public class ProductDimensions:ProductAdditionalFeature
    {
        public string TotalLength { get; set; }
        public string OtherDimensions { get; set; }
    }

}
