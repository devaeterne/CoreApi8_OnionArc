using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using CoreApi8_OnionArc.Application.Interfaces.RentACarInterfaces;
using CoreApi8_OnionArc.Domain.Entities;
using CoreApi8_OnionArc.Persistence.Context;

namespace CoreApi8_OnionArc.Persistence.Repositories.RentACarRepositories
{
    public class RentACarRepository : IRentACarRepository
    {
        private readonly CarBookContext _context;
        public RentACarRepository(CarBookContext context)
        {
            _context = context;
        }
        public async Task<List<RentACar>> GetByFilterAsync(Expression<Func<RentACar, bool>> filter)
        {
            var values = await _context.RentACars.Where(filter).Include(x => x.Car).ThenInclude(y => y.Brand).ToListAsync();
            return values;
        }
    }
}
//var values = _context.CarPricings.Include(x => x.Car).ThenInclude(y => y.Brand).Include(x => x.Pricing).Where(z => z.PricingID == 2).ToList();