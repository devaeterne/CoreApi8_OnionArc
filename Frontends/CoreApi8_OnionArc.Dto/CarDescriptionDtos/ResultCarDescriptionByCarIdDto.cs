using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoreApi8_OnionArc.Dto.CarDescriptionDtos
{
    public class ResultCarDescriptionByCarIdDto
    {
        public int CarDescriptionID { get; set; }
        public int CarID { get; set; }
        public string Details { get; set; }
    }
}
