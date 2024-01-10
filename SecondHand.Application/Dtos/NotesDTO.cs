using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SecondHand.Application.Dtos
{
    public class NotesReadDTO
    {
        public Guid Id { get; set; }
        public Guid CustomerId { get; set; }
        public Guid BusinessId { get; set; }
        public string Text { get; set; } = null!;
    }
    public class NotesCreateDTO
    {
        public Guid CustomerId { get; set; }
        public Guid BusinessId { get; set; }
        public string Text { get; set; } = null!;
    }
    public class NotesUpdateDTO
    {
        public Guid Id { get; set; }
        public Guid CustomerId { get; set; }
        public Guid BusinessId { get; set; }
        public string? Text { get; set; }
    }
}