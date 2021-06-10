using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using NEGOCIO;
using Mensajeria_Clases;

namespace WindowsFormsAppCliente
{
    public partial class FormBuscarCita : Form
    {
        public FormBuscarCita()
        {
            InitializeComponent();
        }

        public string NumCita { get; set; }
        public string NomPaciente { get; set; }


        private void Inicio()
        {
            string fecha = DateTime.Now.ToShortDateString();
            lblFecha.Text = fecha;
            labelMensaje.Visible = false;
            verCitas(fecha);
        }

        #region Validacion
        private void soloNumeros(KeyPressEventArgs e)
        {
            if (Char.IsDigit(e.KeyChar) | Char.IsControl(e.KeyChar))
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
            }
        }

        #endregion

        #region Metodos
        //Cargar Lista De Citas por Fecha
        private void verCitas(string fecha)
        {
            var listaCitas = CitaNegocio.DevolverListaCitasFecha(fecha).Tables[0];
            dtvDatos.DataSource = listaCitas;
        }

        //Cargar Citas por Cedula
        private void verCitasPorCedula()
        {
            string cedula = txtCadenaBuscar.Text;
            var listaCitas = CitaNegocio.DevolverListaCitasPorCedula(cedula).Tables[0];
            if (listaCitas!=null)
            {
                dtvDatos.DataSource = listaCitas;
                labelMensaje.Visible = false;
            }
            else
            {
                labelMensaje.Visible = true;
            }
            
        }

        //Enviar Numero de Cita y Nombre Paciente
        public void enviarNumeroCita(DataGridViewCellEventArgs e)
        {
            this.NumCita = dtvDatos.Rows[e.RowIndex].Cells["NUM_CIT_MED"].Value.ToString();
            this.NomPaciente = dtvDatos.Rows[e.RowIndex].Cells["NOM1_PAC"].Value.ToString() +" "
                + dtvDatos.Rows[e.RowIndex].Cells["APE1_PAC"].Value.ToString();
            
        }

        #endregion

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        
        private void txtCadenaBuscar_TextChanged(object sender, EventArgs e)
        {
            verCitasPorCedula();
        }

        private void txtCadenaBuscar_KeyPress(object sender, KeyPressEventArgs e)
        {
            soloNumeros(e);
        }

        private void dtvDatos_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            enviarNumeroCita(e);
        }
    }
}
