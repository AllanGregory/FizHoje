using System.Collections.Generic;
using FizHoje.Data;
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

        public FizHojeController(IFizHojeRepo repository)
        {
            _repository = repository;
        }

        //private readonly MockFizHojeRepo _repository = new MockFizHojeRepo();

        //GET api/FizHoje
        [HttpGet]
        public ActionResult <IEnumerable<FizHojeModel>> GetAllFizHoje()
        {
            return Ok(_repository.GetAllFizHoje());
        }

        //GET api/FizHoje/{id}
        [HttpGet("{id}")]
        public ActionResult <FizHojeModel> GetFizHojeById(int id)
        {
            return Ok(_repository.GetFizHojeById(id));
        }
    }
}
