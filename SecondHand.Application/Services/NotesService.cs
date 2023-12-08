using AutoMapper;
using SecondHand.Application.Dtos;
using SecondHand.Application.Interfaces;
using SecondHand.Domain.Entities;
using SecondHand.Domain.Interfaces;

namespace SecondHand.Application.Services
{
    public class NotesService : BaseService<Notes, CreateNotesDTO, UpdateNotesDTO>, INotesService
    {
        private readonly INotes _notes;
        private readonly IBusinesses _businesses;
        private readonly ICustomers _customers;
        public NotesService(INotes notes, IMapper mapper, IBusinesses businesses, ICustomers customers) : base(notes, mapper)
        {
            _notes = notes;
            _businesses = businesses;
            _customers = customers;
        }

        public async Task<IEnumerable<Notes>> GetNotesOnBusinessAsync(Guid businessId)
        {
            var business = await _businesses.GetById(businessId);
            if (business == null)
            {
                throw new Exception("Business not found");
            }
            return business.Notes!;
        }

        public async Task<IEnumerable<Notes>> GetNotesOnCustomerAsync(Guid customerId)
        {
            var customer = await _customers.GetById(customerId);
            if (customer == null)
            {
                throw new Exception("Customer not found");
            }
            return customer.Notes!;
        }

        public async Task<ResultDTO> SetNoteOnBusinessAsync(Guid businessId, Guid noteId)
        {
            var business = await _businesses.GetById(businessId);
            if (business == null)
            {
                throw new Exception("Business not found");
            }
            var note = await _notes.GetById(noteId);
            if (note == null)
            {
                throw new Exception("Note not found");
            }
            business.Notes!.Add(note);
            await _businesses.Update(business);
            return ResultDTO.Success;
        }
    }
}