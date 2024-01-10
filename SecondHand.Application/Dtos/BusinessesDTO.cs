using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using SecondHand.Domain.Entities;

namespace SecondHand.Application.Dtos
{
    public class BusinessesReadDTO
    {
        public Guid? CustomerId { get; set; }
        public string Name { get; set; }
        public string? Description { get; set; }
        public string? WebsiteUrl { get; set; }
        public string? LogoUrl { get; set; }
        public string[]? Images { get; set; }
        public OpeningHours? OpeningHours { get; set; }
        public List<Contacts>? Contacts { get; set; }
        public List<NotesReadDTO>? Notes { get; set; }
        public Socials? Socials { get; set; }
        // Other properties as needed
        public List<CategoriesBusinessesDTO> CategoriesBusinesses { get; set; } = new List<CategoriesBusinessesDTO>();
        public List<LocationBusinessesDTO> LocationBusinesses { get; set; } = new List<LocationBusinessesDTO>();
        public Guid? TypeId { get; set; }
        public TypesReadDTO? Type { get; set; }
    }
    public class BusinessesCreateDTO
    {
        public Guid? CustomerId { get; set; }
        public string Name { get; set; }
        public string? Description { get; set; }
        public string? WebsiteUrl { get; set; }
        public string? LogoUrl { get; set; }
        public string[]? Images { get; set; }
        public OpeningHours? OpeningHours { get; set; }
        public List<Contacts>? Contacts { get; set; }
        public List<NotesCreateDTO>? Notes { get; set; }
        public Socials? Socials { get; set; }
        // Other properties as needed
        public List<CategoriesBusinessesDTO> CategoriesBusinesses { get; set; } = new List<CategoriesBusinessesDTO>();
        public List<LocationBusinessesDTO> LocationBusinesses { get; set; } = new List<LocationBusinessesDTO>();
        public Guid? TypeId { get; set; }
        public TypesReadDTO? Type { get; set; }
    }
    public class BusinessesUpdateDTO
    {
        public Guid Id { get; set; }
        public Guid? CustomerId { get; set; }
        public string Name { get; set; }
        public string? Description { get; set; }
        public string? WebsiteUrl { get; set; }
        public string? LogoUrl { get; set; }
        public string[]? Images { get; set; }
        public OpeningHours? OpeningHours { get; set; }
        public List<Contacts>? Contacts { get; set; }
        public List<NotesUpdateDTO>? Notes { get; set; }
        public Socials? Socials { get; set; }
        // Other properties as needed
        public List<CategoriesBusinessesDTO> CategoriesBusinesses { get; set; } = new List<CategoriesBusinessesDTO>();
        public List<LocationBusinessesDTO> LocationBusinesses { get; set; } = new List<LocationBusinessesDTO>();
        public Guid? TypeId { get; set; }
        public TypesReadDTO? Type { get; set; }
    }
}