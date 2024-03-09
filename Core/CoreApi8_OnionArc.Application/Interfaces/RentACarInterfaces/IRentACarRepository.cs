using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using CoreApi8_OnionArc.Domain.Entities;

namespace CoreApi8_OnionArc.Application.Interfaces.RentACarInterfaces
{
    public interface IRentACarRepository
    {
        Task<List<RentACar>> GetByFilterAsync(Expression<Func<RentACar, bool>> filter);
    }
}
