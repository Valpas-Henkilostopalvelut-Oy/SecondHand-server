using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SecondHand.Domain.Entities
{
    public class BusinessOrder
    {
        public Guid BusinessId { get; set; }
        public Guid OrderId { get; set; }
        public Businesses Business { get; set; }
        public Orders Order { get; set; }
    }
}