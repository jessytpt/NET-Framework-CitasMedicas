using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
using Mensajeria_Clases;
using System.Data;

namespace NEGOCIO
{
    public class PatologiasNegocio
    {
        public DataSet DevolverListaPatologias()
        {
            return CargarDatos.CargarListaDatos(PatologiasDAL.DevuelveSQLListaPatologias());
        }
    }
}
