using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using SecondHand.Domain.Entities;

namespace SecondHand.Application.Dtos
{
    public class CategoriesBusinessesDTO
    {
        public Guid CategoryId { get; set; }
        public Guid BusinessId { get; set; }
        public Categories Category { get; set; } = null!;
        public Businesses Business { get; set; } = null!;
    }
}