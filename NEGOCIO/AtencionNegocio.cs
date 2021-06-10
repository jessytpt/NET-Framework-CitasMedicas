using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
using System.Data;
using Mensajeria_Clases;

namespace NEGOCIO
{
    public class AtencionNegocio
    {
        public static Atencion GuardarAtencion(Atencion nuevaAtencion)
        {
            Atencion ms = new Atencion();
            ms = AtencionDal.Guardar(nuevaAtencion);
            return ms;

        }

        public static Tratamiento GuardarTratamiento(Tratamiento nuevoTratamiento)
        {
            Tratamiento ms = new Tratamiento();
            ms = AtencionDal.GuardarTratamiento(nuevoTratamiento);
            return ms;

        }
    }
}
