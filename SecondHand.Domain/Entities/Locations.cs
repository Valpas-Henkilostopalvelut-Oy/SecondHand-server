using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace SecondHand.Domain.Entities
{
    public class Locations : BaseEntity
    {
        public string Name { get; set; }
        [ForeignKey("Id")]
        public Guid? BusinessId { get; set; }
        public Businesses? Business { get; set; }
        public string Driveto { get; set; }
        public string Iframe { get; set; }
        public int ZipCode { get; set; }
        public string? Address { get; set; }
        public string? City { get; set; }
        public string? AdminName { get; set; }
        public string? Country { get; set; }
    }
}