using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SecondHand.Application.Dtos
{
    public class CreateOpeningHoursDTO
    {
        public required Guid BusinessId { get; set; }
        public required string Day { get; set; }
        public required string OpenTime { get; set; }
        public required string CloseTime { get; set; }
        public required bool IsClosed { get; set; }
        public required string Type { get; set; }
    }
    public class UpdateOpeningHoursDTO
    {
        public Guid Id { get; set; }
        public Guid BusinessId { get; set; }
        public string? Day { get; set; }
        public string? OpenTime { get; set; }
        public string? CloseTime { get; set; }
        public bool? IsClosed { get; set; }
        public string? Type { get; set; }
    }
}