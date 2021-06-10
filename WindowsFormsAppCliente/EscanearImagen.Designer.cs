namespace WindowsFormsAppCliente
{
    partial class EscanearImagen
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
            this.btnEscanear = new System.Windows.Forms.Button();
            this.btnEliminarRuido = new System.Windows.Forms.Button();
            this.btnSegmentar = new System.Windows.Forms.Button();
            this.btnProcesar = new System.Windows.Forms.Button();
            this.panelSegmentar = new System.Windows.Forms.Panel();
            this.panelRuido = new System.Windows.Forms.Panel();
            this.panelOriginal = new System.Windows.Forms.Panel();
            this.SuspendLayout();
            // 
            // btnEscanear
            // 
            this.btnEscanear.Location = new System.Drawing.Point(64, 22);
            this.btnEscanear.Name = "btnEscanear";
            this.btnEscanear.Size = new System.Drawing.Size(75, 23);
            this.btnEscanear.TabIndex = 3;
            this.btnEscanear.Text = "Escanear";
            this.btnEscanear.UseVisualStyleBackColor = true;
            this.btnEscanear.Click += new System.EventHandler(this.btnEscanear_Click);
            // 
            // btnEliminarRuido
            // 
            this.btnEliminarRuido.Location = new System.Drawing.Point(275, 22);
            this.btnEliminarRuido.Name = "btnEliminarRuido";
            this.btnEliminarRuido.Size = new System.Drawing.Size(125, 23);
            this.btnEliminarRuido.TabIndex = 4;
            this.btnEliminarRuido.Text = "Eliminar Ruido";
            this.btnEliminarRuido.UseVisualStyleBackColor = true;
            this.btnEliminarRuido.Click += new System.EventHandler(this.btnEliminarRuido_Click);
            // 
            // btnSegmentar
            // 
            this.btnSegmentar.Location = new System.Drawing.Point(524, 22);
            this.btnSegmentar.Name = "btnSegmentar";
            this.btnSegmentar.Size = new System.Drawing.Size(75, 23);
            this.btnSegmentar.TabIndex = 5;
            this.btnSegmentar.Text = "Segmentar";
            this.btnSegmentar.UseVisualStyleBackColor = true;
            this.btnSegmentar.Click += new System.EventHandler(this.btnSegmentar_Click);
            // 
            // btnProcesar
            // 
            this.btnProcesar.Location = new System.Drawing.Point(297, 255);
            this.btnProcesar.Name = "btnProcesar";
            this.btnProcesar.Size = new System.Drawing.Size(75, 49);
            this.btnProcesar.TabIndex = 6;
            this.btnProcesar.Text = "Procesar";
            this.btnProcesar.UseVisualStyleBackColor = true;
            this.btnProcesar.Click += new System.EventHandler(this.btnProcesar_Click);
            // 
            // panelSegmentar
            // 
            this.panelSegmentar.BackgroundImage = global::WindowsFormsAppCliente.Properties.Resources.segmentación;
            this.panelSegmentar.Enabled = false;
            this.panelSegmentar.Location = new System.Drawing.Point(465, 64);
            this.panelSegmentar.Name = "panelSegmentar";
            this.panelSegmentar.Size = new System.Drawing.Size(174, 154);
            this.panelSegmentar.TabIndex = 2;
            // 
            // panelRuido
            // 
            this.panelRuido.BackgroundImage = global::WindowsFormsAppCliente.Properties.Resources.eliminarruido;
            this.panelRuido.Enabled = false;
            this.panelRuido.Location = new System.Drawing.Point(241, 64);
            this.panelRuido.Name = "panelRuido";
            this.panelRuido.Size = new System.Drawing.Size(196, 154);
            this.panelRuido.TabIndex = 1;
            // 
            // panelOriginal
            // 
            this.panelOriginal.BackgroundImage = global::WindowsFormsAppCliente.Properties.Resources.original;
            this.panelOriginal.Enabled = false;
            this.panelOriginal.Location = new System.Drawing.Point(12, 64);
            this.panelOriginal.Name = "panelOriginal";
            this.panelOriginal.Size = new System.Drawing.Size(190, 154);
            this.panelOriginal.TabIndex = 0;
            // 
            // EscanearImagen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(698, 328);
            this.Controls.Add(this.btnProcesar);
            this.Controls.Add(this.btnSegmentar);
            this.Controls.Add(this.btnEliminarRuido);
            this.Controls.Add(this.btnEscanear);
            this.Controls.Add(this.panelSegmentar);
            this.Controls.Add(this.panelRuido);
            this.Controls.Add(this.panelOriginal);
            this.Name = "EscanearImagen";
            this.Text = "EscanearImagen";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelOriginal;
        private System.Windows.Forms.Panel panelRuido;
        private System.Windows.Forms.Panel panelSegmentar;
        private System.Windows.Forms.Button btnEscanear;
        private System.Windows.Forms.Button btnEliminarRuido;
        private System.Windows.Forms.Button btnSegmentar;
        private System.Windows.Forms.Button btnProcesar;
    }
}