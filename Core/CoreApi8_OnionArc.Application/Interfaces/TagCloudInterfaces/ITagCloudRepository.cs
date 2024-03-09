using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CoreApi8_OnionArc.Domain.Entities;

namespace CoreApi8_OnionArc.Application.Interfaces.TagCloudInterfaces
{
    public interface ITagCloudRepository
    {
        List<TagCloud> GetTagCloudsByBlogID(int id);
    }
}
