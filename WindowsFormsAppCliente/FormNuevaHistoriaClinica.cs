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
    public partial class FormNuevaHistoriaClinica : Form
    {

        #region Intanciaciones 
        GeneroNegocio genero = new GeneroNegocio();
        EstadoCivilNegocio obj = new EstadoCivilNegocio();
        CiudadesNegocio ciudades = new CiudadesNegocio();
        EtniasNegocio etnias = new EtniasNegocio();
        PatologiasNegocio patologias = new PatologiasNegocio();
        TraumasNegocio traumas = new TraumasNegocio();
        MedicamentosNegocio medicamentos = new MedicamentosNegocio();
        QuirurgicoNegocio quirurguicos = new QuirurgicoNegocio();
        HabitoNegocio habitos = new HabitoNegocio();
        HistoriaClinica nuevaHistoria = new HistoriaClinica();
        #endregion

        public FormNuevaHistoriaClinica()
        {
            InitializeComponent();
            catalogos();
            inicio();
        }

        private void txtNumHistClin_KeyPress(object sender, KeyPressEventArgs e)
        {
            bloquearIngreso(e);
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (validarDatos())
            {
                guardarHistoriaClinica();
                limpiar();
                inicio();
            }
            
        }
        
        private void btnAgregarAlergContacto_Click(object sender, EventArgs e)
        {
            agregarAlergiasContacto();
        }

        private void btnAgregarAlergInyeccion_Click(object sender, EventArgs e)
        {
            agregarAlergiasInyeccion();

        }

       #region Catálogos 
        //cargar catálogos en cada combobox
        public void catalogos()
        {
            var listaGeneros = genero.DevolverListaGenero().Tables[0].DefaultView;
            cmbGenero.DataSource = listaGeneros;
            cmbGenero.ValueMember = "COD_GEN";
            cmbGenero.DisplayMember = "NOM_GEN";

            var listaEstadiCivil = obj.DevolverListaEstadoCivil().Tables[0].DefaultView;
            cmbEstadoCivil.DataSource = listaEstadiCivil;
            cmbEstadoCivil.ValueMember = "COD_EST";
            cmbEstadoCivil.DisplayMember = "NOM_EST"; //display me permite selecionar el campo que se va a mostar en el combo box
                                                      //  cmbEstadoCivil.ValueMember = "COD_EST";
            var listaEtnias = etnias.DevolverListaEtnias().Tables[0].DefaultView;
            cmbEtnia.DataSource = listaEtnias;
            cmbEtnia.ValueMember = "COD_ETN";
            cmbEtnia.DisplayMember = "NOM_ETN";

            var listaCiudades = ciudades.DevolverListaCiudades().Tables[0].DefaultView;
            cmbCiudades.DataSource = listaCiudades;
            cmbCiudades.ValueMember = "COD_CIU";
            cmbCiudades.DisplayMember = "NOM_CIU";

            var listaPatologias = patologias.DevolverListaPatologias().Tables[0].DefaultView;
            cmbPatologias.DataSource = listaPatologias;
            cmbPatologias.ValueMember = "COD_PAT";
            cmbPatologias.DisplayMember = "NOM_PAT";

            var listaTraumas = traumas.DevolverListaTraumas().Tables[0].DefaultView;
            cmbTraumatismos.DataSource = listaTraumas;
            cmbTraumatismos.ValueMember = "COD_TRA";
            cmbTraumatismos.DisplayMember = "NOM_TRA";

            var listaMedicamentos = medicamentos.DevolverListaMedicamentos().Tables[0].DefaultView;
            cmbUsaMedicamentos.DataSource = listaMedicamentos;
            cmbUsaMedicamentos.ValueMember = "COD_MED";
            cmbUsaMedicamentos.DisplayMember = "NOM_MED";
            cmbAlergMedicamentos.DataSource = listaMedicamentos;
            cmbAlergMedicamentos.ValueMember = "COD_MED";
            cmbAlergMedicamentos.DisplayMember = "NOM_MED";

            var listaQuirurgicos = quirurguicos.DevolverListaQuirurgicos().Tables[0].DefaultView;
            cmbQuirurgicos.DataSource = listaQuirurgicos;
            cmbQuirurgicos.ValueMember = "COD_QUIR";
            cmbQuirurgicos.DisplayMember = "NOM_QUIR";

            var listaHabitos = habitos.DevolverListaHabitos().Tables[0].DefaultView;
            cmbHabitos.DataSource = listaHabitos;
            cmbHabitos.ValueMember = "COD_HAB";
            cmbHabitos.DisplayMember = "NOM_HAB";

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
        private void bloquearIngreso(KeyPressEventArgs e)
        {
            if (Char.IsLetterOrDigit(e.KeyChar) | Char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
            else
            {
                e.Handled = false;
            }

        }
        #endregion

        #region Métodos
        
        private void inicio()
        {
            txtCedua.Focus();
            cmbGenero.SelectedIndex = -1;
            cmbEstadoCivil.SelectedIndex = -1;
            cmbEtnia.SelectedIndex = -1;
            cmbCiudades.SelectedIndex = -1;
            cmbPatologias.SelectedIndex = -1;
            cmbTraumatismos.SelectedIndex = -1;
            cmbUsaMedicamentos.SelectedIndex = -1;
            cmbQuirurgicos.SelectedIndex = -1;
            cmbHabitos.SelectedIndex = -1;
            cmbAlergMedicamentos.SelectedIndex = -1;
            cmbPatologias.Enabled = false;
            cmbTraumatismos.Enabled = false;
            cmbUsaMedicamentos.Enabled = false;
            cmbQuirurgicos.Enabled = false;
            cmbHabitos.Enabled = false;
            cmbAlergMedicamentos.Enabled = false;
            txtAlergContacto.Enabled = false;
            btnAgregarAlergContacto.Enabled = false;
            txtAlergIngestion.Enabled = false;
            btnAgregarAlergIngestion.Enabled = false;
            txtAlergInyeccion.Enabled = false;
            btnAgregarAlergInyeccion.Enabled = false;
            txtAlergInhalacion.Enabled = false;
            btnAgregarAlergInhalacion.Enabled = false;
            btnRemoverPatologias.Enabled = false;
            btnRemoverTraumatismos.Enabled = false;
            btnRemoverUsaMedicamentos.Enabled = false;
            btnRemoverQuirurgicos.Enabled = false;
            btnRemoverHabitos.Enabled = false;
            btnRemoverAlergMedicamentos.Enabled = false;
            btnRemoverOtrasAlergias.Enabled = false;

        }

        private void habilitaPatologias()
        {
            if (checkPatologias.Checked)
            {
                cmbPatologias.Enabled = true;
            }
            else
            {
                cmbPatologias.Enabled = false;
            }
            
        }

        private void habilitarTraumatismos()
        {
            if (checkTraumatismos.Checked)
            {
                cmbTraumatismos.Enabled = true;
            }
            else
            {
                cmbTraumatismos.Enabled = false;
            }

        }

        private void habilitarMedicamentosQueUsa()
        {
            if (checkUsaMedicamentos.Checked)
            {
                cmbUsaMedicamentos.Enabled = true;
            }
            else
            {
                cmbUsaMedicamentos.Enabled = false;
            }

        }

        private void habilitarQuirurgicos()
        {
            if (checkQuirurgicos.Checked)
            {
                cmbQuirurgicos.Enabled = true;
            }
            else
            {
                cmbQuirurgicos.Enabled = false;
            }

        }

        private void habilitarHabitos()
        {
            if (checkHabitos.Checked)
            {
                cmbHabitos.Enabled = true;
            }
            else
            {
                cmbHabitos.Enabled = false;
            }

        }

        private void habilitarAlergiaMedicamentos()
        {
            if (checkAlergMedicamentos.Checked)
            {
                cmbAlergMedicamentos.Enabled = true;
            }
            else
            {
                cmbAlergMedicamentos.Enabled = false;
            }

        }

        private void habilitarAlergContacto()
        {
            if (checkAlergContacto.Checked)
            {
                txtAlergContacto.Enabled = true;
                btnAgregarAlergContacto.Enabled = true;
            }
            else
            {
                txtAlergContacto.Enabled = false;
                btnAgregarAlergContacto.Enabled = false;
            }

        }

        private void habilitarAlergIngestion()
        {
            if (checkAlergIngestion.Checked)
            {
                txtAlergIngestion.Enabled = true;
                btnAgregarAlergIngestion.Enabled = true;
            }
            else
            {
                txtAlergIngestion.Enabled = false;
                btnAgregarAlergIngestion.Enabled = false;
            }

        }

        private void habilitarAlergInyeccion()
        {
            if (checkAlergInyeccion.Checked)
            {
                txtAlergInyeccion.Enabled = true;
                btnAgregarAlergInyeccion.Enabled = true;
            }
            else
            {
                txtAlergInyeccion.Enabled = false;
                btnAgregarAlergInyeccion.Enabled = false;
            }

        }

        private void habilitarAlergInhalacion()
        {
            if (checkAlergInhalacion.Checked)
            {
                txtAlergInhalacion.Enabled = true;
                btnAgregarAlergInhalacion.Enabled = true;
            }
            else
            {
                txtAlergInhalacion.Enabled = false;
                btnAgregarAlergInhalacion.Enabled = false;
            }

        }

        private void agregarItemPatologias()
        {
            if (cmbPatologias.SelectedIndex != -1 & checkPatologias.Checked)
            {
                listPatologias.Items.Add(cmbPatologias.Text + "\n");
                cmbPatologias.SelectedIndex = -1;
            }
        }

        private void agregarItemTraumatismos()
        {
            if (cmbTraumatismos.SelectedIndex != -1 & checkTraumatismos.Checked)
            {
                listTraumatismos.Items.Add(cmbTraumatismos.Text + "\n");
                cmbTraumatismos.SelectedIndex = -1;
            }
        }

        private void agregarItemUsaMedicamentos()
        {
            if (cmbUsaMedicamentos.SelectedIndex != -1 & checkUsaMedicamentos.Checked)
            {
                listUsaMedicamentos.Items.Add(cmbUsaMedicamentos.Text + "\n");
                cmbUsaMedicamentos.SelectedIndex = -1;
            }
        }

        private void agregarItemQuirurgicos()
        {
            if (cmbQuirurgicos.SelectedIndex != -1 & checkQuirurgicos.Checked)
            {
                listQuirurgicos.Items.Add(cmbQuirurgicos.Text + "\n");
                cmbQuirurgicos.SelectedIndex = -1;
            }
        }

        private void agregarItemHabitos()
        {
            if (cmbHabitos.SelectedIndex != -1 & checkHabitos.Checked)
            {
                listHabitos.Items.Add(cmbHabitos.Text + "\n");
                cmbHabitos.SelectedIndex = -1;
            }
        }

        private void agregarItemAlergiaMedicamentos()
        {
            if (cmbAlergMedicamentos.SelectedIndex != -1 & checkAlergMedicamentos.Checked)
            {
                listAlergMedicamentos.Items.Add(cmbAlergMedicamentos.Text + "\n");
                cmbAlergMedicamentos.SelectedIndex = -1;
            }
        }

        private void agregarAlergiasContacto()
        {
            if (!txtAlergContacto.Text.Equals(""))
            {
                listOtrasAlergias.Items.Add(txtAlergContacto.Text + "\n");
                txtAlergContacto.Text = "";
            }
            else
            {
                MessageBox.Show("Por favor llenar la informacion");
                txtAlergContacto.Focus();
            }

        }

        private void agregarAlergiasIngestion()
        {
            if (!txtAlergIngestion.Text.Equals(""))
            {
                listOtrasAlergias.Items.Add(txtAlergIngestion.Text + "\n");
                txtAlergIngestion.Text = "";
            }
            else
            {
                MessageBox.Show("Por favor llenar la informacion");
                txtAlergIngestion.Focus();
            }

        }

        private void agregarAlergiasInyeccion()
        {
            if (!txtAlergInyeccion.Text.Equals(""))
            {
                listOtrasAlergias.Items.Add(txtAlergInyeccion.Text + "\n");
                txtAlergInyeccion.Text = "";
            }
            else
            {
                MessageBox.Show("Por favor llenar la informacion");
                txtAlergInyeccion.Focus();
            }

        }

        private void agregarAlergiasInhalacion()
        {
            if (!txtAlergInhalacion.Text.Equals(""))
            {
                listOtrasAlergias.Items.Add(txtAlergInhalacion.Text + "\n");
                txtAlergInhalacion.Text = "";
            }
            else
            {
                MessageBox.Show("Por favor llenar la informacion");
                txtAlergInhalacion.Focus();
            }

        }

        private void removerPatologias()
        {
            try
            {
                var indices = listPatologias.SelectedIndices;
                foreach (var item in indices)
                {
                    listPatologias.Items.RemoveAt(Convert.ToInt32(item.ToString()));
                }
                btnRemoverPatologias.Enabled = false;
            }
            catch (Exception e)
            {

                MessageBox.Show(e.Message);
            }
        }

        private void removerTraumatismos()
        {
            var indices = listTraumatismos.SelectedIndices;
            foreach (var item in indices)
            {
                listTraumatismos.Items.RemoveAt(Convert.ToInt32(item.ToString()));
            }
            btnRemoverTraumatismos.Enabled = false;
        }

        private void removerUsaMedicamentos()
        {
            var indices = listUsaMedicamentos.SelectedIndices;
            foreach (var item in indices)
            {
                listUsaMedicamentos.Items.RemoveAt(Convert.ToInt32(item.ToString()));
            }
            btnRemoverUsaMedicamentos.Enabled = false;
        }

        private void removerQuirurgicos()
        {
            var indices = listQuirurgicos.SelectedIndices;
            foreach (var item in indices)
            {
                listQuirurgicos.Items.RemoveAt(Convert.ToInt32(item.ToString()));
            }
            btnRemoverQuirurgicos.Enabled = false;
        }

        private void removerHabitos()
        {
            var indices = listHabitos.SelectedIndices;
            foreach (var item in indices)
            {
                listHabitos.Items.RemoveAt(Convert.ToInt32(item.ToString()));
            }
            btnRemoverHabitos.Enabled = false;
        }

        private void removerAlergiaMedicamentos()
        {
            var indices = listAlergMedicamentos.SelectedIndices;
            foreach (var item in indices)
            {
                listAlergMedicamentos.Items.RemoveAt(Convert.ToInt32(item.ToString()));
            }
            btnRemoverAlergMedicamentos.Enabled = false;
        }

        private void removerOtrasAlergias()
        {
            var indices = listOtrasAlergias.SelectedIndices;
            foreach (var item in indices)
            {
                listOtrasAlergias.Items.RemoveAt(Convert.ToInt32(item.ToString()));
            }
            btnRemoverOtrasAlergias.Enabled = false;
        }

        private void limpiar()
        {

            txtCedua.Text = "";
            txtApellido1.Text = "";
            txtApellido2.Text = "";
            txtNombre1.Text = "";
            txtNombre2.Text = "";
            txtOcupacion.Text = "";
            txtTelefono.Text = "";
            txtDireccion.Text = "";
            checkPatologias.Checked = false;
            listPatologias.Clear();
            checkTraumatismos.Checked = false;
            listTraumatismos.Clear();
            checkUsaMedicamentos.Checked = false;
            listUsaMedicamentos.Clear();
            checkQuirurgicos.Checked = false;
            listQuirurgicos.Clear();
            checkHabitos.Checked = false;
            listHabitos.Clear();
            checkAlergMedicamentos.Checked = false;
            listAlergMedicamentos.Clear();
            checkAlergContacto.Checked = false;
            checkAlergInyeccion.Checked = false;
            checkAlergIngestion.Checked = false;
            checkAlergInhalacion.Checked = false;
            listOtrasAlergias.Clear();
            cmbAlergMedicamentos.SelectedIndex = -1;
            cmbCiudades.SelectedIndex = -1;
            cmbEtnia.SelectedIndex = -1;
            cmbGenero.SelectedIndex = -1;
            cmbHabitos.SelectedIndex = -1;
            cmbPatologias.SelectedIndex = -1;
            cmbQuirurgicos.SelectedIndex = -1;
            cmbTraumatismos.SelectedIndex = -1;
            cmbUsaMedicamentos.SelectedIndex = -1;
            
        }
        
        private string guardarPatologias()
        {
            if (checkPatologias.Checked)
            {
                List<String> listaPatologias = new List<string>();
                foreach (var item in listPatologias.Items)
                {
                    listaPatologias.Add(item.ToString());
                }
                String patologias = String.Join(",", listaPatologias.ToArray());
                return patologias;
            }
            else
            {
                return "NINGUNA";
            }
        }

        private string guardarTraumatismos()
        {
            if (checkTraumatismos.Checked)
            {

                List<String> listaTraumatismos = new List<string>();
                foreach (var item in listTraumatismos.Items)
                {
                    listaTraumatismos.Add(item.ToString());
                }
                String traumas = String.Join(",", listaTraumatismos.ToArray());
                return traumas;
            }
            else
            {
                return "NINGUNO";
            }
        }

        private string guardarMedicamentosQueUsa()
        {
            if (checkUsaMedicamentos.Checked)
            {

                List<String> listaUsaMedicamentos = new List<string>();
                foreach (var item in listUsaMedicamentos.Items)
                {
                    listaUsaMedicamentos.Add(item.ToString());
                }
                String medicamentos = String.Join(",", listaUsaMedicamentos.ToArray());
                return medicamentos;
            }
            else
            {
                return "NINGUNO";
            }
        }

        private string guardarQuirurgicos()
        {
            if (checkQuirurgicos.Checked)
            {

                List<String> listaQuirurgicos = new List<string>();
                foreach (var item in listQuirurgicos.Items)
                {
                    listaQuirurgicos.Add(item.ToString());
                }
                String quirurgicos = String.Join(",", listaQuirurgicos.ToArray());
                return quirurgicos;
            }
            else
            {
                return "NINGUNO";
            }
        }

        private string guardarHabitos()
        {
            if (checkHabitos.Checked)
            {

                List<String> listaHabitos = new List<string>();
                foreach (var item in listHabitos.Items)
                {
                    listaHabitos.Add(item.ToString());
                }
                String habitos = String.Join(",", listaHabitos.ToArray());
                return habitos;
            }
            else
            {
                return "NINGUNO";
            }
        }

        private string guardarAlergiaMedicamentos()
        {
            if (checkAlergMedicamentos.Checked)
            {

                List<String> listaAlergiaMedicamentos = new List<string>();
                foreach (var item in listAlergMedicamentos.Items)
                {
                    listaAlergiaMedicamentos.Add(item.ToString());
                }
                String alergiasMedicamentos = String.Join(",", listaAlergiaMedicamentos.ToArray());
                return alergiasMedicamentos;
            }
            else
            {
                return "NINGUNO";
            }
        }

        private string guardarOtrasAlergias()
        {
            if (checkAlergContacto.Checked
                | checkAlergIngestion.Checked
                | checkAlergInhalacion.Checked
                | checkAlergInyeccion.Checked)
            {

                List<String> listaOtrasAlergia = new List<string>();
                foreach (var item in listOtrasAlergias.Items)
                {
                    listaOtrasAlergia.Add(item.ToString());
                }
                String otrasAlergias = String.Join(",", listaOtrasAlergia.ToArray());
                return otrasAlergias;
            }
            else
            {
                return "NINGUNA";
            }
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
                | cmbCiudades.SelectedIndex == -1
                | cmbEtnia.SelectedIndex == -1
                )
            {
                return false;
            }
            else
            {
                return true;
            }

        }

        private void guardarHistoriaClinica()
        {
            //Para guardar las listas en un sólo campo, guardar la lista 
            //como una cadena y cada item separado por una comas
            string patologias = guardarPatologias();
            string traumas = guardarTraumatismos();
            string medicamentos = guardarMedicamentosQueUsa();
            string quirurgicos = guardarQuirurgicos();
            string habitos = guardarHabitos();
            string alergiasMedicamentos = guardarAlergiaMedicamentos();
            string otrasAlergias = guardarOtrasAlergias();
            

            nuevaHistoria.Cedula = txtCedua.Text;
            nuevaHistoria.Nombre1 = txtNombre1.Text;
            nuevaHistoria.Nombre2 = txtNombre2.Text;
            nuevaHistoria.Apellido1 = txtApellido1.Text;
            nuevaHistoria.Apellido2 = txtApellido2.Text;
            nuevaHistoria.Genero = Convert.ToInt32(cmbGenero.SelectedValue.ToString());
            nuevaHistoria.Ocupacion = txtOcupacion.Text;
            nuevaHistoria.Fecha_Nacimiento = dateFechaNacimiento.Value.ToString("dd/MM/yyyy");
            nuevaHistoria.EstadoCivil = cmbEstadoCivil.SelectedValue.ToString();
            nuevaHistoria.Etnia = cmbEtnia.SelectedValue.ToString();
            nuevaHistoria.Direccion = txtDireccion.Text;
            nuevaHistoria.Cod_Ciudad = cmbCiudades.SelectedValue.ToString();
            nuevaHistoria.Telefono = txtTelefono.Text;
            nuevaHistoria.Patologias = patologias;
            nuevaHistoria.Traumatismos = traumas;
            nuevaHistoria.MedicamentosQueUsa = medicamentos;
            nuevaHistoria.Quirurgicos = quirurgicos;
            nuevaHistoria.Habitos = habitos;
            nuevaHistoria.AlergiaMedicamentos = alergiasMedicamentos;
            nuevaHistoria.OtrasAlergias = otrasAlergias;




            var resultado = HistoriaClinicaNegocio.GuardarHistoria(nuevaHistoria);
            if (resultado!=null)
            {
                MessageBox.Show("Datos ingresados correctamente");
            }
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

        private void txtOcupacion_KeyPress(object sender, KeyPressEventArgs e)
        {
            soloLetras(e);
        }

        private void txtTelefono_KeyPress(object sender, KeyPressEventArgs e)
        {
            soloNumeros(e);
        }

        private void txtAlergContacto_KeyPress(object sender, KeyPressEventArgs e)
        {
            soloLetras(e);
        }

        private void txtAlergInyeccion_KeyPress(object sender, KeyPressEventArgs e)
        {
            soloLetras(e);
        }

        private void txtAlergIngestion_KeyPress(object sender, KeyPressEventArgs e)
        {
            soloLetras(e);
        }

        private void txtAlergInhalacion_KeyPress(object sender, KeyPressEventArgs e)
        {
            soloLetras(e);
        }

        private void btnAgregarAlergIngestion_Click(object sender, EventArgs e)
        {
            agregarAlergiasIngestion();
        }

        private void btnAgregarAlergInhalacion_Click(object sender, EventArgs e)
        {
            agregarAlergiasInhalacion();
        }

        private void checkPatologias_CheckedChanged(object sender, EventArgs e)
        {
            habilitaPatologias();
        }

        private void checkTraumatismos_CheckedChanged(object sender, EventArgs e)
        {
            habilitarTraumatismos();
        }

        private void checkUsaMedicamentos_CheckedChanged(object sender, EventArgs e)
        {
            habilitarMedicamentosQueUsa();
        }

        private void checkQuirurgicos_CheckedChanged(object sender, EventArgs e)
        {
            habilitarQuirurgicos();
        }

        private void checkHabitos_CheckedChanged(object sender, EventArgs e)
        {
            habilitarHabitos();
        }

        private void checkAlergMedicamentos_CheckedChanged(object sender, EventArgs e)
        {
            habilitarAlergiaMedicamentos();
        }

        private void checkAlergContacto_CheckedChanged(object sender, EventArgs e)
        {
            habilitarAlergContacto();
        }

        private void checkAlergInyeccion_CheckedChanged(object sender, EventArgs e)
        {
            habilitarAlergInyeccion();
        }

        private void checkAlergIngestion_CheckedChanged(object sender, EventArgs e)
        {
            habilitarAlergIngestion();
        }

        private void checkAlergInhalacion_CheckedChanged(object sender, EventArgs e)
        {
            habilitarAlergInhalacion();
        }

        private void listPatologias_SelectedIndexChanged(object sender, EventArgs e)
        {
            btnRemoverPatologias.Enabled = true;
        }

        private void listTraumatismos_SelectedIndexChanged(object sender, EventArgs e)
        {
            btnRemoverTraumatismos.Enabled = true;
        }

        private void listUsaMedicamentos_SelectedIndexChanged(object sender, EventArgs e)
        {
            btnRemoverUsaMedicamentos.Enabled = true;
        }

        private void listQuirurgicos_SelectedIndexChanged(object sender, EventArgs e)
        {
            btnRemoverQuirurgicos.Enabled = true; 
        }

        private void listHabitos_SelectedIndexChanged(object sender, EventArgs e)
        {
            btnRemoverHabitos.Enabled = true;
        }

        private void listAlergMedicamentos_SelectedIndexChanged(object sender, EventArgs e)
        {
            btnRemoverAlergMedicamentos.Enabled = true;
        }

        private void listOtrasAlergias_SelectedIndexChanged(object sender, EventArgs e)
        {
            btnRemoverOtrasAlergias.Enabled = true;
        }

        private void btnReoverPatologias_Click(object sender, EventArgs e)
        {
            removerPatologias();
        }

        private void cmbPatologias_SelectedIndexChanged(object sender, EventArgs e)
        {
            agregarItemPatologias();            
        }

        private void cmbTraumatismos_SelectedIndexChanged(object sender, EventArgs e)
        {
            agregarItemTraumatismos();
        }

        private void cmbUsaMedicamentos_SelectedIndexChanged(object sender, EventArgs e)
        {
            agregarItemUsaMedicamentos();
        }

        private void cmbQuirurgicos_SelectedIndexChanged(object sender, EventArgs e)
        {
            agregarItemQuirurgicos();
        }

        private void cmbHabitos_SelectedIndexChanged(object sender, EventArgs e)
        {
            agregarItemHabitos();
        }

        private void cmbAlergMedicamentos_SelectedIndexChanged(object sender, EventArgs e)
        {
            agregarItemAlergiaMedicamentos();
        }

        private void btnRemoverTraumatismos_Click(object sender, EventArgs e)
        {
            removerTraumatismos();
        }

        private void btnRemoverUsaMedicamentos_Click(object sender, EventArgs e)
        {
            removerUsaMedicamentos();
        }

        private void btnRemoverQuirurgicos_Click(object sender, EventArgs e)
        {
            removerQuirurgicos();
        }

        private void btnRemoverHabitos_Click(object sender, EventArgs e)
        {
            removerHabitos();
        }

        private void btnRemoverAlergMedicamentos_Click(object sender, EventArgs e)
        {
            removerAlergiaMedicamentos();
        }

        private void btnRemoverOtrasAlergias_Click(object sender, EventArgs e)
        {
            removerOtrasAlergias();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
