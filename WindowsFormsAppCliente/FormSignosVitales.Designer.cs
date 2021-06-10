namespace WindowsFormsAppCliente
{
    partial class FormSignosVitales
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormSignosVitales));
            this.label1 = new System.Windows.Forms.Label();
            this.txtNumCita = new System.Windows.Forms.TextBox();
            this.txtInfoPaciente = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.txtEstatura = new System.Windows.Forms.MaskedTextBox();
            this.txtIMC = new System.Windows.Forms.MaskedTextBox();
            this.txtPeso = new System.Windows.Forms.MaskedTextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.txtPresion = new System.Windows.Forms.MaskedTextBox();
            this.txtFrecuenciaCardiaca = new System.Windows.Forms.MaskedTextBox();
            this.txtTemperura = new System.Windows.Forms.MaskedTextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnBuscarCita = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(41, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(69, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Cita N°:";
            // 
            // txtNumCita
            // 
            this.txtNumCita.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNumCita.Location = new System.Drawing.Point(124, 9);
            this.txtNumCita.Name = "txtNumCita";
            this.txtNumCita.Size = new System.Drawing.Size(100, 22);
            this.txtNumCita.TabIndex = 0;
            this.txtNumCita.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtNumCita_KeyPress);
            // 
            // txtInfoPaciente
            // 
            this.txtInfoPaciente.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtInfoPaciente.Location = new System.Drawing.Point(124, 49);
            this.txtInfoPaciente.Name = "txtInfoPaciente";
            this.txtInfoPaciente.Size = new System.Drawing.Size(236, 22);
            this.txtInfoPaciente.TabIndex = 3;
            this.txtInfoPaciente.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtInfoPaciente_KeyPress);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 49);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(89, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "Paciente :";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.txtEstatura);
            this.panel1.Controls.Add(this.txtIMC);
            this.panel1.Controls.Add(this.txtPeso);
            this.panel1.Controls.Add(this.label13);
            this.panel1.Controls.Add(this.label10);
            this.panel1.Controls.Add(this.label9);
            this.panel1.Controls.Add(this.label11);
            this.panel1.Controls.Add(this.txtPresion);
            this.panel1.Controls.Add(this.txtFrecuenciaCardiaca);
            this.panel1.Controls.Add(this.txtTemperura);
            this.panel1.Controls.Add(this.label12);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Location = new System.Drawing.Point(16, 88);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(553, 137);
            this.panel1.TabIndex = 4;
            // 
            // txtEstatura
            // 
            this.txtEstatura.Location = new System.Drawing.Point(424, 46);
            this.txtEstatura.Mask = "99999";
            this.txtEstatura.Name = "txtEstatura";
            this.txtEstatura.Size = new System.Drawing.Size(73, 20);
            this.txtEstatura.TabIndex = 4;
            this.txtEstatura.ValidatingType = typeof(int);
            this.txtEstatura.Leave += new System.EventHandler(this.txtEstatura_Leave);
            // 
            // txtIMC
            // 
            this.txtIMC.Location = new System.Drawing.Point(424, 84);
            this.txtIMC.Mask = "99999";
            this.txtIMC.Name = "txtIMC";
            this.txtIMC.Size = new System.Drawing.Size(73, 20);
            this.txtIMC.TabIndex = 5;
            this.txtIMC.ValidatingType = typeof(int);
            // 
            // txtPeso
            // 
            this.txtPeso.Location = new System.Drawing.Point(424, 12);
            this.txtPeso.Mask = "99999";
            this.txtPeso.Name = "txtPeso";
            this.txtPeso.Size = new System.Drawing.Size(73, 20);
            this.txtPeso.TabIndex = 3;
            this.txtPeso.ValidatingType = typeof(int);
            this.txtPeso.TextChanged += new System.EventHandler(this.txtPeso_TextChanged);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(503, 47);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(28, 16);
            this.label13.TabIndex = 4;
            this.label13.Text = "CM";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(342, 47);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(73, 16);
            this.label10.TabIndex = 6;
            this.label10.Text = "Estatura :";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(503, 13);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(26, 16);
            this.label9.TabIndex = 5;
            this.label9.Text = "KG";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(361, 85);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(54, 16);
            this.label11.TabIndex = 7;
            this.label11.Text = "I.M.C. :";
            // 
            // txtPresion
            // 
            this.txtPresion.Location = new System.Drawing.Point(179, 12);
            this.txtPresion.Mask = "99999";
            this.txtPresion.Name = "txtPresion";
            this.txtPresion.Size = new System.Drawing.Size(73, 20);
            this.txtPresion.TabIndex = 0;
            this.txtPresion.ValidatingType = typeof(int);
            // 
            // txtFrecuenciaCardiaca
            // 
            this.txtFrecuenciaCardiaca.Location = new System.Drawing.Point(179, 84);
            this.txtFrecuenciaCardiaca.Mask = "99999";
            this.txtFrecuenciaCardiaca.Name = "txtFrecuenciaCardiaca";
            this.txtFrecuenciaCardiaca.Size = new System.Drawing.Size(73, 20);
            this.txtFrecuenciaCardiaca.TabIndex = 2;
            this.txtFrecuenciaCardiaca.ValidatingType = typeof(int);
            // 
            // txtTemperura
            // 
            this.txtTemperura.Location = new System.Drawing.Point(179, 46);
            this.txtTemperura.Mask = "99999";
            this.txtTemperura.Name = "txtTemperura";
            this.txtTemperura.Size = new System.Drawing.Size(73, 20);
            this.txtTemperura.TabIndex = 1;
            this.txtTemperura.ValidatingType = typeof(int);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(363, 13);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(52, 16);
            this.label12.TabIndex = 8;
            this.label12.Text = "Peso :";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(263, 85);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(37, 16);
            this.label8.TabIndex = 2;
            this.label8.Text = "PPM";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(263, 47);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(21, 16);
            this.label4.TabIndex = 2;
            this.label4.Text = "°C";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(39, 13);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(123, 16);
            this.label5.TabIndex = 2;
            this.label5.Text = "Presión Arterial :";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(2, 85);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(160, 16);
            this.label7.TabIndex = 2;
            this.label7.Text = "Frecuencia Cardiaca :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(57, 47);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(105, 16);
            this.label3.TabIndex = 2;
            this.label3.Text = "Temperatura :";
            // 
            // btnGuardar
            // 
            this.btnGuardar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnGuardar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnGuardar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGuardar.Image = global::WindowsFormsAppCliente.Properties.Resources.Guardar;
            this.btnGuardar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnGuardar.Location = new System.Drawing.Point(75, 256);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(173, 72);
            this.btnGuardar.TabIndex = 2;
            this.btnGuardar.Text = "GUARDAR";
            this.btnGuardar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnGuardar.UseVisualStyleBackColor = true;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnCancelar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCancelar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelar.Image = global::WindowsFormsAppCliente.Properties.Resources.Cancelar;
            this.btnCancelar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCancelar.Location = new System.Drawing.Point(255, 256);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(177, 72);
            this.btnCancelar.TabIndex = 3;
            this.btnCancelar.Text = "CANCELAR";
            this.btnCancelar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // btnBuscarCita
            // 
            this.btnBuscarCita.Image = global::WindowsFormsAppCliente.Properties.Resources.s6;
            this.btnBuscarCita.Location = new System.Drawing.Point(230, 3);
            this.btnBuscarCita.Name = "btnBuscarCita";
            this.btnBuscarCita.Size = new System.Drawing.Size(43, 34);
            this.btnBuscarCita.TabIndex = 1;
            this.btnBuscarCita.UseVisualStyleBackColor = true;
            this.btnBuscarCita.Click += new System.EventHandler(this.btnBuscarCita_Click);
            // 
            // FormSignosVitales
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::WindowsFormsAppCliente.Properties.Resources.FondoMedicina4;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(584, 336);
            this.Controls.Add(this.btnBuscarCita);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnGuardar);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.txtInfoPaciente);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtNumCita);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(600, 375);
            this.MinimumSize = new System.Drawing.Size(600, 375);
            this.Name = "FormSignosVitales";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Signos Vitales";
            this.Load += new System.EventHandler(this.FormSignosVitales_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtNumCita;
        private System.Windows.Forms.TextBox txtInfoPaciente;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.MaskedTextBox txtPresion;
        private System.Windows.Forms.MaskedTextBox txtFrecuenciaCardiaca;
        private System.Windows.Forms.MaskedTextBox txtTemperura;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.MaskedTextBox txtEstatura;
        private System.Windows.Forms.MaskedTextBox txtIMC;
        private System.Windows.Forms.MaskedTextBox txtPeso;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Button btnBuscarCita;
    }
}