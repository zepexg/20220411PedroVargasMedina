using System;
using System.Collections.Generic;
using System.Text;

namespace TEST_CRECER_COMMON.Model
{
    public class PacienteModel
    {
        public Guid PACIENTE_ID { get; set; }
        public string NOMBRE { get; set; }
        public string APELLIDOS { get; set; }
        public DateTime FECHA_NACIMIENTO { get; set; }
        public string SEXO { get; set; }
        public bool ACTIVO { get; set; }
    }
}
