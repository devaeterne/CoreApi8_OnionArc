using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CoreApi8_OnionArc.Domain.Entities
{
    public class SocialMedia
    {
        public int SocialMediaID { get; set; }
        public string? Name { get; set; }
        public string? Url { get; set; }
        public string? IconUrl { get; set; }
    }
}