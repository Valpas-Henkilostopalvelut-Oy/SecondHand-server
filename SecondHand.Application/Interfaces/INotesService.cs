using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using SecondHand.Application.Dtos;
using SecondHand.Domain.Entities;

namespace SecondHand.Application.Interfaces
{
    public interface INotesService : IBaseService<Notes, NotesCreateDTO, NotesUpdateDTO>
    {
        
    }
}