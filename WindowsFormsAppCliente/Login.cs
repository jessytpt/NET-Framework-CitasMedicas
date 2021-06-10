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
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
            //this.TransparencyKey = (BackColor);
            //timer1.Start();
            inicio();

            
        }
        public Usuario Usuario { get; set; }

        private void inicio()
        {
            this.TransparencyKey = (BackColor);
            timer1.Start();
            lblMensajeError.Visible = false;
        }

        // public Empleado empleado= new Empleado();
        
        public void ingresar()
        {
            try
            {
                string usuario = "";
                string clave = "";
                Usuario emp = new Usuario();
                if (String.IsNullOrEmpty(txtUsuario.Text) | String.IsNullOrEmpty(txtClave.Text))
                {
                    MessageBox.Show("POR FAVOR INGRESE LA INFORMACION REQUERIDA");
                    txtUsuario.Focus();
                }
                else
                {
                    usuario = txtUsuario.Text;
                    clave = txtClave.Text;
                    var ListaUsuarios = EmpleadosNegocio.DevolverUsuarioInicioSesion(usuario, clave);
                    //MessageBox.Show(ListaUsuarios.Count.ToString());
                    int numUsuario = ListaUsuarios.Count;
                    if (numUsuario == 0)
                    {
                        mensajeError();   
                        
                    }
                    else
                    {
                        Usuario = ListaUsuarios.Last();
                        this.Close();
                    }

                }

            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }           
            
        }

        public void mensajeError()
        {
            lblMensajeError.Text = "Usuario o contraseña Incorrectos";
            lblMensajeError.Visible = true;
            limpiar();
        }

        public void limpiar()
        {
            txtUsuario.Text = "";
            txtClave.Text = "";
            txtUsuario.Focus();
        }

        public void prueba()
        {

            try
            {
                var usuarios = EmpleadosNegocio.DevolverUsuarioInicioSesion(txtUsuario.Text, txtClave.Text);
                if (usuarios.Count != 0)
                {
                    Usuario emp = new Usuario();
                    emp = usuarios.Last();
                    MessageBox.Show("Usuario " + emp.Nombre);
                }
                else
                {
                    MessageBox.Show("NO EXISTE EL USUARIO");
                }
            }
            catch (Exception e)
            {

                MessageBox.Show(e.Message);
            }
            

        }

        public void cancelar()
        {
            this.Dispose();
        }

        private void ponerHoraFecha()
        {
            lblFecha.Text = DateTime.Now.ToShortDateString();
            lblHora.Text = DateTime.Now.ToLongTimeString();
            

        }
       
        private void timer1_Tick_1(object sender, EventArgs e)
        {
            ponerHoraFecha();

        }

        private void btnIngresar_Click(object sender, EventArgs e)
        {
            ingresar();
            //prueba();
            
        }

        private void btnIngresar_MouseMove(object sender, MouseEventArgs e)
        {
            btnIngresar.ForeColor = Color.White;
        }

        private void linkLabel1_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void linkLabel2_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void btnIngresar_MouseLeave(object sender, EventArgs e)
        {
            btnIngresar.ForeColor = Color.Black;
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void btnCancelar_MouseMove(object sender, MouseEventArgs e)
        {
            btnCancelar.ForeColor = Color.White;
        }

        private void btnCancelar_MouseLeave(object sender, EventArgs e)
        {
            btnCancelar.ForeColor = Color.Black;
        }
    }
}
