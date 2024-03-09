using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using CoreApi8_OnionArc.Domain.Entities;

namespace CoreApi8_OnionArc.Application.Interfaces.AppUserInterfaces
{
    public interface IAppUserRepository
    {
        Task<List<AppUser>> GetByFilterAsync(Expression<Func<AppUser, bool>> filter);
    }
}
