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
    public partial class EscanearImagen : Form
    {
        public EscanearImagen()
        {
            InitializeComponent();
            panelOriginal.Visible = false;
            panelRuido.Visible = false;
            panelSegmentar.Visible = false;
        }

        private void btnEscanear_Click(object sender, EventArgs e)
        {
            panelOriginal.Visible = true;
        }

        private void btnProcesar_Click(object sender, EventArgs e)
        {
            Form1 procesar = new Form1();
            procesar.ShowDialog();
        }

        private void btnEliminarRuido_Click(object sender, EventArgs e)
        {
            panelRuido.Visible = true;
        }

        private void btnSegmentar_Click(object sender, EventArgs e)
        {
            panelSegmentar.Visible = true;
        }
    }
}
