using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using SecondHand.Domain.Entities;

namespace SecondHand.Application.Dtos
{
    public class LocationBusinessesDTO
    {
        public Guid LocationId { get; set; }
        public Guid BusinessId { get; set; }
        public Locations Location { get; set; } = null!;
        public Businesses Business { get; set; } = null!;
    }
}