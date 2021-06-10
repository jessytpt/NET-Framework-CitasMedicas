using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public static class PatologiasDAL
    {
        public static string DevuelveSQLListaPatologias()
        {
            return "SELECT * FROM PATOLOGIA ";
        }
    }
}
