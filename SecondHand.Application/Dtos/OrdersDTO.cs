using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SecondHand.Application.Dtos
{
    public class OrdersCreateDTO
    {
        public Guid CustomerId { get; set; }
        public Guid BusinessesId { get; set; }
        public DateTime? Date { get; set; }
        public int? Status { get; set; }
        public int? TotalPrice { get; set; }
    }
    public class OrdersUpdateDTO
    {
        public Guid Id { get; set; }
        public Guid CustomerId { get; set; }
        public Guid BusinessesId { get; set; }
        public DateTime? Date { get; set; }
        public int? Status { get; set; }
        public int? TotalPrice { get; set; }
    }
}