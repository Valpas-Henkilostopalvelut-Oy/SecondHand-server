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
            CreateMap<Customers, ResultDTO>();

            CreateMap<CreateBusinessesDTO, Businesses>();
            CreateMap<UpdateBusinessesDTO, Businesses>();
            CreateMap<Businesses, ResultDTO>();

            CreateMap<CreateCategoriesDTO, Categories>();
            CreateMap<UpdateCategoriesDTO, Categories>();
            CreateMap<Categories, ResultDTO>();

            CreateMap<CreateImagesDTO, Images>();
            CreateMap<UpdateImagesDTO, Images>();
            CreateMap<Images, ResultDTO>();

            CreateMap<CreateOrdersDTO, Orders>();
            CreateMap<UpdateOrdersDTO, Orders>();
            CreateMap<Orders, ResultDTO>();
        }
    }
}