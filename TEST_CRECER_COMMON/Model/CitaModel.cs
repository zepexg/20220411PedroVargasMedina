using System;
using System.Collections.Generic;
using System.Text;

namespace TEST_CRECER_COMMON.Model
{
    public class CitaModel
    {
        public Guid CITA_ID { get; set; }
        public Guid PACIENTE_ID { get; set; }
        public Guid DOCTOR_ID { get; set; }
        public DateTime FECHA { get; set; }
        public TimeSpan HORA { get; set; }
        public int ESTATUS { get; set; }

    }
}
