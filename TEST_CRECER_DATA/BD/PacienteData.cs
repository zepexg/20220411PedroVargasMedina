using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using TEST_CRECER_COMMON.Model;

namespace TEST_CRECER_DATA
{
    public class PacienteData: IPacienteData
    {
        private IConfiguration _config ;
        public PacienteData(IConfiguration config)
        {
            _config = config;
        }

        public List<PacienteModel> getPacientes(string Nombre, string Apellidos, DateTime? FechaNacimiento, string Sexo)
        {
            List <PacienteModel> res = new List<PacienteModel>();
            using (var cnn = new SqlConnection(_config.GetConnectionString("test_crecer")))
            {
                string query = "SP_GET_PACIENTE ";
                using (var cmm = new SqlCommand(query, cnn))
                {
                    if(!string.IsNullOrEmpty(Nombre))
                        cmm.Parameters.Add("@NOMBRE", SqlDbType.VarChar).Value = Nombre;
                    if (!string.IsNullOrEmpty(Apellidos))
                        cmm.Parameters.Add("@APELLIDOS", SqlDbType.VarChar).Value = Apellidos;
                    if (FechaNacimiento != null)
                        cmm.Parameters.Add("@FECHA_NACIMIENTO", SqlDbType.VarChar).Value = FechaNacimiento?.ToString("yyyy-MM-dd");
                    if (!string.IsNullOrEmpty(Sexo))
                        cmm.Parameters.Add("@SEXO", SqlDbType.VarChar).Value = Sexo;
                    cnn.Open();
                    cmm.CommandType = System.Data.CommandType.StoredProcedure;
                    cmm.CommandTimeout = 300;
                    using (var reader = cmm.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            PacienteModel p = new PacienteModel();
                            p.PACIENTE_ID = Guid.Parse(Convert.ToString(reader["PACIENTE_ID"]));
                            p.NOMBRE = Convert.ToString(reader["NOMBRE"]);
                            p.APELLIDOS = Convert.ToString(reader["APELLIDOS"]);
                            p.FECHA_NACIMIENTO = Convert.ToDateTime(reader["FECHA_NACIMIENTO"]);
                            p.SEXO = Convert.ToString(reader["SEXO"]);
                            res.Add(p);
                        }
                    }
                }
            }
            return res;
        }
    }
}
