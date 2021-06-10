namespace WindowsFormsAppCliente
{
    partial class FormAdministrarUsuarios
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormAdministrarUsuarios));
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.label3 = new System.Windows.Forms.Label();
            this.txtCedua = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtApellido1 = new System.Windows.Forms.TextBox();
            this.txtNombre1 = new System.Windows.Forms.TextBox();
            this.txtApellido2 = new System.Windows.Forms.TextBox();
            this.txtNombre2 = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.txtNombreUsuario = new System.Windows.Forms.TextBox();
            this.txtContraseña = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtConfirmaClave = new System.Windows.Forms.TextBox();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.btnModificar = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.dtvDatos = new System.Windows.Forms.DataGridView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.txtCadenaBuscar = new System.Windows.Forms.TextBox();
            this.rbtnNombreUsuario = new System.Windows.Forms.RadioButton();
            this.rbtnTipoUsuario = new System.Windows.Forms.RadioButton();
            this.labelMensaje = new System.Windows.Forms.Label();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage2.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtvDatos)).BeginInit();
            this.panel1.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.btnGuardar);
            this.tabPage2.Controls.Add(this.btnCancelar);
            this.tabPage2.Controls.Add(this.txtConfirmaClave);
            this.tabPage2.Controls.Add(this.txtNombreUsuario);
            this.tabPage2.Controls.Add(this.txtNombre2);
            this.tabPage2.Controls.Add(this.txtApellido2);
            this.tabPage2.Controls.Add(this.txtNombre1);
            this.tabPage2.Controls.Add(this.txtApellido1);
            this.tabPage2.Controls.Add(this.txtCedua);
            this.tabPage2.Controls.Add(this.label1);
            this.tabPage2.Controls.Add(this.txtContraseña);
            this.tabPage2.Controls.Add(this.label15);
            this.tabPage2.Controls.Add(this.label14);
            this.tabPage2.Controls.Add(this.label5);
            this.tabPage2.Controls.Add(this.label4);
            this.tabPage2.Controls.Add(this.label3);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(486, 410);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Cambiar Contraseña";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.White;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(120, 34);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(85, 16);
            this.label3.TabIndex = 9;
            this.label3.Text = "Cédula N° :";
            // 
            // txtCedua
            // 
            this.txtCedua.Location = new System.Drawing.Point(222, 33);
            this.txtCedua.Name = "txtCedua";
            this.txtCedua.Size = new System.Drawing.Size(206, 20);
            this.txtCedua.TabIndex = 0;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.White;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(123, 60);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(82, 16);
            this.label4.TabIndex = 15;
            this.label4.Text = "Apellidos :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.White;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(126, 90);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(79, 16);
            this.label5.TabIndex = 14;
            this.label5.Text = "Nombres :";
            // 
            // txtApellido1
            // 
            this.txtApellido1.Location = new System.Drawing.Point(222, 59);
            this.txtApellido1.Name = "txtApellido1";
            this.txtApellido1.Size = new System.Drawing.Size(100, 20);
            this.txtApellido1.TabIndex = 1;
            // 
            // txtNombre1
            // 
            this.txtNombre1.Location = new System.Drawing.Point(222, 89);
            this.txtNombre1.Name = "txtNombre1";
            this.txtNombre1.Size = new System.Drawing.Size(100, 20);
            this.txtNombre1.TabIndex = 3;
            // 
            // txtApellido2
            // 
            this.txtApellido2.Location = new System.Drawing.Point(328, 59);
            this.txtApellido2.Name = "txtApellido2";
            this.txtApellido2.Size = new System.Drawing.Size(100, 20);
            this.txtApellido2.TabIndex = 2;
            // 
            // txtNombre2
            // 
            this.txtNombre2.Location = new System.Drawing.Point(328, 89);
            this.txtNombre2.Name = "txtNombre2";
            this.txtNombre2.Size = new System.Drawing.Size(100, 20);
            this.txtNombre2.TabIndex = 4;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.BackColor = System.Drawing.Color.White;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(58, 119);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(147, 16);
            this.label14.TabIndex = 32;
            this.label14.Text = "Nombre de Usuario:";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.BackColor = System.Drawing.Color.White;
            this.label15.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.Location = new System.Drawing.Point(110, 146);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(95, 16);
            this.label15.TabIndex = 33;
            this.label15.Text = "Contraseña :";
            // 
            // txtNombreUsuario
            // 
            this.txtNombreUsuario.Location = new System.Drawing.Point(222, 118);
            this.txtNombreUsuario.Name = "txtNombreUsuario";
            this.txtNombreUsuario.Size = new System.Drawing.Size(200, 20);
            this.txtNombreUsuario.TabIndex = 5;
            // 
            // txtContraseña
            // 
            this.txtContraseña.Location = new System.Drawing.Point(222, 145);
            this.txtContraseña.Name = "txtContraseña";
            this.txtContraseña.Size = new System.Drawing.Size(200, 20);
            this.txtContraseña.TabIndex = 6;
            this.txtContraseña.UseSystemPasswordChar = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.White;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(40, 179);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(165, 16);
            this.label1.TabIndex = 36;
            this.label1.Text = "Confirmar Contraseña :";
            // 
            // txtConfirmaClave
            // 
            this.txtConfirmaClave.Location = new System.Drawing.Point(222, 178);
            this.txtConfirmaClave.Name = "txtConfirmaClave";
            this.txtConfirmaClave.PasswordChar = '*';
            this.txtConfirmaClave.Size = new System.Drawing.Size(200, 20);
            this.txtConfirmaClave.TabIndex = 7;
            this.txtConfirmaClave.UseSystemPasswordChar = true;
            // 
            // btnCancelar
            // 
            this.btnCancelar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnCancelar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelar.Image = global::WindowsFormsAppCliente.Properties.Resources.Cancelar;
            this.btnCancelar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCancelar.Location = new System.Drawing.Point(248, 282);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(174, 69);
            this.btnCancelar.TabIndex = 9;
            this.btnCancelar.Text = "CANCELAR";
            this.btnCancelar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnCancelar.UseVisualStyleBackColor = true;
            // 
            // btnGuardar
            // 
            this.btnGuardar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnGuardar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGuardar.Image = global::WindowsFormsAppCliente.Properties.Resources.Guardar;
            this.btnGuardar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnGuardar.Location = new System.Drawing.Point(58, 282);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(174, 69);
            this.btnGuardar.TabIndex = 8;
            this.btnGuardar.Text = "GUARDAR";
            this.btnGuardar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnGuardar.UseVisualStyleBackColor = true;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.panel1);
            this.tabPage1.Controls.Add(this.dtvDatos);
            this.tabPage1.Controls.Add(this.button1);
            this.tabPage1.Controls.Add(this.btnModificar);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(486, 410);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Usuarios";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // btnModificar
            // 
            this.btnModificar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnModificar.Image = global::WindowsFormsAppCliente.Properties.Resources.Editar;
            this.btnModificar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnModificar.Location = new System.Drawing.Point(5, 316);
            this.btnModificar.Name = "btnModificar";
            this.btnModificar.Size = new System.Drawing.Size(231, 66);
            this.btnModificar.TabIndex = 0;
            this.btnModificar.Text = "CAMBIAR CONTRASEÑA";
            this.btnModificar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnModificar.UseVisualStyleBackColor = true;
            this.btnModificar.Click += new System.EventHandler(this.btnModificar_Click);
            // 
            // button1
            // 
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.Image = global::WindowsFormsAppCliente.Properties.Resources.Eliminar;
            this.button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button1.Location = new System.Drawing.Point(240, 316);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(233, 66);
            this.button1.TabIndex = 1;
            this.button1.Text = "ELIMINAR";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // dtvDatos
            // 
            this.dtvDatos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtvDatos.Location = new System.Drawing.Point(6, 131);
            this.dtvDatos.Name = "dtvDatos";
            this.dtvDatos.Size = new System.Drawing.Size(467, 179);
            this.dtvDatos.TabIndex = 6;
            this.dtvDatos.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtvDatos_CellClick);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.panel1.Controls.Add(this.labelMensaje);
            this.panel1.Controls.Add(this.rbtnTipoUsuario);
            this.panel1.Controls.Add(this.rbtnNombreUsuario);
            this.panel1.Controls.Add(this.txtCadenaBuscar);
            this.panel1.Controls.Add(this.btnBuscar);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Location = new System.Drawing.Point(6, 14);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(467, 111);
            this.panel1.TabIndex = 7;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(3, 10);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(121, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "BUSCAR USUARIO:";
            // 
            // btnBuscar
            // 
            this.btnBuscar.Image = global::WindowsFormsAppCliente.Properties.Resources.if_system_search_118797__1_;
            this.btnBuscar.Location = new System.Drawing.Point(375, 26);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(75, 69);
            this.btnBuscar.TabIndex = 1;
            this.btnBuscar.UseVisualStyleBackColor = true;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // txtCadenaBuscar
            // 
            this.txtCadenaBuscar.Location = new System.Drawing.Point(6, 59);
            this.txtCadenaBuscar.Name = "txtCadenaBuscar";
            this.txtCadenaBuscar.Size = new System.Drawing.Size(345, 20);
            this.txtCadenaBuscar.TabIndex = 2;
            this.txtCadenaBuscar.TextChanged += new System.EventHandler(this.txtCadenaBuscar_TextChanged);
            this.txtCadenaBuscar.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtCadenaBuscar_KeyPress);
            this.txtCadenaBuscar.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtCadenaBuscar_KeyUp);
            // 
            // rbtnNombreUsuario
            // 
            this.rbtnNombreUsuario.AutoSize = true;
            this.rbtnNombreUsuario.Location = new System.Drawing.Point(6, 36);
            this.rbtnNombreUsuario.Name = "rbtnNombreUsuario";
            this.rbtnNombreUsuario.Size = new System.Drawing.Size(133, 17);
            this.rbtnNombreUsuario.TabIndex = 0;
            this.rbtnNombreUsuario.TabStop = true;
            this.rbtnNombreUsuario.Text = "Nombre de Usuario";
            this.rbtnNombreUsuario.UseVisualStyleBackColor = true;
            // 
            // rbtnTipoUsuario
            // 
            this.rbtnTipoUsuario.AutoSize = true;
            this.rbtnTipoUsuario.Location = new System.Drawing.Point(143, 36);
            this.rbtnTipoUsuario.Name = "rbtnTipoUsuario";
            this.rbtnTipoUsuario.Size = new System.Drawing.Size(115, 17);
            this.rbtnTipoUsuario.TabIndex = 1;
            this.rbtnTipoUsuario.TabStop = true;
            this.rbtnTipoUsuario.Text = "Tipo de Usuario";
            this.rbtnTipoUsuario.UseVisualStyleBackColor = true;
            // 
            // labelMensaje
            // 
            this.labelMensaje.AutoSize = true;
            this.labelMensaje.ForeColor = System.Drawing.Color.Red;
            this.labelMensaje.Location = new System.Drawing.Point(15, 82);
            this.labelMensaje.Name = "labelMensaje";
            this.labelMensaje.Size = new System.Drawing.Size(174, 13);
            this.labelMensaje.TabIndex = 10;
            this.labelMensaje.Text = "No se encontraron resultados";
            this.labelMensaje.Visible = false;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabControl1.Location = new System.Drawing.Point(12, 12);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(494, 436);
            this.tabControl1.TabIndex = 7;
            // 
            // FormAdministrarUsuarios
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::WindowsFormsAppCliente.Properties.Resources.FondoMedicina2;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(534, 472);
            this.Controls.Add(this.tabControl1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormAdministrarUsuarios";
            this.Text = "Lista de Usuarios";
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.tabPage1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dtvDatos)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.tabControl1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.TextBox txtConfirmaClave;
        private System.Windows.Forms.TextBox txtNombreUsuario;
        private System.Windows.Forms.TextBox txtNombre2;
        private System.Windows.Forms.TextBox txtApellido2;
        private System.Windows.Forms.TextBox txtNombre1;
        private System.Windows.Forms.TextBox txtApellido1;
        private System.Windows.Forms.TextBox txtCedua;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtContraseña;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label labelMensaje;
        private System.Windows.Forms.RadioButton rbtnTipoUsuario;
        private System.Windows.Forms.RadioButton rbtnNombreUsuario;
        private System.Windows.Forms.TextBox txtCadenaBuscar;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dtvDatos;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btnModificar;
        private System.Windows.Forms.TabControl tabControl1;
    }
}