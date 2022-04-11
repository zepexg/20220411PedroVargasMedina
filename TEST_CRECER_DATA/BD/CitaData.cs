using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Text;
using TEST_CRECER_COMMON.Model;
using TEST_CRECER_DATA.Interfaces;

namespace TEST_CRECER_DATA.BD
{
    public class CitaData : ICitaData
    {
        private IConfiguration _config;
        public CitaData(IConfiguration config)
        {
            _config = config;
        }
        public void addCita(CitaModel model)
        {
            try
            {
                using (var cnn = new SqlConnection(_config.GetConnectionString("test_crecer")))
                {
                    string query = "SP_ADD_CITA ";
                    using (var cmm = new SqlCommand(query, cnn))
                    {
                        if (model.PACIENTE_ID != null)
                            cmm.Parameters.Add("@PACIENTE_ID", SqlDbType.UniqueIdentifier).Value = model.PACIENTE_ID;
                        if (model.DOCTOR_ID != null)
                            cmm.Parameters.Add("@DOCTOR_ID", SqlDbType.UniqueIdentifier).Value = model.DOCTOR_ID;
                        if (model.FECHA != null)
                            cmm.Parameters.Add("@FECHA", SqlDbType.Date).Value = model.FECHA?.ToString("yyyy-MM-dd");
                        if (string.IsNullOrEmpty(model.HORA))
                            cmm.Parameters.Add("@HORA", SqlDbType.Time).Value = model.HORA;
                        cnn.Open();
                        cmm.CommandType = System.Data.CommandType.StoredProcedure;
                        cmm.CommandTimeout = 300;
                        int row = cmm.ExecuteNonQuery();
                        if (row == 0) throw new Exception("No se registro la cita"); 
                    }
                }
            }
            catch (Exception e)
            {
                throw e;
            }
        }
    }
}
