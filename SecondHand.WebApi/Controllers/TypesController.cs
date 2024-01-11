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
    public class TypesController : CrudController<Types, TypesCreateDTO, TypesUpdateDTO>
    {
        private readonly ITypesService _types;
        public TypesController(ITypesService types) : base(types)
        {
            _types = types;
        }
    }
}