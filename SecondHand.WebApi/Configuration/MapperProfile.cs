using AutoMapper;
using SecondHand.Application.Dtos;
using SecondHand.Domain.Entities;

namespace SecondHand.WebApi.Configuration
{
    public class MapperProfile : Profile
    {
        public MapperProfile()
        {
            CreateMap<BusinessesCreateDTO, Businesses>();
            CreateMap<BusinessesUpdateDTO, Businesses>();

            CreateMap<CategoriesCreateDTO, Categories>();
            CreateMap<CategoriesUpdateDTO, Categories>();

            CreateMap<CustomersCreateDTO, Customers>();
            CreateMap<CustomersUpdateDTO, Customers>();

            CreateMap<LocationsCreateDTO, Locations>();
            CreateMap<LocationsUpdateDTO, Locations>();

            CreateMap<NotesCreateDTO, Notes>();
            CreateMap<NotesUpdateDTO, Notes>();

            CreateMap<OrdersCreateDTO, Orders>();
            CreateMap<OrdersUpdateDTO, Orders>();

            CreateMap<TypesCreateDTO, Types>();
            CreateMap<TypesUpdateDTO, Types>();
        }
    }
}