using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SecondHand.Domain.Entities
{
    public class CategoriesBusinesses : BaseEntity
    {
        public Guid CategoryId { get; set; }
        public Guid BusinessId { get; set; }
        public Categories Category { get; set; } = null!;
        public Businesses Business { get; set; } = null!;
    }
}