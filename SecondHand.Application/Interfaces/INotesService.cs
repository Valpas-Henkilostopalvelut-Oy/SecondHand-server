using SecondHand.Application.Dtos;
using SecondHand.Domain.Entities;

namespace SecondHand.Application.Interfaces
{
    public interface INotesService : IBaseService<Notes, CreateNotesDTO, UpdateNotesDTO, ResultDTO>
    {
        // Get all notes on business
        Task<IEnumerable<Notes>> GetNotesOnBusinessAsync(Guid businessId);
        // Get all notes on customer
        Task<IEnumerable<Notes>> GetNotesOnCustomerAsync(Guid customerId);
        Task<ResultDTO> SetNoteOnBusinessAsync(Guid businessId, Guid noteId);
    }
}