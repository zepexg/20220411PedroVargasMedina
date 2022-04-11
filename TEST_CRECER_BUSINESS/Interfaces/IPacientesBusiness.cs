using System;
using System.Collections.Generic;
using System.Text;
using TEST_CRECER_COMMON.Model;

namespace TEST_CRECER_BUSINESS.Interfaces
{
    public interface IPacientesBusiness
    {
        List<PacienteModel> getPacientes(string Nombre, string Apellidos, DateTime? FechaNacimiento, string Sexo);
    }
}
