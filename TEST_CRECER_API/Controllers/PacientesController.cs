using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TEST_CRECER_BUSINESS.Interfaces;

namespace TEST_CRECER_API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PacientesController : ControllerBase
    {

        private readonly IPacientesBusiness _pacienteBusiness;

        public PacientesController(IPacientesBusiness pacienteBusiness) => _pacienteBusiness = pacienteBusiness;

        [HttpGet("getPacientes")]
        public ActionResult Get(string Nombre, string Apellidos, DateTime? FechaNacimiento, string Sexo)
        {
            var res = _pacienteBusiness.getPacientes(Nombre, Apellidos, FechaNacimiento, Sexo);
            return Ok(res);
        }
    }
}
