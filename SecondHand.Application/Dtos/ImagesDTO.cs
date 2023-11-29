using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SecondHand.Application.Dtos
{
    public class CreateImagesDTO
    {
        public required string OriginalName { get; set; }
        public required string FileName { get; set; }
        public required string Path { get; set; }
    }
    public class UpdateImagesDTO
    {
        public Guid Id { get; set; }
        public required string OriginalName { get; set; }
        public required string FileName { get; set; }
        public required string Path { get; set; }
    }
}