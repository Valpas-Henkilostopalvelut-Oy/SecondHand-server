using SecondHand.Application.Dtos;
using SecondHand.Domain.Entities;

namespace SecondHand.Application.Interfaces
{
    public interface IImagesService : IBaseService<Images, ImagesCreateDTO, ImagesUpdateDTO>
    { }
}