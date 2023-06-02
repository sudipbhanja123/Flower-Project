using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DataAccessLayer
{
    public class ProductGeneralFeature : ProductDimensions
    {
        public string BrandName { get; set; }
        public string ModelNumber { get; set; }
        public string ProductType { get; set; }
        public string CollectionType { get; set; }
        public string ProductColor { get; set; }
        public string ProductShade { get; set; }
        public string ProductFragnance { get; set; }
        public string ProductMaterial { get; set; }
        public string ProductOccasionType { get; set; }
    }

}
