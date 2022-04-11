using System;
using System.Collections.Generic;
using TEST_CRECER_COMMON.Model;

namespace TEST_CRECER_DATA
{
    public interface IPacienteData
    {
        List<PacienteModel> getPacientes(string Nombre, string Apellidos, DateTime? FechaNacimiento, string Sexo);
    }
}
