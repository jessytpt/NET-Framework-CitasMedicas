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
    public partial class FormSignosVitales : Form
    {
        public FormSignosVitales()
        {
            InitializeComponent();
        }

        public Atencion AtencionSignos { get; set; }
        public string NumCita;
        public string NomPaciente;

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


        #region Puerto


        #endregion

        #region Metodos
        private void buscarCita()
        {
            FormBuscarCita buscaCitaMed = new FormBuscarCita();
            buscaCitaMed.ShowDialog();
            if (buscaCitaMed.NumCita!=null&buscaCitaMed.NomPaciente!=null)
            {
                txtNumCita.Text = buscaCitaMed.NumCita;
                txtInfoPaciente.Text = buscaCitaMed.NomPaciente;
            }
        }
      
        private void calculaIMC()
        {
            try
            {
                int imc = Convert.ToInt32(txtPeso.Text) / ((Convert.ToInt32(txtEstatura.Text) / 100) * (Convert.ToInt32(txtEstatura.Text) / 100));
                txtIMC.Text = imc.ToString();
                //MessageBox.Show("Peso: " + txtPeso.Text + " Estatura: " + txtEstatura.Text + "IMC "+ imc);
            }catch(Exception e)
            {
                MessageBox.Show(e.Message);
            }
        }

        private void guardarSignos()
        {
            try
            {
                Atencion nuevaAtencion = new Atencion();
                nuevaAtencion.Presion = txtPresion.Text;
                nuevaAtencion.Temperatura = txtTemperura.Text;
                nuevaAtencion.FrecuenciaCardiaca = txtFrecuenciaCardiaca.Text;
                nuevaAtencion.Peso = txtPeso.Text;
                nuevaAtencion.Estatura = txtEstatura.Text;
                nuevaAtencion.IMC = txtIMC.Text;
                NumCita = txtNumCita.Text;
                NomPaciente = txtInfoPaciente.Text;
                this.AtencionSignos = nuevaAtencion;
                MessageBox.Show("Los signos vitales se han guardado con éxito");
                this.Close();
            }
            catch (Exception e)
            {

                MessageBox.Show(e.Message);
            }
                                    

        }

        private bool validarDatos()
        {
            if (txtEstatura.Text.Equals("")
                | txtFrecuenciaCardiaca.Text.Equals("")
                | txtIMC.Text.Equals("")
                | txtPeso.Text.Equals("")
                |txtPresion.Text.Equals("")
                |txtTemperura.Text.Equals(""))
            {
                return false;
            }else
            {
                return true;
            }
        }

        private void limpiar()
        {
            txtEstatura.Text = "";
            txtFrecuenciaCardiaca.Text = "";
            txtIMC.Text = "";
            txtInfoPaciente.Text = "";
            txtNumCita.Text = "";
            txtPeso.Text = "";
            txtPresion.Text = "";
            txtTemperura.Text = "";

        }


        #endregion

        private void btnBuscarCita_Click(object sender, EventArgs e)
        {
            buscarCita();
        }

        private void txtNumCita_KeyPress(object sender, KeyPressEventArgs e)
        {
            bloquearIngreso(e);
        }

        private void txtInfoPaciente_KeyPress(object sender, KeyPressEventArgs e)
        {
            bloquearIngreso(e);
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (validarDatos())
            {
                guardarSignos();
                limpiar();

            }else
            {
                MessageBox.Show("Por favor ingrese los datos");
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtPeso_TextChanged(object sender, EventArgs e)
        {
           
        }

        private void txtEstatura_Leave(object sender, EventArgs e)
        {
            calculaIMC();
        }

        private void FormSignosVitales_Load(object sender, EventArgs e)
        {

        }
    }
}
