using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CoreApi8_OnionArc.Application.Features.Mediator.Result.CarResult
{
    public class GetCarByIdQueryResult
    {
        public int CarID { get; set; }
        public int BrandID { get; set; }
        public string? Model { get; set; }
        public string? CoverIMGUrl { get; set; }
        public int Millage { get; set; }
        public string? Trasmission { get; set; }
        public byte Seat { get; set; }
        public byte Luggage { get; set; }
        public string? Fuel { get; set; }
        public string? BigImageUrl { get; set; }
    }
}