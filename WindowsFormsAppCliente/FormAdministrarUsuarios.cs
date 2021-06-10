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
    public partial class FormAdministrarUsuarios : Form
    {
       UsuariosNegocio obj = new UsuariosNegocio();
       Empleado usuario = new Empleado();

        public FormAdministrarUsuarios()
        {
            InitializeComponent();
            cargarLista();
        }

        #region PARTE GRÁFICA
        private void btnAgregar_Click(object sender, EventArgs e)
        {

        }

        private void txtCadenaBuscar_KeyPress(object sender, KeyPressEventArgs e)
        {

            //buscarPorCriterio(txtCadenaBuscar.Text);

        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
           

        
        }
        
        private void txtCadenaBuscar_KeyUp(object sender, KeyEventArgs e)
        {

        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            ActualizarDatosUsuario();
           
           
        }
             
        private void txtCadenaBuscar_TextChanged(object sender, EventArgs e)
        {
            buscarPorCriterio(txtCadenaBuscar.Text);
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            tabControl1.SelectedIndex = 1;
            desbloquear();
        }
        private void dtvDatos_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            cargarDatosParaModificar(e);
        }

        #endregion 

        #region Métodos
        private void cargarLista()
        {
            var lista = obj.DevolverListaUsuarios().Tables[0];
            dtvDatos.DataSource = lista;
        }
        private void desbloquear()
        {
            btnCancelar.Enabled = true;
            btnGuardar.Enabled = true;
            txtCedua.Enabled = false;
            txtApellido1.Enabled = true;
            txtApellido2.Enabled = true;
            txtNombre1.Enabled = true;
            txtNombre2.Enabled = true;
            txtNombreUsuario.Enabled = true;
            txtContraseña.Enabled = true;
            txtConfirmaClave.Enabled = true;
        }
        private void bloquear()
        {
            btnCancelar.Enabled = false;
            btnGuardar.Enabled = false;
            txtCedua.Enabled = false;
            txtApellido1.Enabled = false;
            txtApellido2.Enabled = false;
            txtNombre1.Enabled = false;
            txtNombre2.Enabled = false;
            txtNombreUsuario.Enabled = false;
            txtContraseña.Enabled = false;
            txtConfirmaClave.Enabled = false;
        }
        private void limpiar()
        {
            txtCedua.Text = "";
            txtApellido1.Text = "";
            txtApellido2.Text = "";
            txtNombre1.Text = "";
            txtNombre2.Text = "";
            txtNombreUsuario.Text = "";
            txtContraseña.Text = "";
            txtConfirmaClave.Text = "";
        }
        private void buscarPorCriterio(string text)
        {
            if (rbtnNombreUsuario.Checked)
            {
                var lista = obj.DevolverListaUsuarioPorNombre(text).Tables[0];
                dtvDatos.DataSource = lista;
            }


            if (rbtnTipoUsuario.Checked)
            {
                var lista = obj.DevolverListaUsuariosPorTipo(text).Tables[0];
                dtvDatos.DataSource = lista;
            }

           
        }
        private void cargarDatosParaModificar(DataGridViewCellEventArgs e)
        {
            txtCedua.Text = dtvDatos.Rows[e.RowIndex].Cells["CEDULA"].Value.ToString();
            txtApellido1.Text = dtvDatos.Rows[e.RowIndex].Cells["APE1_EMP"].Value.ToString();
            txtApellido2.Text = dtvDatos.Rows[e.RowIndex].Cells["APE2_EMP"].Value.ToString();
            txtNombre1.Text = dtvDatos.Rows[e.RowIndex].Cells["NOM1_EMP"].Value.ToString();
            txtNombre2.Text = dtvDatos.Rows[e.RowIndex].Cells["NOM2_EMP"].Value.ToString();
            txtNombreUsuario.Text = dtvDatos.Rows[e.RowIndex].Cells["NOM_USU"].Value.ToString();


        }
        private void ActualizarDatosUsuario()
        {
            if (!txtContraseña.Text.Equals(txtConfirmaClave.Text))
            {
                MessageBox.Show("Las claves no coinciden!");
                txtContraseña.Text = "";
                txtConfirmaClave.Text = "";
                txtContraseña.Focus();

            }
            else
            {
                enviarDatosParaActualizar();
                MessageBox.Show("Usuario Actualizado!");
                limpiar();
                bloquear();
                cargarLista();
                tabControl1.SelectedIndex = 0;
            }
                        
        }
        private void enviarDatosParaActualizar()
        {
            usuario.Cedula = txtCedua.Text;
            usuario.NomUsuario = txtNombreUsuario.Text;
            usuario.Clave = txtContraseña.Text;
            var resultado = UsuariosNegocio.ActualizarUsuario(usuario);
        }



        #endregion

        

       
    }
}
