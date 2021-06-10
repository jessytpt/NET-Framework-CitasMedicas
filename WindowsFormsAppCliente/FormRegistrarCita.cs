using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Mensajeria_Clases;
using NEGOCIO;
namespace WindowsFormsAppCliente
{
    public partial class FormRegistrarCita : Form
    {

        #region DECLARACIONES E INSTANCIACIONES
        Cita nuevaCita = new Cita();
        public static string idMedico;
        public static string nombreMedico;
        public static string apellidoMedico;
        public static string idPaciente;
        public static string nombrePaciente;
        public static string apellidoPaciente;
        #endregion

        public FormRegistrarCita()
        {
            InitializeComponent();
        }

        #region PARTE GRÁFICA
        private void btnBuscarMedico_Click(object sender, EventArgs e)
        {
            buscarMedico();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            buscarPaciente();
        }
        
        private void btnGuardar_Click(object sender, EventArgs e)
        {
            guardarCia();
            limpiar();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            limpiar();
        }

        #endregion

        #region Métodos
        private void buscarMedico()
        {
            FormBuscarMedico ventanaMedico = new FormBuscarMedico();
            ventanaMedico.ShowDialog();
            txtIDMedico.Text = idMedico;
            txtApellidoMedico.Text = apellidoMedico;
            txtNombreMedico.Text = nombreMedico;
        }
        private void buscarPaciente()
        {
            FormBuscarPaciente ventanaPaciente = new FormBuscarPaciente();
            ventanaPaciente.ShowDialog();
            txtIDPaciente.Text = idPaciente;
            txtApellidoPaciente.Text = apellidoPaciente;
            txtNombrePaciente.Text = nombrePaciente;
        }
        public void guardarCia()
        {
            nuevaCita.CedulaEmpleado = idMedico;
            nuevaCita.CedulaPaciente = idPaciente;
            nuevaCita.Fecha = dtFecha.Value.ToString("dd/MM/yyyy");
            nuevaCita.Hora = mskTxtHora.Text;
            var resultado = CitaNegocio.GuardarCita(nuevaCita);
        }
        public void limpiar()
        {
            txtIDMedico.Text = "";
            txtNombreMedico.Text = "";
            txtApellidoMedico.Text = "";
            txtIDPaciente.Text = "";
            txtNombrePaciente.Text = "";
            txtApellidoPaciente.Text = "";
            mskTxtHora.Text = "";

        }
        #endregion
    }
}
