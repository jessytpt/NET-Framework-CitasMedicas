using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
using System.Data;

namespace NEGOCIO
{
    public class MedicamentosNegocio
    {
        public DataSet DevolverListaMedicamentos()
        {
            return CargarDatos.CargarListaDatos(MedicamentosDAL.DevuelveSQLMedicamentos());

        }
        public DataSet DevolverListaMedicamentosPorNombre(string nombre)
        {
            return CargarDatos.CargarListaDatos(MedicamentosDAL.DevuelveSQLMedicamentosPorNombre(nombre));

        }

        public DataSet DevolverListaMedicamentosConStoreProcedure()
        {
            return CargarDatos.CargarListaDatosConStoreProcedure(MedicamentosDAL.DevuelveSQLMedicamentosConProcedure());
        }
    }
}
