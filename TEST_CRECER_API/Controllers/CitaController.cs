using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TEST_CRECER_BUSINESS.Interfaces;
using TEST_CRECER_COMMON.Model;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace TEST_CRECER_API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CitaController : ControllerBase
    {

        private readonly ICitaBusiness _CitaBusiness;

        public CitaController(ICitaBusiness citaBusiness) => _CitaBusiness = citaBusiness;
        [HttpPost]
        public ActionResult Post([FromBody] CitaModel model)
        {
            try
            {
                _CitaBusiness.addCita(model);
                return Ok();
            }
            catch (Exception e)
            {
                return BadRequest(e);
            }
        }
    }
}
