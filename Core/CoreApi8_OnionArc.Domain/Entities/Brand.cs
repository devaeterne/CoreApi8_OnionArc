using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CoreApi8_OnionArc.Domain.Entities
{
    public class Brand
    {
        public int BrandID { get; set; }
        public int BrandName { get; set; }
        public List<Car> Cars { get; set; }
    }
}