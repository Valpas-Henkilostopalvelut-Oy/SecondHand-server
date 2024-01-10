using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SecondHand.Application.Dtos
{
    public class CustomersReadDTO
    {
        public Guid Id { get; set; }
        public string Name { get; set; } = null!;
        public string? Email { get; set; }
        public string? Phone { get; set; }
        public string? Image { get; set; }
        public List<BusinessesReadDTO> Businesses { get; set; } = new List<BusinessesReadDTO>();
    }
    public class CustomersCreateDTO
    {
        public string Name { get; set; } = null!;
        public string? Email { get; set; }
        public string? Phone { get; set; }
        public string? Image { get; set; }
    }
    public class CustomersUpdateDTO
    {
        public Guid Id { get; set; }
        public string Name { get; set; } = null!;
        public string? Email { get; set; }
        public string? Phone { get; set; }
        public string? Image { get; set; }
    }
}