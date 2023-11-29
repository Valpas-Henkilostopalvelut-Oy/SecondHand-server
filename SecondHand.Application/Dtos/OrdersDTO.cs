using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SecondHand.Application.Dtos
{
    public class CreateOrdersDTO
    {
        public Guid CustomerId { get; set; }
        public Guid BusinessId { get; set; }
        public DateTime Date { get; set; }
        public int Status { get; set; }
        public int TotalPrice { get; set; }
        public int TotalQuantity { get; set; }
    }
    public class UpdateOrdersDTO
    {
        public Guid Id { get; set; }
        public Guid CustomerId { get; set; }
        public Guid BusinessId { get; set; }
        public DateTime? Date { get; set; }
        public int? Status { get; set; }
        public int? TotalPrice { get; set; }
        public int? TotalQuantity { get; set; }
    }
}