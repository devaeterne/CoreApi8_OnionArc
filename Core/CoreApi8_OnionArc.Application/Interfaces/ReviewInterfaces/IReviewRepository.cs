using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CoreApi8_OnionArc.Domain.Entities;

namespace CoreApi8_OnionArc.Application.Interfaces.ReviewInterfaces
{
    public interface IReviewRepository
    {
        public List<Review> GetReviewsByCarId(int carId);
    }
}
