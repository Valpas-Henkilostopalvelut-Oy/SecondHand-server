using AutoMapper;
using SecondHand.Application.Dtos;
using SecondHand.Application.Interfaces;
using SecondHand.Domain.Entities;
using SecondHand.Domain.Interfaces;

namespace SecondHand.Application.Services
{
    public class NotesService : INotesService
    {
        private readonly INotes _notes;
        private readonly IMapper _mapper;
        public NotesService(INotes notes, IMapper mapper)
        {
            _notes = notes;
            _mapper = mapper;
        }

        public Task<Notes> CreateOne(NotesCreateDTO dto)
        {
            throw new NotImplementedException();
        }

        public Task<bool> DeleteOneById(Guid id)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<Notes>> GetAll()
        {
            throw new NotImplementedException();
        }

        public Task<Notes> GetOneById(Guid id)
        {
            throw new NotImplementedException();
        }

        public Task<Notes> UpdateOneById(Guid id, NotesUpdateDTO updated)
        {
            throw new NotImplementedException();
        }
    }
}