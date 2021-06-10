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
    public partial class ReporteEmpleados : Form
    {
        public ReporteEmpleados()
        {
            InitializeComponent();
        }

        private void ReporteEmpleados_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'HOSPITAL3DataSet.EMPLEADO' table. You can move, or remove it, as needed.
            this.EMPLEADOTableAdapter.Fill(this.HOSPITAL3DataSet.EMPLEADO);

            this.reportViewer1.RefreshReport();
        }
    }
}
