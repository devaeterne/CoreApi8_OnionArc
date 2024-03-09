using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CoreApi8_OnionArc.Application.Interfaces.ReviewInterfaces;
using CoreApi8_OnionArc.Domain.Entities;
using CoreApi8_OnionArc.Persistence.Context;

namespace CoreApi8_OnionArc.Persistence.Repositories.ReviewRepositories
{
    public class ReviewRepository : IReviewRepository
    {
        private readonly CarBookContext _context;

        public ReviewRepository(CarBookContext context)
        {
            _context = context;
        }

        public List<Review> GetReviewsByCarId(int carId)
        {
            var values = _context.Reviews.Where(x => x.CarID == carId).ToList();
            return values;
        }
    }
}
