using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SecondHand.Application.Dtos
{
    public class CategoriesBusinessesDTO
    {
        public Guid CategoryId { get; set; }
        public Guid BusinessId { get; set; }
        public CategoriesReadDTO Category { get; set; } = null!;
        public BusinessesReadDTO Business { get; set; } = null!;
    }
}