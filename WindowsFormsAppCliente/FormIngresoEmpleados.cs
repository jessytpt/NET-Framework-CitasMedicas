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
    public partial class FormIngresoEmpleados : Form
    {
        #region Instanciaciones
        EstadoCivilNegocio obj = new EstadoCivilNegocio();
        CiudadesNegocio ciudades = new CiudadesNegocio();
        EtniasNegocio etnias = new EtniasNegocio();
        TipoUsuariosNegocio usuarios = new TipoUsuariosNegocio();
        CargoNegocio cargo = new CargoNegocio();
        Empleado nuevoEmpleado = new Empleado();
        GeneroNegocio genero = new GeneroNegocio();
        #endregion

        public FormIngresoEmpleados()
        {
            InitializeComponent();
            catalogos();
            inicio();

        }
        public void inicio()
        {
            txtNombreUsuario.Enabled = false;
            txtContraseña.Enabled = false;
            //cmbCargoEmpleado.Enabled = false;
            cmbCargoEmpleado.SelectedIndex = -1;
            cmbCiudad.SelectedIndex = -1;
            cmbEstadoCivil.SelectedIndex = -1;
            cmbEtnia.SelectedIndex = -1;
            cmbGenero.SelectedIndex = -1;
            cmbTipoUsuario.SelectedIndex = -1;
            cmbTipoUsuario.Enabled = false;
        }


        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (validarDatos())
            {
                guardar();
                limpiar();
            }else
            {
                MessageBox.Show("Por favor ingrese todos los datos");
                fijarCursor();
            }
            
        }
        
        private void btnCancelar_Click(object sender, EventArgs e)
        {
            limpiar();
        }

        #region Catálogos
        public void catalogos()
        {
            var listaEstadiCivil = obj.DevolverListaEstadoCivil().Tables[0].DefaultView;
            cmbEstadoCivil.DataSource = listaEstadiCivil;
            cmbEstadoCivil.ValueMember = "COD_EST";
            cmbEstadoCivil.DisplayMember = "NOM_EST"; //display me permite selecionar el campo que se va a mostar en el combo box
                                                      //  cmbEstadoCivil.ValueMember = "COD_EST";


            var listaCiudades = ciudades.DevolverListaCiudades().Tables[0].DefaultView;
            cmbCiudad.DataSource = listaCiudades;
            cmbCiudad.ValueMember = "COD_CIU";
            cmbCiudad.DisplayMember = "NOM_CIU";

            var listaGeneros = genero.DevolverListaGenero().Tables[0].DefaultView;
            cmbGenero.DataSource = listaGeneros;
            cmbGenero.ValueMember = "COD_GEN";
            cmbGenero.DisplayMember = "NOM_GEN";

            var listaEtnias = etnias.DevolverListaEtnias().Tables[0].DefaultView;
            cmbEtnia.DataSource = listaEtnias;
            cmbEtnia.ValueMember = "COD_ETN";
            cmbEtnia.DisplayMember = "NOM_ETN";

            var listaCargos = cargo.DevolverListaCargos().Tables[0].DefaultView;
            cmbCargoEmpleado.DataSource = listaCargos;
            cmbCargoEmpleado.ValueMember = "COD_CAR";
            cmbCargoEmpleado.DisplayMember = "NOM_CAR";


            var listaTiposUsuarios = usuarios.DevolverListaTiposUsuarios().Tables[0].DefaultView;
            cmbTipoUsuario.DataSource = listaTiposUsuarios;
            cmbTipoUsuario.ValueMember = "COD_USU";
            cmbTipoUsuario.DisplayMember = "NOM_USU";
        }

        #endregion

        #region Validaciones
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
        private void soloLetras(KeyPressEventArgs e)
        {
            if (Char.IsLetter(e.KeyChar) | Char.IsControl(e.KeyChar))
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
            }
        }
        #endregion

        #region Métodos
        private void limpiar()
        {
            txtCedua.Text = "";
            txtApellido1.Text = "";
            txtApellido2.Text = "";
            txtNombre1.Text = "";
            txtNombre2.Text = "";
            txtTelefono.Text = "";
            txtDireccion.Text = "";
            txtNombreUsuario.Text = "";
            txtContraseña.Text = "";
            cmbCargoEmpleado.SelectedIndex=-1;
            cmbCiudad.SelectedIndex = -1; 
            cmbEstadoCivil.SelectedIndex = -1;
            cmbEtnia.SelectedIndex = -1;
            cmbGenero.SelectedIndex = -1;
            cmbTipoUsuario.SelectedIndex = -1;


        }

        private void seleccionarTipo()
        {
            int indice = -1;
            if (cmbCargoEmpleado.SelectedValue.ToString().Equals("01"))
            {
                indice = cmbTipoUsuario.FindString("ADMINISTRADOR");
                
            }else if (cmbCargoEmpleado.SelectedValue.ToString().Equals("02"))
            {
                indice = cmbTipoUsuario.FindString("AUXILIAR");
            }
            
            cmbTipoUsuario.SelectedIndex = indice;
        }

        private bool validarDatos()
        {
            if (txtCedua.Text.Equals("")
                | txtCedua.Text.Length < 10
                | txtApellido1.Text.Equals("")
                | txtApellido1.Text.Length < 3
                | txtApellido2.Text.Equals("")
                | txtApellido2.Text.Length < 3
                | txtNombre1.Text.Equals("")
                | txtNombre1.Text.Length < 3
                | txtNombre2.Text.Equals("")
                | txtNombre2.Text.Length < 3
                | txtDireccion.Text.Equals("")
                | txtDireccion.Text.Length < 3
                | txtTelefono.Text.Equals("")
                | cmbGenero.SelectedIndex == -1
                | cmbEstadoCivil.SelectedIndex == -1
                | cmbCiudad.SelectedIndex == -1
                | cmbEtnia.SelectedIndex == -1
                | cmbCargoEmpleado.SelectedIndex == -1
                )
            {
                return false;
            }else
            {
                return true;
            }
            
        }

        private void fijarCursor()
        {
            if (txtCedua.Text.Equals("")
                | txtCedua.Text.Length < 10)
            {
                txtCedua.Focus();
            }else if ( txtApellido1.Text.Equals("")
                | txtApellido1.Text.Length < 3
                | txtApellido2.Text.Equals("")
                | txtApellido2.Text.Length < 3)
            {
                txtApellido1.Focus();
            }else if (txtNombre1.Text.Equals("")
                | txtNombre1.Text.Length < 3
                | txtNombre2.Text.Equals("")
                | txtNombre2.Text.Length < 3)
            {
                txtNombre1.Focus();
            }else if( txtDireccion.Text.Equals("")
                | txtDireccion.Text.Length < 3
                )
            {
                txtDireccion.Focus();
            }else if(txtTelefono.Text.Equals(""))
            {
                txtTelefono.Focus();
            }else if(cmbGenero.SelectedIndex == -1)
            {
                cmbGenero.Focus();
            }else if (cmbEstadoCivil.SelectedIndex == -1)
            {
                cmbEstadoCivil.Focus();
            }else if (cmbEtnia.SelectedIndex == -1)
            {
                cmbEtnia.Focus();
            }else if (cmbCargoEmpleado.SelectedIndex == -1)
            {
                cmbCargoEmpleado.Focus();
            }else if (cmbCiudad.SelectedIndex == -1)
            {
                cmbCiudad.Focus();
            }

        }

        private void fijarCursor()
        {
            if (txtCedua.Text.Equals("")
                | txtCedua.Text.Length < 10)
            {
                txtCedua.Focus();
            }else if ( txtApellido1.Text.Equals("")
                | txtApellido1.Text.Length < 3
                | txtApellido2.Text.Equals("")
                | txtApellido2.Text.Length < 3)
            {
                txtApellido1.Focus();
            }else if (txtNombre1.Text.Equals("")
                | txtNombre1.Text.Length < 3
                | txtNombre2.Text.Equals("")
                | txtNombre2.Text.Length < 3)
            {
                txtNombre1.Focus();
            }else if( txtDireccion.Text.Equals("")
                | txtDireccion.Text.Length < 3
                )
            {
                txtDireccion.Focus();
            }else if(txtTelefono.Text.Equals(""))
            {
                txtTelefono.Focus();
            }else if(cmbGenero.SelectedIndex == -1)
            {
                cmbGenero.Focus();
            }else if (cmbEstadoCivil.SelectedIndex == -1)
            {
                cmbEstadoCivil.Focus();
            }else if (cmbEtnia.SelectedIndex == -1)
            {
                cmbEtnia.Focus();
            }else if (cmbCargoEmpleado.SelectedIndex == -1)
            {
                cmbCargoEmpleado.Focus();
            }else if (cmbCiudad.SelectedIndex == -1)
            {
                cmbCiudad.Focus();
            }

        }

        public string encriptar(string cadenaAencriptar)
        {
            string result = string.Empty;
            byte[] encryted = System.Text.Encoding.Unicode.GetBytes(cadenaAencriptar);
            result = Convert.ToBase64String(encryted);
            return result;
        }

        private void guardar()
        {
            nuevoEmpleado.Cedula = txtCedua.Text;
            nuevoEmpleado.Nombre1 = txtNombre1.Text;
            nuevoEmpleado.Nombre2 = txtNombre2.Text;
            nuevoEmpleado.Apellido1 = txtApellido1.Text;
            nuevoEmpleado.Apellido2 = txtApellido2.Text;
            nuevoEmpleado.Genero = Convert.ToInt32(cmbGenero.SelectedValue.ToString());
            nuevoEmpleado.Telefono = txtTelefono.Text;
            nuevoEmpleado.EstadoCivil = cmbEstadoCivil.SelectedValue.ToString();
            nuevoEmpleado.Fecha_Nacimiento = dateFechaNacimiento.Value.ToString("dd/MM/yyyy"); //de esta manera se obtiene la fecha con un formato personalizado
            nuevoEmpleado.Direccion = txtDireccion.Text;
            nuevoEmpleado.Etnia = cmbEtnia.SelectedValue.ToString();
            nuevoEmpleado.Cod_Ciudad = cmbCiudad.SelectedValue.ToString();
            nuevoEmpleado.NomUsuario = txtNombreUsuario.Text;
            String claveEncriptada = encriptar(txtContraseña.Text);
            nuevoEmpleado.Clave = claveEncriptada;
            nuevoEmpleado.Cargo = cmbCargoEmpleado.SelectedValue.ToString();
            nuevoEmpleado.TipoUsuario = cmbTipoUsuario.SelectedValue.ToString();
            MessageBox.Show(nuevoEmpleado.Cedula+"\n"
                +nuevoEmpleado.Apellido1+"\n"
                + nuevoEmpleado.Genero + "\n"
                + nuevoEmpleado.Etnia + "\n"
                + nuevoEmpleado.EstadoCivil + "\n"
                + nuevoEmpleado.Cod_Ciudad + "\n"
                + nuevoEmpleado.Telefono + "\n"
                + nuevoEmpleado.Cargo + "\n");


            var resultado = EmpleadosNegocio.GuardarEmpleado(nuevoEmpleado);
        }
        #endregion

        private void txtCedua_KeyPress(object sender, KeyPressEventArgs e)
        {
            soloNumeros(e);
        }

        private void txtApellido1_KeyPress(object sender, KeyPressEventArgs e)
        {
            soloLetras(e);
        }

        private void txtApellido2_KeyPress(object sender, KeyPressEventArgs e)
        {
            soloLetras(e);
        }

        private void txtNombre1_KeyPress(object sender, KeyPressEventArgs e)
        {
            soloLetras(e);
        }

        private void txtNombre2_KeyPress(object sender, KeyPressEventArgs e)
        {
            soloLetras(e);
        }

        private void txtCedua_Leave(object sender, EventArgs e)
        {
            txtNombreUsuario.Text = txtCedua.Text;
            txtContraseña.Text = txtCedua.Text;
        }
        
        private void cmbCargoEmpleado_Leave(object sender, EventArgs e)
        {
            seleccionarTipo();
        }
    }
}
