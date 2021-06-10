using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mensajeria_Clases
{
    public class Empleado:Persona
    {
        public string Direccion { get; set; }
        public string Telefono { get; set; }
        public string Cargo { get; set; }
        public string NomUsuario { get; set; }
        public string Clave { get; set; }
        public string TipoUsuario { get; set; }

        public Empleado()
        {

        }

        public Empleado(string ced, string nom1, string nom2, string ape1, string ape2, string fech_nac, string direccion, string telef,string cargo, string codCiudad, string estadoCivil, string etnia, int genero, string nom_usuario,string clave, string tipoUsuario)
        {
            this.Cedula = ced;
            this.Nombre1 = nom1;
            this.Nombre2 = nom2;
            this.Apellido1 = ape1;
            this.Apellido2 = ape2;
            this.Fecha_Nacimiento = fech_nac;
            this.Direccion = direccion;
            this.Telefono = telef;
            this.Cod_Ciudad = codCiudad;
            this.EstadoCivil = estadoCivil;
            this.Etnia = etnia;
            this.NomUsuario = nom_usuario;
            this.Clave = clave;
            this.Cargo = cargo;
            this.Genero = genero;
            this.TipoUsuario = tipoUsuario;

        }


    }
}
