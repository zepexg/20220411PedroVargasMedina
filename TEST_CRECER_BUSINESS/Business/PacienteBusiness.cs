using System;
using System.Collections.Generic;
using System.Text;
using TEST_CRECER_BUSINESS.Interfaces;
using TEST_CRECER_COMMON.Model;
using TEST_CRECER_DATA;

namespace TEST_CRECER_BUSINESS
{
    public class PacienteBusiness: IPacientesBusiness
    {
        private IPacienteData _pacienteData;

        public PacienteBusiness(IPacienteData pacienteData)
        {
            _pacienteData = pacienteData;
        }

        public List<PacienteModel> getPacientes(string Nombre, string Apellidos, DateTime? FechaNacimiento, string Sexo)
        {
            try
            {
                return _pacienteData.getPacientes(Nombre, Apellidos, FechaNacimiento, Sexo);
            }
            catch (Exception e)
            {
                throw e;
            }
        }

    }
}
