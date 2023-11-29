using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SecondHand.Application.Dtos
{
    public class CreateNotesDTO
    {
        public required Guid CustomerId { get; set; }
        public required Guid BusinessId { get; set; }
        public required string NoteText { get; set; }
    }
    public class UpdateNotesDTO
    {
        public Guid Id { get; set; }
        public Guid CustomerId { get; set; }
        public Guid BusinessId { get; set; }
        public string? NoteText { get; set; }
    }
}