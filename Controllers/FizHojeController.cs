using System.Collections.Generic;
using AutoMapper;
using FizHoje.Data;
using FizHoje.Dtos;
using FizHoje.Models;
using Microsoft.AspNetCore.Mvc;
using MockFizHoje.Data;

namespace FizHoje.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class FizHojeController : ControllerBase
    {
        private readonly IFizHojeRepo _repository;
        private readonly IMapper _mapper;

        public FizHojeController(IFizHojeRepo repository, IMapper mapper)
        {
            _repository = repository;
            _mapper = mapper;
        }

        //private readonly MockFizHojeRepo _repository = new MockFizHojeRepo();

        //GET api/FizHoje
        [HttpGet]
        public ActionResult <IEnumerable<FizHojeReadDto>> GetAllFizHoje()
        {
            var fizHojeItems = _repository.GetAllFizHoje();
            
            return Ok(_mapper.Map<IEnumerable<FizHojeReadDto>>(fizHojeItems));
        }

        //GET api/FizHoje/{id}
        [HttpGet("{id}")]
        public ActionResult <FizHojeReadDto> GetFizHojeById(int id)
        {
            var fizHojeItem = _repository.GetFizHojeById(id);

            if (fizHojeItem != null)
            {
                return Ok(_mapper.Map<FizHojeReadDto>(fizHojeItem));
            }

            return NotFound();
        }
    }
}
