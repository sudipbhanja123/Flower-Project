using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DataAccessLayer
{
    public class ProductDefaultImage : ProductVaseFeature
    {
        public string ProductImageId { get; set; }
        public byte[] IsDefaultImage { get; set; }
        public byte[] ProductImage { get; set; }


    }
}
