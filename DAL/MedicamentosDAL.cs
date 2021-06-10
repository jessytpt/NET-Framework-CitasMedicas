using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public static class MedicamentosDAL
    {

        public static string DevuelveSQLMedicamentos()
        {
            return "SELECT * FROM MEDICAMENTO";
        }
        public static string DevuelveSQLMedicamentosPorNombre(string parametro)
        {
            return "SELECT NOM_MED FROM MEDICAMENTO WHERE NOM_MED LIKE '" + parametro + "%'";
        }
        public static string DevuelveSQLMedicamentosConProcedure()
        {
            return "SP_DevuelveListaMedicamento";
        }

       
    }
}
