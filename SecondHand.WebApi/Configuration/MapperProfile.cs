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

            CreateMap<CreateImagesDTO, Images>();
            CreateMap<UpdateImagesDTO, Images>();

            CreateMap<CreateOrdersDTO, Orders>();
            CreateMap<UpdateOrdersDTO, Orders>();
        }
    }
}