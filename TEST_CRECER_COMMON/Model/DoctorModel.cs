using System;
using System.Collections.Generic;
using System.Text;

namespace TEST_CRECER_COMMON.Model
{
    public class DoctorModel
    {
        public Guid DOCTOR_ID { get; set; }
        public string NOMBRES { get; set; }
        public string APELLIDOS { get; set; }
        public bool ACTIVO { get; set; }
    }
}
