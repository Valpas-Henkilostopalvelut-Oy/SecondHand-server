using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SecondHand.Domain.Entities
{
    public class Categories : BaseEntity
    {
        public string? Name { get; set; }
        public string Image { get; set; }
        public List<Businesses>? Businesses { get; set; }
        public List<BusinessCategory>? BusinessCategories { get; set; }
    }
}