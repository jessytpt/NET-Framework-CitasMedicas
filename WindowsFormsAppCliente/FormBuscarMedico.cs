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
    public partial class FormBuscarMedico : Form
    {
        EmpleadosNegocio obj = new EmpleadosNegocio();
        public static string idMedicoBuscar;


        public FormBuscarMedico()
        {
            InitializeComponent();
            cargarLista();
        }

        #region PARTE GRÁFICA
        private void txtCadenaBuscar_TextChanged(object sender, EventArgs e)
        {
            buscarPorCriterio(txtCadenaBuscar.Text);
        }

        private void button1_Click(object sender, EventArgs e)
        {

            this.Close();
        }

        private void dtvDatos_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            enviarDatosMedico(e);
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            cancelar();
        }


        #endregion


        #region MÉTODOS
        private void cargarLista()
        {

            var lista = obj.BuscarListaEmpleados().Tables[0];
            dtvDatos.DataSource = lista;
        }
        private void buscarPorCriterio(string parametro)
        {
            if (rbtnCedula.Checked)
            {
                var lista = obj.BuscarListaEmpleadoPorCedula(parametro).Tables[0];
                dtvDatos.DataSource = lista;
            }
            else if (rbtnApellido.Checked)
            {
                var lista = obj.BuscarListaEmpleadosPorApellido(parametro).Tables[0];
                dtvDatos.DataSource = lista;
            }
            else if (rbtnNombre.Checked)
            {
                var lista = obj.BuscarListaEmpleadosPorNombre(parametro).Tables[0];
                dtvDatos.DataSource = lista;
            }
            else
            {
                cargarLista();
            }


        }
        private void cancelar()
        {
            FormRegistrarCita.idMedico = "";
            FormRegistrarCita.nombreMedico = "";
            FormRegistrarCita.apellidoMedico = "";
            this.Close();
        }
        private void enviarDatosMedico(DataGridViewCellEventArgs e)
        {
            //Se envian los datos a variables estáticas
            FormRegistrarCita.idMedico = dtvDatos.Rows[e.RowIndex].Cells["CEDULA"].Value.ToString();
            FormRegistrarCita.nombreMedico = dtvDatos.Rows[e.RowIndex].Cells["NOM1_EMP"].Value.ToString();
            FormRegistrarCita.apellidoMedico = dtvDatos.Rows[e.RowIndex].Cells["APE1_EMP"].Value.ToString();
        }
        #endregion
    }
}
