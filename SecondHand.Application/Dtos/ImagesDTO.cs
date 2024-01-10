using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SecondHand.Application.Dtos
{
    public class ImagesReadDTO
    {
        public Guid Id { get; set; }
        public string OriginalName { get; set; } = null!;
        public string? FileName { get; set; }
        public string Path { get; set; } = null!;
    }
    public class ImagesCreateDTO
    {
        public string OriginalName { get; set; } = null!;
        public string? FileName { get; set; }
        public string Path { get; set; } = null!;
    }
    public class ImagesUpdateDTO
    {
        public Guid Id { get; set; }
        public string OriginalName { get; set; } = null!;
        public string? FileName { get; set; }
        public string Path { get; set; } = null!;
    }
}