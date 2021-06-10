namespace WindowsFormsAppCliente
{
    partial class Form1
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
            this.btnID3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.txtEjemplo = new System.Windows.Forms.TextBox();
            this.btnEjemplos = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.dtgEjemplos = new System.Windows.Forms.DataGridView();
            this.btnChoices = new System.Windows.Forms.Button();
            this.txtChoices = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.listBoxLista = new System.Windows.Forms.ListBox();
            ((System.ComponentModel.ISupportInitialize)(this.dtgEjemplos)).BeginInit();
            this.SuspendLayout();
            // 
            // btnID3
            // 
            this.btnID3.Location = new System.Drawing.Point(196, 142);
            this.btnID3.Name = "btnID3";
            this.btnID3.Size = new System.Drawing.Size(108, 23);
            this.btnID3.TabIndex = 26;
            this.btnID3.Text = "ID3";
            this.btnID3.UseVisualStyleBackColor = true;
            this.btnID3.Click += new System.EventHandler(this.btnID3_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(50, 142);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(99, 23);
            this.button2.TabIndex = 25;
            this.button2.Text = "Llenar Matriz";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // txtEjemplo
            // 
            this.txtEjemplo.Location = new System.Drawing.Point(35, 89);
            this.txtEjemplo.Name = "txtEjemplo";
            this.txtEjemplo.Size = new System.Drawing.Size(288, 20);
            this.txtEjemplo.TabIndex = 24;
            // 
            // btnEjemplos
            // 
            this.btnEjemplos.Location = new System.Drawing.Point(329, 87);
            this.btnEjemplos.Name = "btnEjemplos";
            this.btnEjemplos.Size = new System.Drawing.Size(75, 23);
            this.btnEjemplos.TabIndex = 23;
            this.btnEjemplos.Text = "Agregar";
            this.btnEjemplos.UseVisualStyleBackColor = true;
            this.btnEjemplos.Click += new System.EventHandler(this.btnEjemplos_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(32, 64);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(224, 13);
            this.label4.TabIndex = 22;
            this.label4.Text = "Agregar Ejemplos : Seperar por una coma ( ,  )";
            // 
            // dtgEjemplos
            // 
            this.dtgEjemplos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgEjemplos.Location = new System.Drawing.Point(12, 171);
            this.dtgEjemplos.Name = "dtgEjemplos";
            this.dtgEjemplos.Size = new System.Drawing.Size(544, 184);
            this.dtgEjemplos.TabIndex = 21;
            // 
            // btnChoices
            // 
            this.btnChoices.Location = new System.Drawing.Point(329, 32);
            this.btnChoices.Name = "btnChoices";
            this.btnChoices.Size = new System.Drawing.Size(75, 23);
            this.btnChoices.TabIndex = 20;
            this.btnChoices.Text = "Agregar";
            this.btnChoices.UseVisualStyleBackColor = true;
            this.btnChoices.Click += new System.EventHandler(this.btnChoices_Click);
            // 
            // txtChoices
            // 
            this.txtChoices.Location = new System.Drawing.Point(109, 32);
            this.txtChoices.Name = "txtChoices";
            this.txtChoices.Size = new System.Drawing.Size(214, 20);
            this.txtChoices.TabIndex = 19;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(32, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(54, 13);
            this.label1.TabIndex = 18;
            this.label1.Text = "Orígenes:";
            // 
            // listBoxLista
            // 
            this.listBoxLista.FormattingEnabled = true;
            this.listBoxLista.HorizontalScrollbar = true;
            this.listBoxLista.Location = new System.Drawing.Point(593, 12);
            this.listBoxLista.Name = "listBoxLista";
            this.listBoxLista.Size = new System.Drawing.Size(270, 407);
            this.listBoxLista.TabIndex = 27;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(964, 376);
            this.Controls.Add(this.listBoxLista);
            this.Controls.Add(this.btnID3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.txtEjemplo);
            this.Controls.Add(this.btnEjemplos);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.dtgEjemplos);
            this.Controls.Add(this.btnChoices);
            this.Controls.Add(this.txtChoices);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtgEjemplos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnID3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox txtEjemplo;
        private System.Windows.Forms.Button btnEjemplos;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DataGridView dtgEjemplos;
        private System.Windows.Forms.Button btnChoices;
        private System.Windows.Forms.TextBox txtChoices;
        private System.Windows.Forms.Label label1;
        public System.Windows.Forms.ListBox listBoxLista;
    }
}