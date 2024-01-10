using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SecondHand.Application.Dtos
{
    public class LocationsReadDTO
    {
        public Guid Id { get; set; }
        public string Name { get; set; } = null!;
        public string? Description { get; set; }
        public string? City { get; set; }
        public string? AdminName { get; set; }
        public string? Country { get; set; }
        public List<LocationBusinessesDTO> LocationBusinesses { get; set; } = new List<LocationBusinessesDTO>();
    }
    public class LocationsCreateDTO
    {
        public string Name { get; set; } = null!;
        public string? Description { get; set; }
        public string? City { get; set; }
        public string? AdminName { get; set; }
        public string? Country { get; set; }
    }
    public class LocationsUpdateDTO
    {
        public Guid Id { get; set; }
        public string Name { get; set; } = null!;
        public string? Description { get; set; }
        public string? City { get; set; }
        public string? AdminName { get; set; }
        public string? Country { get; set; }
    }
}