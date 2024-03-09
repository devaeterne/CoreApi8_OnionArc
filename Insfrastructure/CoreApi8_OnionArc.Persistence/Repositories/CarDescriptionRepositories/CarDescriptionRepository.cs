using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CoreApi8_OnionArc.Application.Interfaces.CarDescriptionInterfaces;
using CoreApi8_OnionArc.Domain.Entities;
using CoreApi8_OnionArc.Persistence.Context;

namespace CoreApi8_OnionArc.Persistence.Repositories.CarDescriptionRepositories
{
    public class CarDescriptionRepository : ICarDescriptionRepository
    {
        private readonly CarBookContext _context;

        public CarDescriptionRepository(CarBookContext context)
        {
            _context = context;
        }

        async Task<CarDescription> ICarDescriptionRepository.GetCarDescription(int carId)
        {
            var values = await _context.CarDescriptions.Where(x => x.CarID == carId).FirstOrDefaultAsync();
            return values;
        }
    }
}
