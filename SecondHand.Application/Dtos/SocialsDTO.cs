using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SecondHand.Application.Dtos
{
    public class CreateSocialsDTO
    {
        public Guid BusinessId { get; set; }
        public string? Facebook { get; set; }
        public string? Twitter { get; set; }
        public string? Instagram { get; set; }
        public string? Youtube { get; set; }
        public string? Tiktok { get; set; }
    }
    public class UpdateSocialsDTO
    {
        public Guid Id { get; set; }
        public Guid BusinessId { get; set; }
        public string? Facebook { get; set; }
        public string? Twitter { get; set; }
        public string? Instagram { get; set; }
        public string? Youtube { get; set; }
        public string? Tiktok { get; set; }
    }
}