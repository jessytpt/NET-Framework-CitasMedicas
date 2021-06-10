using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
using System.Data;

namespace NEGOCIO
{
    public class GeneroNegocio
    {
        public DataSet DevolverListaGenero()
        {
            return CargarDatos.CargarListaDatos(GeneroDAL.DevolverListaGenero());
        }
    }
}
