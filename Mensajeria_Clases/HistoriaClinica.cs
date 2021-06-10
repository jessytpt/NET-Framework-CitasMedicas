using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mensajeria_Clases
{
    public class HistoriaClinica : Persona
    {

        public string Direccion { get; set; }
        public string Telefono { get; set; }
        public string Ocupacion { get; set; }
        public string Patologias { get; set; }
        public string Traumatismos { get; set; }
        public string Quirurgicos { get; set; }
        public string MedicamentosQueUsa { get; set; }
        public string Habitos { get; set; }
        public string AlergiaMedicamentos { get; set; }
        public string OtrasAlergias { get; set; }
        public int NumHistoriaClinica { get; set; }

        public HistoriaClinica()
        {

        }

        public HistoriaClinica(string ced, string nom1, string nom2, string ape1, string ape2, string fech_nac, string direccion, string telef, string codCiudad, string estadoCivil, string etnia, int genero, string ocupacion, string patologias, string traumatismos, string medicamUsa, string quirurgico, string habito, string alergMed, string otrasAlerg)
        {
            this.Cedula = ced;
            this.Nombre1 = nom1;
            this.Nombre2 = nom2;
            this.Apellido1 = ape1;
            this.Apellido2 = ape2;
            this.Fecha_Nacimiento = fech_nac;
            this.Direccion = direccion;
            this.Telefono = telef;
            this.Cod_Ciudad= codCiudad;
            this.EstadoCivil = estadoCivil;
            this.Etnia= etnia;
            this.Ocupacion = ocupacion;
            this.Genero = genero;
            this.Patologias = patologias;
            this.Traumatismos = traumatismos;
            this.MedicamentosQueUsa = medicamUsa;
            this.Quirurgicos = quirurgico;
            this.Habitos = habito;
            this.AlergiaMedicamentos = alergMed;
            this.OtrasAlergias = otrasAlerg;

        }
    }
}
