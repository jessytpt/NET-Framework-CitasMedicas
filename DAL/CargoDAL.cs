using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public static class CargoDAL
    {
        public static string DevuelveSQLCargos()
        {
            return "SELECT * FROM CARGO_EMPLEADO";
        }
    }
}
