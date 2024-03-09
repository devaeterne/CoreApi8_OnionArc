using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CoreApi8_OnionArc.Domain.Entities;

namespace CoreApi8_OnionArc.Application.Features.Mediator.Result.ReviewResults
{
    public class GetReviewByCarIdQueryResult
    {
        public int ReviewID { get; set; }
        public string CustomerName { get; set; }
        public string CustomerImage { get; set; }
        public string Comment { get; set; }
        public int RaytingValue { get; set; }
        public DateTime ReviewDate { get; set; }
        public int CarID { get; set; }
    }
}
