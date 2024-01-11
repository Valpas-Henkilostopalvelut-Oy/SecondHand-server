using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using SecondHand.Application.Dtos;
using SecondHand.Application.Interfaces;
using SecondHand.Domain.Entities;

namespace SecondHand.WebApi.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class NotesController : CrudController<Notes, NotesCreateDTO, NotesUpdateDTO>
    {
        private readonly INotesService _notes;
        public NotesController(INotesService notes) : base(notes)
        {
            _notes = notes;
        }
    }
}