namespace WindowsFormsAppCliente
{
    partial class FormBuscarMedico
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
            this.labelMensaje = new System.Windows.Forms.Label();
            this.rbtnNombre = new System.Windows.Forms.RadioButton();
            this.rbtnApellido = new System.Windows.Forms.RadioButton();
            this.rbtnCedula = new System.Windows.Forms.RadioButton();
            this.txtCadenaBuscar = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dtvDatos = new System.Windows.Forms.DataGridView();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnAceptar = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtvDatos)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.panel1.Controls.Add(this.labelMensaje);
            this.panel1.Controls.Add(this.rbtnNombre);
            this.panel1.Controls.Add(this.rbtnApellido);
            this.panel1.Controls.Add(this.rbtnCedula);
            this.panel1.Controls.Add(this.txtCadenaBuscar);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(3, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(467, 111);
            this.panel1.TabIndex = 9;
            // 
            // labelMensaje
            // 
            this.labelMensaje.AutoSize = true;
            this.labelMensaje.ForeColor = System.Drawing.Color.Red;
            this.labelMensaje.Location = new System.Drawing.Point(15, 82);
            this.labelMensaje.Name = "labelMensaje";
            this.labelMensaje.Size = new System.Drawing.Size(146, 13);
            this.labelMensaje.TabIndex = 10;
            this.labelMensaje.Text = "No se encontraron resultados";
            this.labelMensaje.Visible = false;
            // 
            // rbtnNombre
            // 
            this.rbtnNombre.AutoSize = true;
            this.rbtnNombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbtnNombre.Location = new System.Drawing.Point(181, 36);
            this.rbtnNombre.Name = "rbtnNombre";
            this.rbtnNombre.Size = new System.Drawing.Size(68, 17);
            this.rbtnNombre.TabIndex = 2;
            this.rbtnNombre.TabStop = true;
            this.rbtnNombre.Text = "Nombre";
            this.rbtnNombre.UseVisualStyleBackColor = true;
            // 
            // rbtnApellido
            // 
            this.rbtnApellido.AutoSize = true;
            this.rbtnApellido.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbtnApellido.Location = new System.Drawing.Point(87, 36);
            this.rbtnApellido.Name = "rbtnApellido";
            this.rbtnApellido.Size = new System.Drawing.Size(70, 17);
            this.rbtnApellido.TabIndex = 1;
            this.rbtnApellido.TabStop = true;
            this.rbtnApellido.Text = "Apellido";
            this.rbtnApellido.UseVisualStyleBackColor = true;
            // 
            // rbtnCedula
            // 
            this.rbtnCedula.AutoSize = true;
            this.rbtnCedula.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbtnCedula.Location = new System.Drawing.Point(6, 36);
            this.rbtnCedula.Name = "rbtnCedula";
            this.rbtnCedula.Size = new System.Drawing.Size(64, 17);
            this.rbtnCedula.TabIndex = 0;
            this.rbtnCedula.TabStop = true;
            this.rbtnCedula.Text = "Cédula";
            this.rbtnCedula.UseVisualStyleBackColor = true;
            // 
            // txtCadenaBuscar
            // 
            this.txtCadenaBuscar.Location = new System.Drawing.Point(6, 59);
            this.txtCadenaBuscar.Name = "txtCadenaBuscar";
            this.txtCadenaBuscar.Size = new System.Drawing.Size(450, 20);
            this.txtCadenaBuscar.TabIndex = 4;
            this.txtCadenaBuscar.TextChanged += new System.EventHandler(this.txtCadenaBuscar_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(3, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(111, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Buscar Empleados";
            // 
            // dtvDatos
            // 
            this.dtvDatos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtvDatos.Location = new System.Drawing.Point(3, 120);
            this.dtvDatos.Name = "dtvDatos";
            this.dtvDatos.Size = new System.Drawing.Size(467, 179);
            this.dtvDatos.TabIndex = 8;
            this.dtvDatos.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtvDatos_CellClick);
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.panel1);
            this.panel2.Controls.Add(this.dtvDatos);
            this.panel2.Location = new System.Drawing.Point(12, 12);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(476, 306);
            this.panel2.TabIndex = 10;
            // 
            // btnAceptar
            // 
            this.btnAceptar.Location = new System.Drawing.Point(134, 324);
            this.btnAceptar.Name = "btnAceptar";
            this.btnAceptar.Size = new System.Drawing.Size(88, 36);
            this.btnAceptar.TabIndex = 11;
            this.btnAceptar.Text = "ACEPTAR";
            this.btnAceptar.UseVisualStyleBackColor = true;
            this.btnAceptar.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(275, 324);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(88, 36);
            this.btnCancelar.TabIndex = 12;
            this.btnCancelar.Text = "CANCELAR";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // FormBuscarMedico
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(509, 364);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnAceptar);
            this.Controls.Add(this.panel2);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormBuscarMedico";
            this.Text = "FormBuscarMedico";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtvDatos)).EndInit();
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label labelMensaje;
        private System.Windows.Forms.RadioButton rbtnNombre;
        private System.Windows.Forms.RadioButton rbtnApellido;
        private System.Windows.Forms.RadioButton rbtnCedula;
        private System.Windows.Forms.TextBox txtCadenaBuscar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dtvDatos;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnAceptar;
        private System.Windows.Forms.Button btnCancelar;
    }
}