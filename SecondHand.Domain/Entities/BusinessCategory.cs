using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SecondHand.Domain.Entities
{
    public class BusinessCategory
    {
        public int BusinessId { get; set; }
        public int CategoryId { get; set; }
        public Businesses? Business { get; set; }
        public Categories? Category { get; set; }
    }
}