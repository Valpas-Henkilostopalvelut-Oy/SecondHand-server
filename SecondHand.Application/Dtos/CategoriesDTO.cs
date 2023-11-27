using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SecondHand.Application.Dtos
{
    public class UpdateCategoriesDTO
    {
        public required string Name { get; set; }
        public required string Description { get; set; }
        public required string Image { get; set; }
    }

    public class CreateCategoriesDTO
    {
        public required string Name { get; set; }
        public string? Description { get; set; }
        public string? Image { get; set; }
    }
}