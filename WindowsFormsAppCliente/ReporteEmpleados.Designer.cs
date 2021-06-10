namespace WindowsFormsAppCliente
{
    partial class ReporteEmpleados
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource2 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.HOSPITAL3DataSet = new WindowsFormsAppCliente.HOSPITAL3DataSet();
            this.EMPLEADOBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.EMPLEADOTableAdapter = new WindowsFormsAppCliente.HOSPITAL3DataSetTableAdapters.EMPLEADOTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.HOSPITAL3DataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.EMPLEADOBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource2.Name = "DataSet1";
            reportDataSource2.Value = this.EMPLEADOBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource2);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "WindowsFormsAppCliente.Report1.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.Size = new System.Drawing.Size(575, 431);
            this.reportViewer1.TabIndex = 0;
            // 
            // HOSPITAL3DataSet
            // 
            this.HOSPITAL3DataSet.DataSetName = "HOSPITAL3DataSet";
            this.HOSPITAL3DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // EMPLEADOBindingSource
            // 
            this.EMPLEADOBindingSource.DataMember = "EMPLEADO";
            this.EMPLEADOBindingSource.DataSource = this.HOSPITAL3DataSet;
            // 
            // EMPLEADOTableAdapter
            // 
            this.EMPLEADOTableAdapter.ClearBeforeFill = true;
            // 
            // ReporteEmpleados
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(575, 431);
            this.Controls.Add(this.reportViewer1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ReporteEmpleados";
            this.Text = "ReporteEmpleados";
            this.Load += new System.EventHandler(this.ReporteEmpleados_Load);
            ((System.ComponentModel.ISupportInitialize)(this.HOSPITAL3DataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.EMPLEADOBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource EMPLEADOBindingSource;
        private HOSPITAL3DataSet HOSPITAL3DataSet;
        private HOSPITAL3DataSetTableAdapters.EMPLEADOTableAdapter EMPLEADOTableAdapter;
    }
}