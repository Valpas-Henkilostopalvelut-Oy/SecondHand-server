using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SecondHand.Application.Dtos
{
    public class CreateBusinessesDTO
    {
        public Guid CustomerId { get; set; }
        public required string Name { get; set; }
        public string? Description { get; set; }
        public string? WebsiteUrl { get; set; }
        public string? LogoUrl { get; set; }
        public string[]? Images { get; set; }
    }
    public class UpdateBusinessesDTO
    {
        public Guid Id { get; set; }
        public Guid CustomerId { get; set; }
        public string? Name { get; set; }
        public string? Description { get; set; }
        public string? WebsiteUrl { get; set; }
        public string? LogoUrl { get; set; }
        public string[]? Images { get; set; }
    }
}