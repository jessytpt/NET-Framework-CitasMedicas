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

namespace WindowsFormsAppCliente
{
    public partial class Principal : Form
    {
        public Principal()
        {
            InitializeComponent();
            this.WindowState = FormWindowState.Maximized;
            inicio();
            
        }
        public Usuario usuario = new Usuario();
        
        private void inicio()
        {
            menuItemRegistro.Enabled = false;
            menuItemCitas.Enabled = false;
            menuItemAtencion.Enabled = false;
            menuItemFactura.Enabled = false;
            btnConsultarDisponibilidad.Enabled = false;
            btnRegistrarCita.Enabled = false;            
            btnNuevaHistoria.Enabled = false;
            btnAtencion.Enabled = false;
            btnAtencion.Visible = true;
            menuItemRegistroEmpleados.Visible = true;
            menuItemRegistroUsuarios.Visible = true;
            menuItemAtencion.Visible = true;
            btnFacturacion.Enabled = false;
            menuItemArchivoCerrarSesion.Enabled = false;
            menuItemArchivoIngresar.Enabled = true;

        }

        public void ingresar()
        {
            Login inicioSesion = new Login();
            inicioSesion.ShowDialog();
            if (inicioSesion.Usuario!= null)
            {
                desbolquearAdmin(inicioSesion.Usuario);
            }
            menuItemArchivoIngresar.Enabled = false;
            menuItemArchivoCerrarSesion.Enabled = true;
            
        }

        public void cerrarSesion()
        {
            Usuario cerrarSesion = new Usuario();
            usuario = cerrarSesion;
            lblUsuario.Text = "USUARIO";
            inicio();
        }

        public void abrirConsultarDisponibilida()
        {
            FormConsultaDisponibilidad consulta = new FormConsultaDisponibilidad();
            consulta.ShowDialog();
        }

        public void abrirRegistrarCita()
        {
            FormRegistrarCita registroCita = new FormRegistrarCita();
            registroCita.ShowDialog();
        }

        public void abrirNuevaHistoriaClinica()
        {
            FormNuevaHistoriaClinica nuevaHistClin = new FormNuevaHistoriaClinica();
            nuevaHistClin.ShowDialog();
        }

        public void abrirSignosVitales()
        {
            FormSignosVitales tomarSignos = new FormSignosVitales();
            tomarSignos.ShowDialog();
            if (tomarSignos.AtencionSignos != null)
            {
                
            }
        }

        public void abrirAtencion()
        {
            FormAtencion atencion = new FormAtencion(usuario);
            atencion.ShowDialog();
            
            
            
        }

        public void abrirFacturacion()
        {
            FormFactura factura = new FormFactura();
            factura.ShowDialog();
        }




        public void desbolquearAdmin(Usuario emp)
        {
            if (emp.TipoUsuario.Equals("ADMINISTRADOR"))
            {
                menuItemRegistro.Enabled = true;
                menuItemCitas.Enabled = true;
                menuItemAtencion.Enabled = true;
                menuItemFactura.Enabled = true;
                btnConsultarDisponibilidad.Enabled = true;
                btnRegistrarCita.Enabled = true;
                btnNuevaHistoria.Enabled = true;
                btnAtencion.Enabled = true;
                btnFacturacion.Enabled = true;
            }
            else if (emp.TipoUsuario.Equals("AUXILIAR"))
            {
                menuItemRegistro.Enabled = true;
                menuItemRegistroEmpleados.Visible = false;
                menuItemRegistroUsuarios.Visible = false;
                menuItemCitas.Enabled = true;
                menuItemAtencion.Enabled = true;
                menuItemAtencion.Visible = true;
                menuItemFactura.Enabled = true;
                btnConsultarDisponibilidad.Enabled = true;
                btnRegistrarCita.Enabled = true;
                btnNuevaHistoria.Enabled = true;
                btnAtencion.Enabled = true;
                btnAtencion.Visible = true;
                btnFacturacion.Enabled = true;
            }
            usuario = emp;
            lblUsuario.Text = "Bienvenido: "+usuario.Nombre+" "+usuario.Apellido;

        }
                

        private void Principal_SizeChanged(object sender, EventArgs e)
        {
            
        }

        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            cerrarSesion();
        }

        private void empleadoToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void nuevoToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            FormIngresoEmpleados nuevoEmpleado = new FormIngresoEmpleados();
            nuevoEmpleado.ShowDialog();
        }

        private void listaDeEmpleadosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormListaEmpleados lista = new FormListaEmpleados();
            
            lista.ShowDialog();
        }

        private void registrarHistoriaClínicaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormNuevaHistoriaClinica HC = new FormNuevaHistoriaClinica();
            HC.ShowDialog();
        }

        private void listaDeHistoriasClínicasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormListaHistoriasClinicas listaHistoriasClinicas = new FormListaHistoriasClinicas();
            listaHistoriasClinicas.ShowDialog();
        }

        private void listaDeUsuariosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormAdministrarUsuarios usuarios = new FormAdministrarUsuarios();
            usuarios.ShowDialog();
        }

        private void nuevaCitaMédicaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormRegistrarCita nuevaCitaMédica = new FormRegistrarCita();
            nuevaCitaMédica.ShowDialog();
        }

        private void agendaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormAgenda agenda= new FormAgenda();
            agenda.ShowDialog();
        }

        private void menuItemIngresar_Click(object sender, EventArgs e)
        {
            ingresar();
        }

        private void btnConsultarDisponibilidad_Click(object sender, EventArgs e)
        {
            abrirConsultarDisponibilida();
        }

        private void btnRegistrarCita_Click(object sender, EventArgs e)
        {
            abrirRegistrarCita();
        }

        private void btnNuevaHistoria_Click(object sender, EventArgs e)
        {
            abrirNuevaHistoriaClinica();
        }

        private void btnTomarSignos_Click(object sender, EventArgs e)
        {
            abrirSignosVitales();
        }

        private void btnAtencion_Click(object sender, EventArgs e)
        {
            
            abrirAtencion();
        }

        private void btnFacturacion_Click(object sender, EventArgs e)
        {
            abrirFacturacion();
        }

        private void menuItemArchivoSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        
    }
}
