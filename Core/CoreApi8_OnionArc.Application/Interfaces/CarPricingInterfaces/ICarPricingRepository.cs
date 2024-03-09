using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CoreApi8_OnionArc.Application.ViewModels;
using CoreApi8_OnionArc.Domain.Entities;

namespace CoreApi8_OnionArc.Application.Interfaces.CarPricingInterfaces
{
    public interface ICarPricingRepository
    {
        List<CarPricing> GetCarPricingWithCars();
        List<CarPricing> GetCarPricingWithTimePeriod();
        List<CarPricingViewModel> GetCarPricingWithTimePeriod1();

    }
}
