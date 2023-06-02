using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DataAccessLayer
{
    public class ProductPrice : ProductGeneralFeature
    {
        public string ActualPrice { get; set; }
        public string DiscountPercentage { get; set; }
        public string EffectivePrice { get; set; }
    }

}
