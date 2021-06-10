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


namespace WindowsFormsAppCliente
{
    public partial class FormConsultaDisponibilidad : Form
    {
        CitaNegocio nuevaCita = new CitaNegocio();
        public FormConsultaDisponibilidad()
        {
            InitializeComponent();
            inicio();
        }

        string fechaSeleccionada = "";

        #region Metodos

        private void inicio()
        {
            fechaSeleccionada = DateTime.Now.ToShortDateString();
            lblFecha.Text = fechaSeleccionada;
            consultarCitaPorFecha(fechaSeleccionada);
        }

        private void abrirNuevaCita()
        {
            FormRegistrarCita nuevaCita = new FormRegistrarCita();
            nuevaCita.ShowDialog();
        }

        private void abrirAgenda()
        {
            FormAgenda agenda = new FormAgenda();
            agenda.ShowDialog();
            if (!agenda.FechaSeleccionada.Equals("")) 
            {
                fechaSeleccionada = agenda.FechaSeleccionada;
                lblFecha.Text = fechaSeleccionada;
                consultarCitaPorFecha(fechaSeleccionada);
            }
        }

        private void cancelar()
        {
            this.Close();
        }

        public void consultarCitaPorFecha(string fecha)
        {
            var listaCitas = CitaNegocio.DevolverListaCitasFecha(fecha).Tables[0];
            dtgCitas.DataSource = listaCitas;

        }


        #endregion

        private void btnNuevaCita_Click(object sender, EventArgs e)
        {
            abrirNuevaCita();
        }

        private void btnAgenda_Click(object sender, EventArgs e)
        {
            abrirAgenda();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            cancelar();
        }

        private void lblFecha_TextChanged(object sender, EventArgs e)
        {
            consultarCitaPorFecha(fechaSeleccionada);
        }
    }
}
