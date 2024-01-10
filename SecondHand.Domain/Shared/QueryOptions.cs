using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using SecondHand.Domain.Entities;

namespace SecondHand.Domain.Shared
{
    public class QueryOptions
    {
        public int Page { get; set; } = 1;
        public int PageSize { get; set; } = 10;
        public string? Search { get; set; } 
        public string? OrderBy { get; set; }
        public int OpenOn { get; set; } = 0;
        public Types? Type { get; set; }
        public Categories? Category { get; set; }
        public string? AdminName { get; set; }
        public string? City { get; set; }
    }
}