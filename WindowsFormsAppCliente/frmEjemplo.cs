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
    public partial class frmEjemplo : Form
    {

        MedicamentosNegocio obj = new MedicamentosNegocio();
        public frmEjemplo()
        {
            InitializeComponent();

            var listaMedicamentos = obj.DevolverListaMedicamentos().Tables[0];
            dataGridView1.DataSource = listaMedicamentos;
            comboBox1.DataSource = listaMedicamentos;
            comboBox1.ValueMember = "COD_MED";
            comboBox1.DisplayMember = "NOM_MED";

        }

        private void button1_Click(object sender, EventArgs e)
        {
            var listaMedicamentos = obj.DevolverListaMedicamentos().Tables[0];
            dataGridView1.DataSource = listaMedicamentos;

        }

        private void button2_Click(object sender, EventArgs e)
        {
            MedicamentosNegocio obj = new MedicamentosNegocio();
            var lista = obj.DevolverListaMedicamentosPorNombre(textBox1.Text).Tables[0];
            dataGridView1.DataSource = lista;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            CiudadesNegocio obj = new CiudadesNegocio();

            var listaCiudades = obj.DevolverListaCiudades().Tables[0];
            dataGridView2.DataSource = listaCiudades;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            
            CiudadesNegocio obj = new CiudadesNegocio();
            var lista = obj.DevolverListaCiudadesPorNombre(textBox2.Text).Tables[0];
            dataGridView2.DataSource = lista;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            MedicamentosNegocio medicamentos = new MedicamentosNegocio();
            var lista = medicamentos.DevolverListaMedicamentosConStoreProcedure();
            dataGridView1.DataSource = lista.Tables[0];
        }

        private void comboBox1_MouseClick(object sender, MouseEventArgs e)
        {
            //textBox1
           // textBox3.Text = comboBox1.SelectedValue.ToString();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            textBox3.Text = comboBox1.SelectedValue.ToString();
        }
    }
}
