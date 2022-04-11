using System;
using System.Collections.Generic;
using System.Text;
using TEST_CRECER_BUSINESS.Interfaces;
using TEST_CRECER_COMMON.Model;
using TEST_CRECER_DATA.Interfaces;

namespace TEST_CRECER_BUSINESS.Business
{
    public class CitaBusiness : ICitaBusiness
    {
        private ICitaData _citaData;

        public CitaBusiness(ICitaData citaData)
        {
            _citaData = citaData;
        }
        public void addCita(CitaModel model)
        {
            try
            {
                _citaData.addCita(model);
            }
            catch (Exception e)
            {

            }
        }
    }
}
