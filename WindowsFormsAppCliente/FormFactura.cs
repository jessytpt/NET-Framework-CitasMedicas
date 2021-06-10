using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsAppCliente
{
    public partial class FormFactura : Form
    {
        public FormFactura()
        {
            InitializeComponent();
        }

        
        private void FormFactura_Load(object sender, EventArgs e)
        {

        }
        #region Validacion
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


        private void txtNumFactura_KeyPress(object sender, KeyPressEventArgs e)
        {
            bloquearIngreso(e);
        }        

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
