using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SecondHand.Application.Dtos
{
    public class CategoriesReadDTO
    {
        public Guid Id { get; set; }
        public string Name { get; set; } = null!;
        public string? Description { get; set; }
        public string? Image { get; set; }
        public List<CategoriesBusinessesDTO> CategoriesBusinesses { get; set; } = new List<CategoriesBusinessesDTO>();
    }
    public class CategoriesCreateDTO
    {
        public string Name { get; set; } = null!;
        public string? Description { get; set; }
        public string? Image { get; set; }
    }
    public class CategoriesUpdateDTO
    {
        public Guid Id { get; set; }
        public string Name { get; set; } = null!;
        public string? Description { get; set; }
        public string? Image { get; set; }
    }
}