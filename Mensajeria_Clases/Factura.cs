using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mensajeria_Clases
{
    public class Factura
    {
        public string NumFactura { get; set; }
        public string NumAtencion { get; set; }
        public string Fecha { get; set; }
        public string NombreCliente { get; set; }
        public string TelefonoCliente { get; set; }
        public string DireccionCliente { get; set; }
        public string DescripcionFactura { get; set; }
        public float TotalPagoFactura { get; set; }

        public Factura()
        {

        }
    }
}
