namespace WindowsFormsAppCliente
{
    partial class FormBuscarCita
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
            this.dtvDatos = new System.Windows.Forms.DataGridView();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnAceptar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.labelMensaje = new System.Windows.Forms.Label();
            this.txtCadenaBuscar = new System.Windows.Forms.TextBox();
            this.lblFecha = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dtvDatos)).BeginInit();
            this.SuspendLayout();
            // 
            // dtvDatos
            // 
            this.dtvDatos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtvDatos.Location = new System.Drawing.Point(12, 96);
            this.dtvDatos.Name = "dtvDatos";
            this.dtvDatos.Size = new System.Drawing.Size(371, 239);
            this.dtvDatos.TabIndex = 11;
            this.dtvDatos.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtvDatos_CellClick);
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(233, 341);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(103, 36);
            this.btnCancelar.TabIndex = 14;
            this.btnCancelar.Text = "CANCELAR";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // btnAceptar
            // 
            this.btnAceptar.Location = new System.Drawing.Point(68, 341);
            this.btnAceptar.Name = "btnAceptar";
            this.btnAceptar.Size = new System.Drawing.Size(103, 36);
            this.btnAceptar.TabIndex = 13;
            this.btnAceptar.Text = "ACEPTAR";
            this.btnAceptar.UseVisualStyleBackColor = true;
            this.btnAceptar.Click += new System.EventHandler(this.btnAceptar_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Silver;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(12, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(103, 24);
            this.label1.TabIndex = 16;
            this.label1.Text = "Cédula N:";
            // 
            // labelMensaje
            // 
            this.labelMensaje.AutoSize = true;
            this.labelMensaje.ForeColor = System.Drawing.Color.Red;
            this.labelMensaje.Location = new System.Drawing.Point(24, 79);
            this.labelMensaje.Name = "labelMensaje";
            this.labelMensaje.Size = new System.Drawing.Size(174, 13);
            this.labelMensaje.TabIndex = 21;
            this.labelMensaje.Text = "No se encontraron resultados";
            this.labelMensaje.Visible = false;
            // 
            // txtCadenaBuscar
            // 
            this.txtCadenaBuscar.Location = new System.Drawing.Point(148, 32);
            this.txtCadenaBuscar.MaxLength = 10;
            this.txtCadenaBuscar.Name = "txtCadenaBuscar";
            this.txtCadenaBuscar.Size = new System.Drawing.Size(235, 20);
            this.txtCadenaBuscar.TabIndex = 20;
            this.txtCadenaBuscar.TextChanged += new System.EventHandler(this.txtCadenaBuscar_TextChanged);
            this.txtCadenaBuscar.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtCadenaBuscar_KeyPress);
            // 
            // lblFecha
            // 
            this.lblFecha.AutoSize = true;
            this.lblFecha.BackColor = System.Drawing.Color.Transparent;
            this.lblFecha.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFecha.ForeColor = System.Drawing.Color.White;
            this.lblFecha.Location = new System.Drawing.Point(314, 68);
            this.lblFecha.Name = "lblFecha";
            this.lblFecha.Size = new System.Drawing.Size(69, 24);
            this.lblFecha.TabIndex = 22;
            this.lblFecha.Text = "Fecha";
            // 
            // FormBuscarCita
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::WindowsFormsAppCliente.Properties.Resources.FondoMedicina2;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(433, 389);
            this.Controls.Add(this.lblFecha);
            this.Controls.Add(this.labelMensaje);
            this.Controls.Add(this.txtCadenaBuscar);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnAceptar);
            this.Controls.Add(this.dtvDatos);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "FormBuscarCita";
            this.Text = "Lista Citas Medicas";
            ((System.ComponentModel.ISupportInitialize)(this.dtvDatos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridView dtvDatos;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnAceptar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label labelMensaje;
        private System.Windows.Forms.TextBox txtCadenaBuscar;
        private System.Windows.Forms.Label lblFecha;
    }
}