using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SecondHand.Application.Dtos
{
    public class LocationBusinessesDTO
    {
        public Guid LocationId { get; set; }
        public Guid BusinessId { get; set; }
        public LocationsReadDTO Location { get; set; } = null!;
        public BusinessesReadDTO Business { get; set; } = null!;
    }
}