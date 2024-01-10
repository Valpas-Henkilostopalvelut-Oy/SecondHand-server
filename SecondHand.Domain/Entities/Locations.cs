using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SecondHand.Domain.Entities
{
    public class Locations : BaseEntity
    {
        public string Name { get; set; } = null!;
        public string? Description { get; set; }
        public string? City { get; set; }
        public string? AdminName { get; set; }
        public string? Country { get; set; }
        public List<LocationBusinesses> LocationBusinesses { get; set; } = new List<LocationBusinesses>();
    }
}