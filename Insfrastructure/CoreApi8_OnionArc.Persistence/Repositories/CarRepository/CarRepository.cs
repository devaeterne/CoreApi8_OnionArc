using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CoreApi8_OnionArc.Application.Interfaces.CarInterfaces;
using CoreApi8_OnionArc.Domain.Entities;
using CoreApi8_OnionArc.Persistence.Context;
using Microsoft.EntityFrameworkCore;

namespace CoreApi8_OnionArc.Persistence.Repositories.CarRepository
{
    public class CarRepository : ICarRepository
    {
        private readonly CarBookContext _context;
        public CarRepository(CarBookContext context)
        {
            _context = context;
        }

        public int GetCarCount()
        {
            var value = _context.Cars.Count();
            return value;
        }

        public List<Car> GetCarsListWithBrands()
        {
            var values = _context.Cars.Include(x => x.Brand).ToList();
            return values;
        }
        public List<Car> GetLast5CarsWithBrands()
        {
            var values = _context.Cars.Include(x => x.Brand).OrderByDescending(x => x.CarID).Take(5).ToList();
            return values;
        }
    }
}