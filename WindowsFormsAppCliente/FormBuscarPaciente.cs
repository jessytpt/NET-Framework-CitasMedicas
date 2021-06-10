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
    public partial class FormBuscarPaciente : Form
    {
        HistoriaClinicaNegocio obj = new HistoriaClinicaNegocio();
        
        public FormBuscarPaciente()
        {
            InitializeComponent();
            cargarLista();
        }

        #region PARTE GRÁFICA
        private void txtCadenaBuscar_TextChanged(object sender, EventArgs e)
        {
            buscarPorCriterio(txtCadenaBuscar.Text);
        }

        private void dtvDatos_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            enviarDatosPaciente(e);
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            cancelar();

        }

        #endregion
        

        #region MÉTODOS
        private void cargarLista()
        {

            var lista = obj.BuscarListaHistoriasClinicas().Tables[0];
            dtvDatos.DataSource = lista;
        }
        private void buscarPorCriterio(string parametro)
        {
            if (rtbnNumHistoriaClinica.Checked)
            {
                var lista = obj.BuscarListaHistoriasClinicasPorNumero(parametro).Tables[0];
                dtvDatos.DataSource = lista;
            }
            else if (rbtnCedula.Checked)
            {
                var lista = obj.BuscarListaHistoriasClinicasPorCedula(parametro).Tables[0];
                dtvDatos.DataSource = lista;


            }
            else if (rbtnApellido.Checked)
            {
                var lista = obj.BuscarListaHistoriasClinicasPorApellido(parametro).Tables[0];
                dtvDatos.DataSource = lista;
            }
            else if (rbtnNombre.Checked)
            {
                var lista = obj.BuscarListaHistoriasClinicasPorNombre(parametro).Tables[0];
                dtvDatos.DataSource = lista;
            }
            else
            {
                cargarLista();
            }

        }
        private void cancelar()
        {
            FormRegistrarCita.idPaciente = "";
            FormRegistrarCita.nombrePaciente = "";
            FormRegistrarCita.apellidoPaciente = "";
            this.Close(); throw new NotImplementedException();
        }
        private void enviarDatosPaciente(DataGridViewCellEventArgs e)
        {
            FormRegistrarCita.idPaciente = dtvDatos.Rows[e.RowIndex].Cells["CEDULA"].Value.ToString();
            FormRegistrarCita.nombrePaciente = dtvDatos.Rows[e.RowIndex].Cells["NOMBRE1"].Value.ToString();
            FormRegistrarCita.apellidoPaciente = dtvDatos.Rows[e.RowIndex].Cells["APELLIDO1"].Value.ToString();
        }
        #endregion
    }

}
