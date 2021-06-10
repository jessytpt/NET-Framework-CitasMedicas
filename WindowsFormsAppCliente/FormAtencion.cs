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
    public partial class FormAtencion : Form
    {
        public Usuario usuarioAtencion { get; set; }

        public FormAtencion()
        {
            InitializeComponent();
            
        }

        public FormAtencion(Usuario usuario)
        {
            InitializeComponent();
            this.usuarioAtencion = usuario;
            inicio();
            
        }

        string horaInicioAtencion;
        

        #region Validacion
        private void soloNumeros(KeyPressEventArgs e)
        {
            if (Char.IsDigit(e.KeyChar) | Char.IsControl(e.KeyChar))
            {
                e.Handled = false;
            }else
            {
                e.Handled = true;
            }
        }
        private void bloquearIngreso(KeyPressEventArgs e)
        {
            if (Char.IsLetterOrDigit(e.KeyChar) | Char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }else
            {
                e.Handled = false;
            }

        }

        #endregion

        private void inicio()
        {
            desbloquearUsuario(usuarioAtencion);
            horaInicioAtencion = DateTime.Now.ToShortTimeString();
        }


        #region Metodos

        private void buscarCita()
        {
            FormBuscarCita buscaCitaMed = new FormBuscarCita();
            buscaCitaMed.ShowDialog();
            if (buscaCitaMed.NumCita != null & buscaCitaMed.NomPaciente != null)
            {
                txtNumCita.Text = buscaCitaMed.NumCita;
                txtInfoPaciente.Text = buscaCitaMed.NomPaciente;
            }
        }

        public void desbloquearUsuario(Usuario usuario)
        {
            if (usuario.TipoUsuario.Equals("AUXILIAR"))
            {
                panelSintomas.Visible = false;
                panelDiagnostico.Visible = false;
                panelReceta.Visible = false;
                panelTratamiento.Visible = false;
            }
            else if (usuario.TipoUsuario.Equals("ADMINISTRADOR"))
            {
                panelSintomas.Visible = true;
                panelDiagnostico.Visible = true;
                panelReceta.Visible = true;
                panelTratamiento.Visible = true;
            }
        }

        public void guardar(Usuario usuario)
        {
            if (usuario.TipoUsuario.Equals("ADMINISTRADOR"))
            {
                string horaFinAtencion = DateTime.Now.ToShortTimeString();
                Atencion nuevaAtencion = new Atencion();
                nuevaAtencion.Estatura = txtEstatura.Text;
                nuevaAtencion.Peso = txtPeso.Text;
                nuevaAtencion.Presion = txtPresion.Text;
                nuevaAtencion.FrecuenciaCardiaca = txtFrecuenciaCardiaca.Text;
                nuevaAtencion.HoraInicioAtencion = horaInicioAtencion;
                nuevaAtencion.HoraFinAtencion = horaFinAtencion;
                
            }
            else if (usuario.TipoUsuario.Equals("AUXILIAR"))
            {
                panelSintomas.Visible = true;
                panelDiagnostico.Visible = true;
                panelReceta.Visible = true;
                panelTratamiento.Visible = true;
            }
        }

        private void calculaIMC()
        {
            try
            {
                int imc = Convert.ToInt32(txtPeso.Text) / ((Convert.ToInt32(txtEstatura.Text) / 100) * (Convert.ToInt32(txtEstatura.Text) / 100));
                txtIMC.Text = imc.ToString();
                //MessageBox.Show("Peso: " + txtPeso.Text + " Estatura: " + txtEstatura.Text + "IMC "+ imc);
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }
        }

        private void agregarsintomas()
        {
            if (!txtSintomas.Text.Equals(""))
            {
                listSintomas.Items.Add(txtSintomas.Text + "\n");
                txtSintomas.Text = "";
            }
            else
            {
                MessageBox.Show("Por favor llenar la informacion");
                txtSintomas.Focus();
            }

        }

        private void agregarItemMedicamentos()
        {
            if (cmbMedicamentosReceta.SelectedIndex != -1 |!txtCantMedReceta.Text.Equals("")|!txtDosisReceta.Text.Equals("") )
            {
                string receta = cmbMedicamentosReceta.Text + "," + txtCantMedReceta.Text + "," + txtDosisReceta.Text;
                listReceta.Items.Add(receta);
                cmbMedicamentosReceta.SelectedIndex = -1;
                txtDosisReceta.Text = "";
                txtCantMedReceta.Text="";
            }else
            {
                MessageBox.Show("Por favor llenar la informacion");

            }
        }

        private void removerMedicamentosReceta()
        {
            var indices = listReceta.SelectedIndices;
            foreach (var item in indices)
            {
                listReceta.Items.RemoveAt(Convert.ToInt32(item.ToString()));
            }
            btnRemoverMedReceta.Enabled = false;
        }

        private void removerSintomas()
        {
            var indices = listSintomas.SelectedIndices;
            foreach (var item in indices)
            {
                listSintomas.Items.RemoveAt(Convert.ToInt32(item.ToString()));
            }
            btnRemoverSintomas.Enabled = false;
        }

        private string guardarSintomas()
        {
            if (listSintomas.Items.Count!=0)
            {
                List<String> listaSintomas1 = new List<string>();
                foreach (var item in listSintomas.Items)
                {
                    listaSintomas1.Add(item.ToString());
                }
                String sintomas = String.Join(",", listaSintomas1.ToArray());
                return sintomas;
            }
            else
            {
                return "NINGUNO";
            }
        }

        private string guardarMedicamentos()
        {
            if (listReceta.Items.Count != 0)
            {
                List<String> listaMedicamentos = new List<string>();
                foreach (var item in listReceta.Items)
                {
                    listaMedicamentos.Add(item.ToString());
                }
                String medicamentos = String.Join(",", listaMedicamentos.ToArray());
                return medicamentos;
            }
            else
            {
                return "NINGUNO";
            }
        }

        private bool validarDatos()
        {
            if (txtCantMedReceta.Text.Equals("")
                | txtFrecuenciaCardiaca.Equals("")
                | txtPeso.Text.Equals("")
                | txtPresion.Text.Equals("")
                | txtEstatura.Text.Equals("")
                | txtIMC.Text.Equals("")
                | listReceta.Items.Count == 0
                | listSintomas.Items.Count==0
                | txtDiagnostico.Text.Equals("")
                | txtRecetaIndicaiones.Equals("")
                )
            {
                return false;
            }
            else
            {
                
                return true;
            }

        }

        private void guardarAtencion()
        {
            Atencion nuevaAtencion = new Atencion();
            Tratamiento nuevoTratamiento = new Tratamiento();
            string horaFinAtencion = DateTime.Now.ToShortTimeString();
            string Sintomas = guardarSintomas();
            string Receta = guardarMedicamentos();
            nuevaAtencion.NumAtencion = txtNumCita.Text;
            nuevaAtencion.HoraInicioAtencion = horaInicioAtencion;
            nuevaAtencion.HoraFinAtencion = horaFinAtencion;
            nuevaAtencion.FrecuenciaCardiaca = txtFrecuenciaCardiaca.Text;
            nuevaAtencion.Peso = txtPeso.Text;
            nuevaAtencion.Presion = txtPresion.Text;
            nuevaAtencion.IMC = txtIMC.Text;
            nuevaAtencion.Sintomas = Sintomas;
            nuevaAtencion.Temperatura = txtTemperura.Text;
            nuevaAtencion.Diagnostico = txtDiagnostico.Text;
            nuevaAtencion.Estatura = txtEstatura.Text;
            nuevaAtencion.NumAtencion = txtNumCita.Text;
            nuevoTratamiento.NumTratamiento = txtNumCita.Text;
            nuevoTratamiento.NumAtencion = txtNumCita.Text;
            nuevoTratamiento.Receta = Receta;
            nuevoTratamiento.Indicaciones = txtRecetaIndicaiones.Text;
            nuevoTratamiento.ContraIndicaciones = txtRecetaContraIndicaciones.Text;

            var atencion = AtencionNegocio.GuardarAtencion(nuevaAtencion);
            var tratamiento = AtencionNegocio.GuardarTratamiento(nuevoTratamiento);




        }


        #endregion

        private void richTextBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtNumCita_KeyPress(object sender, KeyPressEventArgs e)
        {
            bloquearIngreso(e);
        }

        private void btnBuscarCita_Click(object sender, EventArgs e)
        {
            buscarCita();
        }

        private void btnAgregarSintomas_Click(object sender, EventArgs e)
        {
            agregarsintomas();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            agregarItemMedicamentos();
        }

        private void btnRemoverSintomas_Click(object sender, EventArgs e)
        {
            removerSintomas();
        }

        private void btnRemoverMedReceta_Click(object sender, EventArgs e)
        {
            removerMedicamentosReceta();
        }

        private void listReceta_SelectedIndexChanged(object sender, EventArgs e)
        {
            btnRemoverMedReceta.Enabled = true;
        }

        private void listSintomas_SelectedIndexChanged(object sender, EventArgs e)
        {
            btnRemoverSintomas.Enabled = true;
        }

        private void btnFinalizar_Click(object sender, EventArgs e)
        {
            if (validarDatos())
            {
                guardarAtencion();
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtIMC_Enter(object sender, EventArgs e)
        {
            calculaIMC();
        }
    }
}
