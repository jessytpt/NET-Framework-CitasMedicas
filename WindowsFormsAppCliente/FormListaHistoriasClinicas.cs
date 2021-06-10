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
    public partial class FormListaHistoriasClinicas : Form
    {
        
        #region Declaraciones
        GeneroNegocio genero = new GeneroNegocio();
        EstadoCivilNegocio estadoCivil = new EstadoCivilNegocio();
        CiudadesNegocio ciudades = new CiudadesNegocio();
        EtniasNegocio etnias = new EtniasNegocio();
        HistoriaClinicaNegocio obj = new HistoriaClinicaNegocio();
        String generoActual;
        String etniaActual;
        String ciudadActual;
        String estadoCivilActual;
        int indexGeneroActual;
        int indexEtniaActual;
        int indexciudadActual;
        int indexEstadoCivilActual;
        #endregion

        public FormListaHistoriasClinicas()
        {
            InitializeComponent();
            bloquear();
            cargarLista();
            catalogos();
        }
               
        #region Parte Gráfica
        private void btnEliminar_Click(object sender, EventArgs e)
        {
            eliminarHistoria();
            limpiar();
            cargarLista();

        }

       private void txtCadenaBuscar_KeyPress(object sender, KeyPressEventArgs e)
        {

        }

        private void txtCadenaBuscar_KeyDown(object sender, KeyEventArgs e)
        {

        }

        private void txtCadenaBuscar_TextChanged(object sender, EventArgs e)
        {
            buscarPorCriterio(txtCadenaBuscar.Text);

        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            ActualizarDatosPaciente();
            limpiar();
            bloquear();
            cargarLista();
            tabControl1.SelectedIndex = 0;
        }

        private void dtvDatos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
           
        }

        private void dtvDatos_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            cargarDatosParaModificar(e);
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            tabControl1.SelectedIndex = 1;
            desbloquear();
        }
        private void btnCancelar_Click(object sender, EventArgs e)
        {
            limpiar();
            bloquear();
            tabPage1.Show();
        }

        #endregion

        #region Catálogos 
        //cargar catálogos en cada combobox
        public void catalogos()
        {
            var listaGeneros = genero.DevolverListaGenero().Tables[0].DefaultView;
            cmbGenero.DataSource = listaGeneros;
            cmbGenero.ValueMember = "COD_GEN";
            cmbGenero.DisplayMember = "NOM_GEN";

            var listaEstadiCivil = estadoCivil.DevolverListaEstadoCivil().Tables[0].DefaultView;
            cmbEstadoCivil.DataSource = listaEstadiCivil;
            cmbEstadoCivil.ValueMember = "COD_EST";
            cmbEstadoCivil.DisplayMember = "NOM_EST"; //display me permite selecionar el campo que se va a mostar en el combo box
                                                      //  cmbEstadoCivil.ValueMember = "COD_EST";
            var listaEtnias = etnias.DevolverListaEtnias().Tables[0].DefaultView;
            cmbEtnia.DataSource = listaEtnias;
            cmbEtnia.ValueMember = "COD_ETN";
            cmbEtnia.DisplayMember = "NOM_ETN";

            var listaCiudades = ciudades.DevolverListaCiudades().Tables[0].DefaultView;
            comboBoxCiudades.DataSource = listaCiudades;
            comboBoxCiudades.ValueMember = "COD_CIU";
            comboBoxCiudades.DisplayMember = "NOM_CIU";



        }

        #endregion

        #region Métodos
        private void cargarLista()
        {

            var lista = obj.DevolverListaHistoriasClinicas().Tables[0];
            dtvDatos.DataSource = lista;
        }
        private void limpiar()
        {
            txtNumHistClin.Text = "";
            txtCedua.Text = "";
            txtApellido1.Text="";
            txtApellido2.Text = "";
            txtNombre1.Text = "";
            txtNombre2.Text = "";
            txtOcupacion.Text = "";
            txtDireccion.Text = "";
            txtTelefono.Text = "";
        }
        private void bloquear()
        {
            btnCancelar.Enabled = false;
            btnGuardar.Enabled = false;
            txtNumHistClin.Enabled = false;
            txtCedua.Enabled = false;
            txtApellido1.Enabled = false;
            txtApellido2.Enabled = false;
            txtNombre1.Enabled = false;
            txtNombre2.Enabled = false;
            txtOcupacion.Enabled = false;
            txtDireccion.Enabled = false;
            txtTelefono.Enabled = false;
            cmbGenero.Enabled = false;
            cmbEstadoCivil.Enabled = false;
            cmbEtnia.Enabled = false;
            comboBoxCiudades.Enabled = false;
        }
        private void desbloquear()
        {
            btnCancelar.Enabled = true;
            btnGuardar.Enabled = true;
            txtNumHistClin.Enabled = false;
            txtCedua.Enabled = false;
            txtApellido1.Enabled = true;
            txtApellido2.Enabled = true;
            txtNombre1.Enabled = true;
            txtNombre2.Enabled = true;
            txtOcupacion.Enabled = true;
            txtDireccion.Enabled = true;
            txtTelefono.Enabled = true;
            cmbGenero.Enabled = true;
            cmbEstadoCivil.Enabled = true;
            cmbEtnia.Enabled = true;
            comboBoxCiudades.Enabled = true;
        }
        private void buscarPorCriterio(string parametro)
        {
            if (rtbnNumHistoriaClinica.Checked)
            {
                var lista = obj.DevolverListaHistoriasClinicasPorNumero(parametro).Tables[0];
                dtvDatos.DataSource = lista;
            }
            else if (rbtnCedula.Checked)
            {
                var lista = obj.DevolverListaHistoriasClinicasPorCedula(parametro).Tables[0];
                dtvDatos.DataSource = lista;


            }
            else if (rbtnApellido.Checked)
            {
                var lista = obj.DevolverListaHistoriasClinicasPorApellido(parametro).Tables[0];
                dtvDatos.DataSource = lista;
            }
            else if (rbtnNombre.Checked)
            {
                var lista = obj.DevolverListaHistoriasClinicasPorNombre(parametro).Tables[0];
                dtvDatos.DataSource = lista;
            }
            else
            {
                cargarLista();
            }

        }
        public void cargarDatosParaModificar(DataGridViewCellEventArgs e)
        {
            txtNumHistClin.Text = dtvDatos.Rows[e.RowIndex].Cells["NUM_HIST_CLI"].Value.ToString();
            txtCedua.Text = dtvDatos.Rows[e.RowIndex].Cells["CEDULA"].Value.ToString();
            txtApellido1.Text = dtvDatos.Rows[e.RowIndex].Cells["APE1_PAC"].Value.ToString();
            txtApellido2.Text = dtvDatos.Rows[e.RowIndex].Cells["APE2_PAC"].Value.ToString();
            txtNombre1.Text = dtvDatos.Rows[e.RowIndex].Cells["NOM1_PAC"].Value.ToString();
            txtNombre2.Text = dtvDatos.Rows[e.RowIndex].Cells["NOM2_PAC"].Value.ToString();

            generoActual = dtvDatos.Rows[e.RowIndex].Cells["NOM_GEN"].Value.ToString();
            indexGeneroActual = cmbGenero.FindString(generoActual);

            txtOcupacion.Text = dtvDatos.Rows[e.RowIndex].Cells["OCU_PAC"].Value.ToString();

            dateFechaNacimiento.Text = dtvDatos.Rows[e.RowIndex].Cells["FECH_NAC_PAC"].Value.ToString();

            estadoCivilActual = dtvDatos.Rows[e.RowIndex].Cells["NOM_EST"].Value.ToString();
            indexEstadoCivilActual = cmbGenero.FindString(estadoCivilActual);
                
            etniaActual = dtvDatos.Rows[e.RowIndex].Cells["NOM_ETN"].Value.ToString();
            indexEtniaActual = cmbGenero.FindString(etniaActual);

            txtDireccion.Text = dtvDatos.Rows[e.RowIndex].Cells["DIR_PAC"].Value.ToString();

            ciudadActual = dtvDatos.Rows[e.RowIndex].Cells["NOM_CIU"].Value.ToString();
            indexciudadActual = cmbGenero.FindString(ciudadActual);

            txtTelefono.Text = dtvDatos.Rows[e.RowIndex].Cells["TELF_PAC"].Value.ToString();
        }
        private void ActualizarDatosPaciente()
        {
            HistoriaClinica persona = new HistoriaClinica();
            persona.Cedula= txtCedua.Text;
            persona.Apellido1= txtApellido1.Text;
            persona.Apellido2 = txtApellido2.Text;
            persona.Nombre1 = txtNombre1.Text;
            persona.Nombre2 = txtNombre2.Text;
            persona.Genero = Convert.ToInt32(cmbGenero.SelectedValue.ToString());
            persona.Ocupacion = txtOcupacion.Text;
            persona.Fecha_Nacimiento = dateFechaNacimiento.Value.ToString("dd/MM/yyyy");
            persona.EstadoCivil = cmbEstadoCivil.SelectedValue.ToString();
            persona.Etnia = cmbEtnia.SelectedValue.ToString();
            persona.Direccion = txtDireccion.Text;
            persona.Cod_Ciudad = comboBoxCiudades.SelectedValue.ToString();
            persona.Telefono = txtTelefono.Text;
            var resultado = HistoriaClinicaNegocio.ActualizarPersona(persona);
        }
        private void eliminarHistoria()
        {
           HistoriaClinica persona = new HistoriaClinica();
            persona.Cedula = txtCedua.Text;

            var resultado = HistoriaClinicaNegocio.EliminarPersona(persona);
        }



        #endregion

       
    }
}
