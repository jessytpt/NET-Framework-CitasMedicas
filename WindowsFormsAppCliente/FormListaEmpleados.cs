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
    public partial class FormListaEmpleados : Form
    {
        #region Declaraciones
        EmpleadosNegocio obj = new EmpleadosNegocio();
        EstadoCivilNegocio estadoCivil = new EstadoCivilNegocio();
        CiudadesNegocio ciudades = new CiudadesNegocio();
        string estadoCivilActual;
        string ciudadActual;
        int indexEstadoCivilActual;
        int indexCiudadActual;
        #endregion

        public FormListaEmpleados()
        {
            InitializeComponent();
            bloquear();
            cargarLista();
            catalogos();
         
        }

        #region ParteGráfica
        private void button2_Click(object sender, EventArgs e)
        {
            tabControlEmpleados.SelectedIndex = 1;
            desbloquear();
        }
        
        private void button1_Click(object sender, EventArgs e)
        {
            //  buscarPorCriterio(txtCadenaBuscar.Text);
        }

        private void rbtnCedula_Click(object sender, EventArgs e)
        {

        }

        private void txtCadenaBuscar_KeyPress(object sender, KeyPressEventArgs e)
        {
            //buscarPorCriterio(txtCadenaBuscar.Text); no es recomendable poner la búsqueda en el método keypress
            //porque primero se deberá escribir en el txt y lugo dar un enter lo cual resulta incómodo
        }

        private void txtCadenaBuscar_TextChanged(object sender, EventArgs e)
        {
            buscarPorCriterio(txtCadenaBuscar.Text); //permite realizar la búsqueda mientras se escribe
        }

        private void dtvDatos_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            cargarDatosParaModificar(e);
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            ActualizarDatosEmpleado();
         
            limpiar();
            bloquear();
            cargarLista();
            tabControlEmpleados.SelectedIndex = 0;
        }
        private void btnEliminar_Click(object sender, EventArgs e)
        {
            eliminarEmpleado();
            limpiar();
            cargarLista();
        }
        private void btnCancelar_Click(object sender, EventArgs e)
        {
            limpiar();
            bloquear();
            tabPage1.Show();
        }



        #endregion


        #region Métodos
        private void cargarLista()
        {

            var lista = obj.DevolverListaEmpleados().Tables[0];
            dtvDatos.DataSource = lista;
        }
        public void catalogos()
        {
            var listaEstadiCivil = estadoCivil.DevolverListaEstadoCivil().Tables[0].DefaultView;
            cmbEstadoCivil.DataSource = listaEstadiCivil;
            cmbEstadoCivil.ValueMember = "COD_EST";
            cmbEstadoCivil.DisplayMember = "NOM_EST"; //display me permite selecionar el campo que se va a mostar en el combo box
                                                      //  cmbEstadoCivil.ValueMember = "COD_EST";


            var listaCiudades = ciudades.DevolverListaCiudades().Tables[0].DefaultView;
            cmbCiudad.DataSource = listaCiudades;
            cmbCiudad.ValueMember = "COD_CIU";
            cmbCiudad.DisplayMember = "NOM_CIU";
        }
        private void bloquear()
        {
            btnCancelar.Enabled = false;
            btnGuardar.Enabled = false;
            txtCedula.Enabled = false;
            txtApellido1.Enabled = false;
            txtApellido2.Enabled = false;
            txtNombre1.Enabled = false;
            txtNombre2.Enabled = false;
            txtDireccion.Enabled = false;
            txtTelefono.Enabled = false;
            cmbEstadoCivil.Enabled = false;
            cmbCiudad.Enabled = false;

        }
        private void limpiar()
        {
            txtCedula.Text = "";
            txtApellido1.Text = "";
            txtApellido2.Text = "";
            txtNombre1.Text = "";
            txtNombre2.Text = "";
            txtDireccion.Text = "";
            txtTelefono.Text = "";
        }
        private void desbloquear()
        {
            btnCancelar.Enabled = true;
            btnGuardar.Enabled = true;
            txtCedula.Enabled = false;
            txtApellido1.Enabled = true;
            txtApellido2.Enabled = true;
            txtNombre1.Enabled = true;
            txtNombre2.Enabled = true;
            txtDireccion.Enabled = true;
            txtTelefono.Enabled = true;
            cmbEstadoCivil.Enabled = true;
            cmbCiudad.Enabled = true;

        }
        private void buscarPorCriterio(string parametro)
        {


            if (rbtnCedula.Checked)
            {

                var lista = obj.DevolverListEmpleadorPorCedula(parametro).Tables[0];
                dtvDatos.DataSource = lista;


            }
            else if (rbtnApellido.Checked)
            {
                var lista = obj.DevolverListaEmpleadosPorApellido(parametro).Tables[0];
                dtvDatos.DataSource = lista;
            }
            else if (rbtnNombre.Checked)
            {
                var lista = obj.DevolverListaEmpleadosPorNombre(parametro).Tables[0];
                dtvDatos.DataSource = lista;
            }
            else if (rtbnTipoUsuario.Checked)
            {
                var lista = obj.DevolverListaEmpleadosPorTipoUsuario(parametro).Tables[0];
                dtvDatos.DataSource = lista;
            }
            else if (rbtnCargo.Checked)
            {
                var lista = obj.DevolverListaEmpleadosPorCargo(parametro).Tables[0];
                dtvDatos.DataSource = lista;
            }

            else
            {
                cargarLista();
            }


        }
        public void cargarDatosParaModificar(DataGridViewCellEventArgs e)
        {
            txtCedula.Text = dtvDatos.Rows[e.RowIndex].Cells["CEDULA"].Value.ToString();
            txtApellido1.Text = dtvDatos.Rows[e.RowIndex].Cells["APE1_EMP"].Value.ToString();
            txtApellido2.Text = dtvDatos.Rows[e.RowIndex].Cells["APE2_EMP"].Value.ToString();
            txtNombre1.Text = dtvDatos.Rows[e.RowIndex].Cells["NOM1_EMP"].Value.ToString();
            txtNombre2.Text = dtvDatos.Rows[e.RowIndex].Cells["NOM2_EMP"].Value.ToString();
            txtTelefono.Text = dtvDatos.Rows[e.RowIndex].Cells["TEL_EMP"].Value.ToString();
            //El comobobox debe aparecer por defecto con el valor de la tabla
            //1. Guardar en una variable string lo que tengo en la tabla
            //2. Encontar el index dentro del combobox que tiene la opcion que se guardó en el string
            //3. Enviar por defecto 
            estadoCivilActual = dtvDatos.Rows[e.RowIndex].Cells["NOM_EST"].Value.ToString();
            //MessageBox.Show(estadoCivilActual);
            indexEstadoCivilActual = cmbEstadoCivil.FindString(estadoCivilActual);
            //MessageBox.Show(Convert.ToString(indexEstadoCivilActual));
            cmbEstadoCivil.SelectedIndex = indexEstadoCivilActual;
            txtDireccion.Text = dtvDatos.Rows[e.RowIndex].Cells["DIR_EMP"].Value.ToString();
            ciudadActual = dtvDatos.Rows[e.RowIndex].Cells["NOM_CIU"].Value.ToString();
            indexCiudadActual = cmbCiudad.FindString(ciudadActual);
            cmbEstadoCivil.SelectedIndex = indexCiudadActual;
        }
        private void ActualizarDatosEmpleado()
        {
           Empleado  persona = new Empleado();
            persona.Cedula = txtCedula.Text;
            persona.Apellido1 = txtApellido1.Text;
            persona.Apellido2 = txtApellido2.Text;
            persona.Nombre1 = txtNombre1.Text;
            persona.Nombre2 = txtNombre2.Text;
            persona.Telefono = txtTelefono.Text;
            persona.EstadoCivil = cmbEstadoCivil.SelectedValue.ToString();
           persona.Direccion = txtDireccion.Text;
            persona.Cod_Ciudad = cmbCiudad.SelectedValue.ToString();
            
            var resultado = EmpleadosNegocio.ActualizarPersona(persona);
            MessageBox.Show("Empleado Actualizado!");
        }
        private void eliminarEmpleado()
        {
            Empleado persona = new Empleado();
            persona.Cedula = txtCedula.Text;

            var resultado =EmpleadosNegocio.EliminarPersona(persona);
        }
        
        #endregion

       
    }
}
