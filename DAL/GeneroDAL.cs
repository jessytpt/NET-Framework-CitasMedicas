using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public static class GeneroDAL
    {
        public static string DevolverListaGenero()
        {
            return "SELECT * FROM GENERO";
        }
    }
}
