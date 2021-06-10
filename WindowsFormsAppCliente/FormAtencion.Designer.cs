namespace WindowsFormsAppCliente
{
    partial class FormAtencion
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormAtencion));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtInfoPaciente = new System.Windows.Forms.TextBox();
            this.txtNumCita = new System.Windows.Forms.TextBox();
            this.panelSintomas = new System.Windows.Forms.Panel();
            this.btnRemoverSintomas = new System.Windows.Forms.Button();
            this.btnAgregarSintomas = new System.Windows.Forms.Button();
            this.txtSintomas = new System.Windows.Forms.TextBox();
            this.listSintomas = new System.Windows.Forms.ListView();
            this.label6 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.txtEstatura = new System.Windows.Forms.MaskedTextBox();
            this.txtIMC = new System.Windows.Forms.MaskedTextBox();
            this.txtPeso = new System.Windows.Forms.MaskedTextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.txtPresion = new System.Windows.Forms.MaskedTextBox();
            this.txtFrecuenciaCardiaca = new System.Windows.Forms.MaskedTextBox();
            this.txtTemperura = new System.Windows.Forms.MaskedTextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.panelDiagnostico = new System.Windows.Forms.Panel();
            this.txtDiagnostico = new System.Windows.Forms.RichTextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.panelTratamiento = new System.Windows.Forms.Panel();
            this.label18 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.cmbMedicamentosReceta = new System.Windows.Forms.ComboBox();
            this.txtDosisReceta = new System.Windows.Forms.MaskedTextBox();
            this.txtCantMedReceta = new System.Windows.Forms.MaskedTextBox();
            this.label19 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.panelReceta = new System.Windows.Forms.Panel();
            this.btnRemoverMedReceta = new System.Windows.Forms.Button();
            this.txtRecetaContraIndicaciones = new System.Windows.Forms.RichTextBox();
            this.label21 = new System.Windows.Forms.Label();
            this.txtRecetaIndicaiones = new System.Windows.Forms.RichTextBox();
            this.label20 = new System.Windows.Forms.Label();
            this.label23 = new System.Windows.Forms.Label();
            this.listReceta = new System.Windows.Forms.ListView();
            this.btnFinalizar = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnBuscarCita = new System.Windows.Forms.Button();
            this.panelSintomas.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panelDiagnostico.SuspendLayout();
            this.panelTratamiento.SuspendLayout();
            this.panelReceta.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(49, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(74, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Cita N° :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(34, 52);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(89, 20);
            this.label2.TabIndex = 0;
            this.label2.Text = "Paciente :";
            // 
            // txtInfoPaciente
            // 
            this.txtInfoPaciente.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtInfoPaciente.Location = new System.Drawing.Point(147, 52);
            this.txtInfoPaciente.Name = "txtInfoPaciente";
            this.txtInfoPaciente.Size = new System.Drawing.Size(255, 22);
            this.txtInfoPaciente.TabIndex = 5;
            // 
            // txtNumCita
            // 
            this.txtNumCita.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNumCita.Location = new System.Drawing.Point(147, 18);
            this.txtNumCita.Name = "txtNumCita";
            this.txtNumCita.Size = new System.Drawing.Size(100, 22);
            this.txtNumCita.TabIndex = 4;
            this.txtNumCita.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtNumCita_KeyPress);
            // 
            // panelSintomas
            // 
            this.panelSintomas.Controls.Add(this.btnRemoverSintomas);
            this.panelSintomas.Controls.Add(this.btnAgregarSintomas);
            this.panelSintomas.Controls.Add(this.txtSintomas);
            this.panelSintomas.Controls.Add(this.listSintomas);
            this.panelSintomas.Controls.Add(this.label6);
            this.panelSintomas.Location = new System.Drawing.Point(16, 219);
            this.panelSintomas.Name = "panelSintomas";
            this.panelSintomas.Size = new System.Drawing.Size(342, 207);
            this.panelSintomas.TabIndex = 6;
            // 
            // btnRemoverSintomas
            // 
            this.btnRemoverSintomas.BackgroundImage = global::WindowsFormsAppCliente.Properties.Resources.BotonRojo;
            this.btnRemoverSintomas.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnRemoverSintomas.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnRemoverSintomas.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRemoverSintomas.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnRemoverSintomas.Location = new System.Drawing.Point(20, 176);
            this.btnRemoverSintomas.Name = "btnRemoverSintomas";
            this.btnRemoverSintomas.Size = new System.Drawing.Size(130, 28);
            this.btnRemoverSintomas.TabIndex = 8;
            this.btnRemoverSintomas.Text = "ROMOVER";
            this.btnRemoverSintomas.UseVisualStyleBackColor = true;
            this.btnRemoverSintomas.Click += new System.EventHandler(this.btnRemoverSintomas_Click);
            // 
            // btnAgregarSintomas
            // 
            this.btnAgregarSintomas.BackgroundImage = global::WindowsFormsAppCliente.Properties.Resources.BotonVerde;
            this.btnAgregarSintomas.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnAgregarSintomas.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAgregarSintomas.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAgregarSintomas.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnAgregarSintomas.Location = new System.Drawing.Point(220, 26);
            this.btnAgregarSintomas.Name = "btnAgregarSintomas";
            this.btnAgregarSintomas.Size = new System.Drawing.Size(102, 28);
            this.btnAgregarSintomas.TabIndex = 1;
            this.btnAgregarSintomas.Text = "AGREGAR";
            this.btnAgregarSintomas.UseVisualStyleBackColor = true;
            this.btnAgregarSintomas.Click += new System.EventHandler(this.btnAgregarSintomas_Click);
            // 
            // txtSintomas
            // 
            this.txtSintomas.Location = new System.Drawing.Point(20, 32);
            this.txtSintomas.Name = "txtSintomas";
            this.txtSintomas.Size = new System.Drawing.Size(194, 20);
            this.txtSintomas.TabIndex = 0;
            // 
            // listSintomas
            // 
            this.listSintomas.Location = new System.Drawing.Point(20, 65);
            this.listSintomas.Name = "listSintomas";
            this.listSintomas.Size = new System.Drawing.Size(299, 106);
            this.listSintomas.TabIndex = 0;
            this.listSintomas.UseCompatibleStateImageBehavior = false;
            this.listSintomas.SelectedIndexChanged += new System.EventHandler(this.listSintomas_SelectedIndexChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(17, 13);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(84, 18);
            this.label6.TabIndex = 2;
            this.label6.Text = "Síntomas:";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.txtEstatura);
            this.panel1.Controls.Add(this.txtIMC);
            this.panel1.Controls.Add(this.txtPeso);
            this.panel1.Controls.Add(this.label13);
            this.panel1.Controls.Add(this.label9);
            this.panel1.Controls.Add(this.label10);
            this.panel1.Controls.Add(this.label11);
            this.panel1.Controls.Add(this.label12);
            this.panel1.Controls.Add(this.txtPresion);
            this.panel1.Controls.Add(this.txtFrecuenciaCardiaca);
            this.panel1.Controls.Add(this.txtTemperura);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Location = new System.Drawing.Point(16, 80);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(504, 120);
            this.panel1.TabIndex = 7;
            // 
            // txtEstatura
            // 
            this.txtEstatura.Location = new System.Drawing.Point(373, 12);
            this.txtEstatura.Mask = "99999";
            this.txtEstatura.Name = "txtEstatura";
            this.txtEstatura.Size = new System.Drawing.Size(73, 20);
            this.txtEstatura.TabIndex = 9;
            this.txtEstatura.ValidatingType = typeof(int);
            // 
            // txtIMC
            // 
            this.txtIMC.Location = new System.Drawing.Point(373, 84);
            this.txtIMC.Mask = "99999";
            this.txtIMC.Name = "txtIMC";
            this.txtIMC.Size = new System.Drawing.Size(73, 20);
            this.txtIMC.TabIndex = 10;
            this.txtIMC.ValidatingType = typeof(int);
            this.txtIMC.Enter += new System.EventHandler(this.txtIMC_Enter);
            // 
            // txtPeso
            // 
            this.txtPeso.Location = new System.Drawing.Point(373, 46);
            this.txtPeso.Mask = "99999";
            this.txtPeso.Name = "txtPeso";
            this.txtPeso.Size = new System.Drawing.Size(73, 20);
            this.txtPeso.TabIndex = 11;
            this.txtPeso.ValidatingType = typeof(int);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(452, 13);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(28, 16);
            this.label13.TabIndex = 4;
            this.label13.Text = "CM";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(452, 47);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(26, 16);
            this.label9.TabIndex = 5;
            this.label9.Text = "KG";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(295, 13);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(69, 16);
            this.label10.TabIndex = 6;
            this.label10.Text = "Estatura:";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(310, 85);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(54, 16);
            this.label11.TabIndex = 7;
            this.label11.Text = "I.M.C. :";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(312, 47);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(52, 16);
            this.label12.TabIndex = 8;
            this.label12.Text = "Peso :";
            // 
            // txtPresion
            // 
            this.txtPresion.Location = new System.Drawing.Point(167, 12);
            this.txtPresion.Mask = "99999";
            this.txtPresion.Name = "txtPresion";
            this.txtPresion.Size = new System.Drawing.Size(73, 20);
            this.txtPresion.TabIndex = 3;
            this.txtPresion.ValidatingType = typeof(int);
            // 
            // txtFrecuenciaCardiaca
            // 
            this.txtFrecuenciaCardiaca.Location = new System.Drawing.Point(167, 84);
            this.txtFrecuenciaCardiaca.Mask = "99999";
            this.txtFrecuenciaCardiaca.Name = "txtFrecuenciaCardiaca";
            this.txtFrecuenciaCardiaca.Size = new System.Drawing.Size(73, 20);
            this.txtFrecuenciaCardiaca.TabIndex = 3;
            this.txtFrecuenciaCardiaca.ValidatingType = typeof(int);
            // 
            // txtTemperura
            // 
            this.txtTemperura.Location = new System.Drawing.Point(167, 46);
            this.txtTemperura.Mask = "99999";
            this.txtTemperura.Name = "txtTemperura";
            this.txtTemperura.Size = new System.Drawing.Size(73, 20);
            this.txtTemperura.TabIndex = 3;
            this.txtTemperura.ValidatingType = typeof(int);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(246, 85);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(37, 16);
            this.label8.TabIndex = 2;
            this.label8.Text = "PPM";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(246, 47);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(21, 16);
            this.label4.TabIndex = 2;
            this.label4.Text = "°C";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(47, 13);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(119, 16);
            this.label5.TabIndex = 2;
            this.label5.Text = "Presión Arterial:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(6, 85);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(160, 16);
            this.label7.TabIndex = 2;
            this.label7.Text = "Frecuencia Cardiaca :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(61, 47);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(105, 16);
            this.label3.TabIndex = 2;
            this.label3.Text = "Temperatura :";
            // 
            // panelDiagnostico
            // 
            this.panelDiagnostico.Controls.Add(this.txtDiagnostico);
            this.panelDiagnostico.Controls.Add(this.label14);
            this.panelDiagnostico.Location = new System.Drawing.Point(16, 432);
            this.panelDiagnostico.Name = "panelDiagnostico";
            this.panelDiagnostico.Size = new System.Drawing.Size(342, 191);
            this.panelDiagnostico.TabIndex = 6;
            // 
            // txtDiagnostico
            // 
            this.txtDiagnostico.Location = new System.Drawing.Point(18, 38);
            this.txtDiagnostico.Name = "txtDiagnostico";
            this.txtDiagnostico.Size = new System.Drawing.Size(300, 132);
            this.txtDiagnostico.TabIndex = 0;
            this.txtDiagnostico.Text = "";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(17, 13);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(108, 18);
            this.label14.TabIndex = 2;
            this.label14.Text = "Diagnóstico :";
            // 
            // panelTratamiento
            // 
            this.panelTratamiento.Controls.Add(this.label18);
            this.panelTratamiento.Controls.Add(this.button1);
            this.panelTratamiento.Controls.Add(this.cmbMedicamentosReceta);
            this.panelTratamiento.Controls.Add(this.txtDosisReceta);
            this.panelTratamiento.Controls.Add(this.txtCantMedReceta);
            this.panelTratamiento.Controls.Add(this.label19);
            this.panelTratamiento.Controls.Add(this.label16);
            this.panelTratamiento.Controls.Add(this.label15);
            this.panelTratamiento.Controls.Add(this.label17);
            this.panelTratamiento.Location = new System.Drawing.Point(386, 219);
            this.panelTratamiento.Name = "panelTratamiento";
            this.panelTratamiento.Size = new System.Drawing.Size(507, 116);
            this.panelTratamiento.TabIndex = 6;
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label18.Location = new System.Drawing.Point(92, 62);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(56, 16);
            this.label18.TabIndex = 11;
            this.label18.Text = "Dosis :";
            // 
            // button1
            // 
            this.button1.BackgroundImage = global::WindowsFormsAppCliente.Properties.Resources.BotonVerde;
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button1.Location = new System.Drawing.Point(354, 85);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(102, 28);
            this.button1.TabIndex = 3;
            this.button1.Text = "AGREGAR";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // cmbMedicamentosReceta
            // 
            this.cmbMedicamentosReceta.FormattingEnabled = true;
            this.cmbMedicamentosReceta.Location = new System.Drawing.Point(157, 32);
            this.cmbMedicamentosReceta.Name = "cmbMedicamentosReceta";
            this.cmbMedicamentosReceta.Size = new System.Drawing.Size(121, 21);
            this.cmbMedicamentosReceta.TabIndex = 0;
            // 
            // txtDosisReceta
            // 
            this.txtDosisReceta.Location = new System.Drawing.Point(157, 61);
            this.txtDosisReceta.Mask = "99999";
            this.txtDosisReceta.Name = "txtDosisReceta";
            this.txtDosisReceta.Size = new System.Drawing.Size(73, 20);
            this.txtDosisReceta.TabIndex = 2;
            this.txtDosisReceta.ValidatingType = typeof(int);
            // 
            // txtCantMedReceta
            // 
            this.txtCantMedReceta.Location = new System.Drawing.Point(383, 32);
            this.txtCantMedReceta.Mask = "99999";
            this.txtCantMedReceta.Name = "txtCantMedReceta";
            this.txtCantMedReceta.Size = new System.Drawing.Size(73, 20);
            this.txtCantMedReceta.TabIndex = 1;
            this.txtCantMedReceta.ValidatingType = typeof(int);
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label19.Location = new System.Drawing.Point(236, 62);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(29, 16);
            this.label19.TabIndex = 5;
            this.label19.Text = "mg";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.Location = new System.Drawing.Point(31, 32);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(117, 16);
            this.label16.TabIndex = 2;
            this.label16.Text = "Medicamentos :";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.Location = new System.Drawing.Point(17, 11);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(98, 18);
            this.label15.TabIndex = 2;
            this.label15.Text = "Tratamiento";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label17.Location = new System.Drawing.Point(299, 33);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(78, 16);
            this.label17.TabIndex = 7;
            this.label17.Text = "Cantidad :";
            // 
            // panelReceta
            // 
            this.panelReceta.Controls.Add(this.btnRemoverMedReceta);
            this.panelReceta.Controls.Add(this.txtRecetaContraIndicaciones);
            this.panelReceta.Controls.Add(this.label21);
            this.panelReceta.Controls.Add(this.txtRecetaIndicaiones);
            this.panelReceta.Controls.Add(this.label20);
            this.panelReceta.Controls.Add(this.label23);
            this.panelReceta.Controls.Add(this.listReceta);
            this.panelReceta.Location = new System.Drawing.Point(386, 345);
            this.panelReceta.Name = "panelReceta";
            this.panelReceta.Size = new System.Drawing.Size(507, 278);
            this.panelReceta.TabIndex = 6;
            // 
            // btnRemoverMedReceta
            // 
            this.btnRemoverMedReceta.BackgroundImage = global::WindowsFormsAppCliente.Properties.Resources.BotonRojo;
            this.btnRemoverMedReceta.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnRemoverMedReceta.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnRemoverMedReceta.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRemoverMedReceta.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnRemoverMedReceta.Location = new System.Drawing.Point(20, 247);
            this.btnRemoverMedReceta.Name = "btnRemoverMedReceta";
            this.btnRemoverMedReceta.Size = new System.Drawing.Size(130, 28);
            this.btnRemoverMedReceta.TabIndex = 8;
            this.btnRemoverMedReceta.Text = "ROMOVER";
            this.btnRemoverMedReceta.UseVisualStyleBackColor = true;
            this.btnRemoverMedReceta.Click += new System.EventHandler(this.btnRemoverMedReceta_Click);
            // 
            // txtRecetaContraIndicaciones
            // 
            this.txtRecetaContraIndicaciones.Location = new System.Drawing.Point(248, 151);
            this.txtRecetaContraIndicaciones.Name = "txtRecetaContraIndicaciones";
            this.txtRecetaContraIndicaciones.Size = new System.Drawing.Size(244, 81);
            this.txtRecetaContraIndicaciones.TabIndex = 2;
            this.txtRecetaContraIndicaciones.Text = "";
            this.txtRecetaContraIndicaciones.TextChanged += new System.EventHandler(this.richTextBox3_TextChanged);
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label21.Location = new System.Drawing.Point(247, 130);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(153, 18);
            this.label21.TabIndex = 2;
            this.label21.Text = "Contraindicaciones";
            // 
            // txtRecetaIndicaiones
            // 
            this.txtRecetaIndicaiones.Location = new System.Drawing.Point(246, 34);
            this.txtRecetaIndicaiones.Name = "txtRecetaIndicaiones";
            this.txtRecetaIndicaiones.Size = new System.Drawing.Size(244, 81);
            this.txtRecetaIndicaiones.TabIndex = 1;
            this.txtRecetaIndicaiones.Text = "";
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label20.Location = new System.Drawing.Point(245, 13);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(102, 18);
            this.label20.TabIndex = 2;
            this.label20.Text = "Indicaciones";
            // 
            // label23
            // 
            this.label23.AutoSize = true;
            this.label23.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label23.Location = new System.Drawing.Point(17, 13);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(61, 18);
            this.label23.TabIndex = 2;
            this.label23.Text = "Receta";
            // 
            // listReceta
            // 
            this.listReceta.Location = new System.Drawing.Point(20, 32);
            this.listReceta.Name = "listReceta";
            this.listReceta.Size = new System.Drawing.Size(210, 210);
            this.listReceta.TabIndex = 0;
            this.listReceta.UseCompatibleStateImageBehavior = false;
            this.listReceta.SelectedIndexChanged += new System.EventHandler(this.listReceta_SelectedIndexChanged);
            // 
            // btnFinalizar
            // 
            this.btnFinalizar.BackgroundImage = global::WindowsFormsAppCliente.Properties.Resources.BotonAzul;
            this.btnFinalizar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnFinalizar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnFinalizar.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFinalizar.ForeColor = System.Drawing.Color.White;
            this.btnFinalizar.Location = new System.Drawing.Point(199, 647);
            this.btnFinalizar.Name = "btnFinalizar";
            this.btnFinalizar.Size = new System.Drawing.Size(203, 45);
            this.btnFinalizar.TabIndex = 0;
            this.btnFinalizar.Text = "FINALIZAR";
            this.btnFinalizar.UseVisualStyleBackColor = true;
            this.btnFinalizar.Click += new System.EventHandler(this.btnFinalizar_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.BackgroundImage = global::WindowsFormsAppCliente.Properties.Resources.BotonRojo;
            this.btnCancelar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnCancelar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCancelar.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelar.ForeColor = System.Drawing.Color.White;
            this.btnCancelar.Location = new System.Drawing.Point(424, 647);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(203, 45);
            this.btnCancelar.TabIndex = 1;
            this.btnCancelar.Text = "CANCELAR";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // btnBuscarCita
            // 
            this.btnBuscarCita.Image = global::WindowsFormsAppCliente.Properties.Resources.s6;
            this.btnBuscarCita.Location = new System.Drawing.Point(253, 12);
            this.btnBuscarCita.Name = "btnBuscarCita";
            this.btnBuscarCita.Size = new System.Drawing.Size(43, 34);
            this.btnBuscarCita.TabIndex = 8;
            this.btnBuscarCita.UseVisualStyleBackColor = true;
            this.btnBuscarCita.Click += new System.EventHandler(this.btnBuscarCita_Click);
            // 
            // FormAtencion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::WindowsFormsAppCliente.Properties.Resources.FondoMedicina3;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(927, 691);
            this.Controls.Add(this.btnBuscarCita);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnFinalizar);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panelDiagnostico);
            this.Controls.Add(this.panelReceta);
            this.Controls.Add(this.panelTratamiento);
            this.Controls.Add(this.panelSintomas);
            this.Controls.Add(this.txtInfoPaciente);
            this.Controls.Add(this.txtNumCita);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormAtencion";
            this.Text = "Atencion Medica";
            this.panelSintomas.ResumeLayout(false);
            this.panelSintomas.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panelDiagnostico.ResumeLayout(false);
            this.panelDiagnostico.PerformLayout();
            this.panelTratamiento.ResumeLayout(false);
            this.panelTratamiento.PerformLayout();
            this.panelReceta.ResumeLayout(false);
            this.panelReceta.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtInfoPaciente;
        private System.Windows.Forms.TextBox txtNumCita;
        private System.Windows.Forms.Panel panelSintomas;
        private System.Windows.Forms.TextBox txtSintomas;
        private System.Windows.Forms.ListView listSintomas;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnAgregarSintomas;
        private System.Windows.Forms.Button btnRemoverSintomas;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.MaskedTextBox txtEstatura;
        private System.Windows.Forms.MaskedTextBox txtIMC;
        private System.Windows.Forms.MaskedTextBox txtPeso;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.MaskedTextBox txtPresion;
        private System.Windows.Forms.MaskedTextBox txtFrecuenciaCardiaca;
        private System.Windows.Forms.MaskedTextBox txtTemperura;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panelDiagnostico;
        private System.Windows.Forms.RichTextBox txtDiagnostico;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Panel panelTratamiento;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ComboBox cmbMedicamentosReceta;
        private System.Windows.Forms.MaskedTextBox txtDosisReceta;
        private System.Windows.Forms.MaskedTextBox txtCantMedReceta;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Panel panelReceta;
        private System.Windows.Forms.RichTextBox txtRecetaContraIndicaciones;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.RichTextBox txtRecetaIndicaiones;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.Label label23;
        private System.Windows.Forms.ListView listReceta;
        private System.Windows.Forms.Button btnRemoverMedReceta;
        private System.Windows.Forms.Button btnFinalizar;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnBuscarCita;
    }
}