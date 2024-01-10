using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SecondHand.Application.Dtos
{
    public class OrdersReadDTO
    {
        public Guid Id { get; set; }
        public Guid CustomerId { get; set; }
        public CustomersReadDTO Customer { get; set; } = null!;
        public Guid BusinessesId { get; set; }
        public BusinessesReadDTO Businesses { get; set; } = null!;
        public DateTime Date { get; set; }
        public int Status { get; set; }
        public int TotalPrice { get; set; }
    }
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