using AutoMapper;
using SecondHand.Application.Dtos;
using SecondHand.Domain.Entities;

namespace SecondHand.WebApi.Configuration
{
    public class MapperProfile : Profile
    {
        public MapperProfile()
        {
            CreateMap<CreateCustomersDTO, Customers>();
            CreateMap<UpdateCustomersDTO, Customers>();

            CreateMap<CreateBusinessesDTO, Businesses>();
            CreateMap<UpdateBusinessesDTO, Businesses>();

            CreateMap<CreateCategoriesDTO, Categories>();
            CreateMap<UpdateCategoriesDTO, Categories>();

            CreateMap<CreateLocationsDTO, Locations>();
            CreateMap<UpdateLocationsDTO, Locations>();

            CreateMap<CreateImagesDTO, Images>();
            CreateMap<UpdateImagesDTO, Images>();

            CreateMap<CreateOpeningHoursDTO, OpeningHours>();
            CreateMap<UpdateOpeningHoursDTO, OpeningHours>();

            CreateMap<CreateSocialsDTO, Socials>();
            CreateMap<UpdateSocialsDTO, Socials>();

            CreateMap<CreateNotesDTO, Notes>();
            CreateMap<UpdateNotesDTO, Notes>();

            CreateMap<CreateOrdersDTO, Orders>();
            CreateMap<UpdateOrdersDTO, Orders>();
        }
    }
}