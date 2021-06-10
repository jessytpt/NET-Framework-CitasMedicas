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
    public partial class FormAgenda : Form
    {
        public string FechaSeleccionada { get; set; }
        public FormAgenda()
        {
            InitializeComponent();
        }

        private void seleccionarFecha()
        {
            var fecha = monthCalendar1.SelectionEnd.ToShortDateString();
            this.FechaSeleccionada = fecha;
            //MessageBox.Show("La fecha es: " + fecha);
            this.Close();
        }

        private void monthCalendar1_DateChanged(object sender, DateRangeEventArgs e)
        {
            seleccionarFecha();
        }

        private void btnAtras_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
