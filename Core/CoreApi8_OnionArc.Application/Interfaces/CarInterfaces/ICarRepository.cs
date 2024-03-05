using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CoreApi8_OnionArc.Domain.Entities;

namespace CoreApi8_OnionArc.Application.Interfaces.CarInterfaces
{
    public interface ICarRepository
    {
        List<Car> GetCarsListWithBrands();
        List<Car> GetLast5CarsWithBrands();
        int GetCarCount();
    }
}