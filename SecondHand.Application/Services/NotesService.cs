using AutoMapper;
using SecondHand.Application.Dtos;
using SecondHand.Application.Interfaces;
using SecondHand.Domain.Entities;
using SecondHand.Domain.Interfaces;

namespace SecondHand.Application.Services
{
    public class NotesService : BaseService<Notes, NotesReadDTO, NotesCreateDTO, NotesUpdateDTO>, INotesService
    {
        public NotesService(IBaseEntity<Notes> baseEntity, IMapper mapper) : base(baseEntity, mapper)
        {
        }
    }
}