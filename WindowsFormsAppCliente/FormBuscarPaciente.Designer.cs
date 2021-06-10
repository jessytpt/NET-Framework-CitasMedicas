namespace WindowsFormsAppCliente
{
    partial class FormBuscarPaciente
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.labelMensaje = new System.Windows.Forms.Label();
            this.rbtnNombre = new System.Windows.Forms.RadioButton();
            this.rtbnNumHistoriaClinica = new System.Windows.Forms.RadioButton();
            this.rbtnApellido = new System.Windows.Forms.RadioButton();
            this.rbtnCedula = new System.Windows.Forms.RadioButton();
            this.txtCadenaBuscar = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dtvDatos = new System.Windows.Forms.DataGridView();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnAceptar = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtvDatos)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.dtvDatos);
            this.panel1.Location = new System.Drawing.Point(4, 4);
            this.panel1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(762, 433);
            this.panel1.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.WhiteSmoke;
            this.panel2.Controls.Add(this.labelMensaje);
            this.panel2.Controls.Add(this.rbtnNombre);
            this.panel2.Controls.Add(this.rtbnNumHistoriaClinica);
            this.panel2.Controls.Add(this.rbtnApellido);
            this.panel2.Controls.Add(this.rbtnCedula);
            this.panel2.Controls.Add(this.txtCadenaBuscar);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Location = new System.Drawing.Point(5, 5);
            this.panel2.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(745, 158);
            this.panel2.TabIndex = 9;
            // 
            // labelMensaje
            // 
            this.labelMensaje.AutoSize = true;
            this.labelMensaje.ForeColor = System.Drawing.Color.Red;
            this.labelMensaje.Location = new System.Drawing.Point(29, 116);
            this.labelMensaje.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.labelMensaje.Name = "labelMensaje";
            this.labelMensaje.Size = new System.Drawing.Size(196, 15);
            this.labelMensaje.TabIndex = 10;
            this.labelMensaje.Text = "No se encontraron resultados";
            this.labelMensaje.Visible = false;
            // 
            // rbtnNombre
            // 
            this.rbtnNombre.AutoSize = true;
            this.rbtnNombre.Location = new System.Drawing.Point(594, 51);
            this.rbtnNombre.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.rbtnNombre.Name = "rbtnNombre";
            this.rbtnNombre.Size = new System.Drawing.Size(76, 19);
            this.rbtnNombre.TabIndex = 3;
            this.rbtnNombre.TabStop = true;
            this.rbtnNombre.Text = "Nombre";
            this.rbtnNombre.UseVisualStyleBackColor = true;
            // 
            // rtbnNumHistoriaClinica
            // 
            this.rtbnNumHistoriaClinica.AutoSize = true;
            this.rtbnNumHistoriaClinica.Location = new System.Drawing.Point(12, 51);
            this.rtbnNumHistoriaClinica.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.rtbnNumHistoriaClinica.Name = "rtbnNumHistoriaClinica";
            this.rtbnNumHistoriaClinica.Size = new System.Drawing.Size(198, 19);
            this.rtbnNumHistoriaClinica.TabIndex = 0;
            this.rtbnNumHistoriaClinica.TabStop = true;
            this.rtbnNumHistoriaClinica.Text = "Número de Historia Clínica";
            this.rtbnNumHistoriaClinica.UseVisualStyleBackColor = true;
            // 
            // rbtnApellido
            // 
            this.rbtnApellido.AutoSize = true;
            this.rbtnApellido.Location = new System.Drawing.Point(457, 51);
            this.rbtnApellido.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.rbtnApellido.Name = "rbtnApellido";
            this.rbtnApellido.Size = new System.Drawing.Size(77, 19);
            this.rbtnApellido.TabIndex = 2;
            this.rbtnApellido.TabStop = true;
            this.rbtnApellido.Text = "Apellido";
            this.rbtnApellido.UseVisualStyleBackColor = true;
            // 
            // rbtnCedula
            // 
            this.rbtnCedula.AutoSize = true;
            this.rbtnCedula.Location = new System.Drawing.Point(283, 51);
            this.rbtnCedula.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.rbtnCedula.Name = "rbtnCedula";
            this.rbtnCedula.Size = new System.Drawing.Size(70, 19);
            this.rbtnCedula.TabIndex = 1;
            this.rbtnCedula.TabStop = true;
            this.rbtnCedula.Text = "Cédula";
            this.rbtnCedula.UseVisualStyleBackColor = true;
            // 
            // txtCadenaBuscar
            // 
            this.txtCadenaBuscar.Location = new System.Drawing.Point(12, 84);
            this.txtCadenaBuscar.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.txtCadenaBuscar.Name = "txtCadenaBuscar";
            this.txtCadenaBuscar.Size = new System.Drawing.Size(701, 21);
            this.txtCadenaBuscar.TabIndex = 4;
            this.txtCadenaBuscar.TextChanged += new System.EventHandler(this.txtCadenaBuscar_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(5, 14);
            this.label1.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(111, 15);
            this.label1.TabIndex = 4;
            this.label1.Text = "Buscar Paciente";
            // 
            // dtvDatos
            // 
            this.dtvDatos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtvDatos.Location = new System.Drawing.Point(5, 171);
            this.dtvDatos.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.dtvDatos.Name = "dtvDatos";
            this.dtvDatos.Size = new System.Drawing.Size(745, 254);
            this.dtvDatos.TabIndex = 8;
            this.dtvDatos.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtvDatos_CellClick);
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(391, 444);
            this.btnCancelar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(117, 41);
            this.btnCancelar.TabIndex = 13;
            this.btnCancelar.Text = "CANCELAR";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // btnAceptar
            // 
            this.btnAceptar.Location = new System.Drawing.Point(229, 444);
            this.btnAceptar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnAceptar.Name = "btnAceptar";
            this.btnAceptar.Size = new System.Drawing.Size(117, 41);
            this.btnAceptar.TabIndex = 14;
            this.btnAceptar.Text = "ACEPTAR";
            this.btnAceptar.UseVisualStyleBackColor = true;
            this.btnAceptar.Click += new System.EventHandler(this.btnAceptar_Click);
            // 
            // FormBuscarPaciente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(782, 497);
            this.Controls.Add(this.btnAceptar);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormBuscarPaciente";
            this.Text = "FormBuscarPaciente";
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtvDatos)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label labelMensaje;
        private System.Windows.Forms.RadioButton rbtnNombre;
        private System.Windows.Forms.RadioButton rtbnNumHistoriaClinica;
        private System.Windows.Forms.RadioButton rbtnApellido;
        private System.Windows.Forms.RadioButton rbtnCedula;
        private System.Windows.Forms.TextBox txtCadenaBuscar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dtvDatos;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnAceptar;
    }
}