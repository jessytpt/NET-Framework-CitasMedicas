namespace WindowsFormsAppCliente
{
    partial class Principal
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Principal));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.menuItemArchivo = new System.Windows.Forms.ToolStripMenuItem();
            this.menuItemArchivoIngresar = new System.Windows.Forms.ToolStripMenuItem();
            this.menuItemArchivoCerrarSesion = new System.Windows.Forms.ToolStripMenuItem();
            this.menuItemArchivoSalir = new System.Windows.Forms.ToolStripMenuItem();
            this.menuItemRegistro = new System.Windows.Forms.ToolStripMenuItem();
            this.menuItemRegistroEmpleados = new System.Windows.Forms.ToolStripMenuItem();
            this.menuItemRegistroEmpleadosRegistrar = new System.Windows.Forms.ToolStripMenuItem();
            this.menuItemRegistroEmpleadosLista = new System.Windows.Forms.ToolStripMenuItem();
            this.menuItemRegistroUsuarios = new System.Windows.Forms.ToolStripMenuItem();
            this.menuItemRegistroUsuariosLista = new System.Windows.Forms.ToolStripMenuItem();
            this.menuItemRegistroHistoria = new System.Windows.Forms.ToolStripMenuItem();
            this.menuItemRegistroHistoriaRegistrar = new System.Windows.Forms.ToolStripMenuItem();
            this.menuItemRegistroHistoriaLista = new System.Windows.Forms.ToolStripMenuItem();
            this.menuItemCitas = new System.Windows.Forms.ToolStripMenuItem();
            this.menuItemCitasNueva = new System.Windows.Forms.ToolStripMenuItem();
            this.menuItemCitasAgenda = new System.Windows.Forms.ToolStripMenuItem();
            this.menuItemAtencion = new System.Windows.Forms.ToolStripMenuItem();
            this.menuItemAtencionRegistrar = new System.Windows.Forms.ToolStripMenuItem();
            this.menuItemAtencionLista = new System.Windows.Forms.ToolStripMenuItem();
            this.menuItemFactura = new System.Windows.Forms.ToolStripMenuItem();
            this.menuItemFacturaGenerar = new System.Windows.Forms.ToolStripMenuItem();
            this.menuItemFacturaLista = new System.Windows.Forms.ToolStripMenuItem();
            this.menuItemAyuda = new System.Windows.Forms.ToolStripMenuItem();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnFacturacion = new System.Windows.Forms.Button();
            this.btnAtencion = new System.Windows.Forms.Button();
            this.btnNuevaHistoria = new System.Windows.Forms.Button();
            this.btnRegistrarCita = new System.Windows.Forms.Button();
            this.btnConsultarDisponibilidad = new System.Windows.Forms.Button();
            this.lblUsuario = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuItemArchivo,
            this.menuItemRegistro,
            this.menuItemCitas,
            this.menuItemAtencion,
            this.menuItemFactura,
            this.menuItemAyuda});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(764, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // menuItemArchivo
            // 
            this.menuItemArchivo.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuItemArchivoIngresar,
            this.menuItemArchivoCerrarSesion,
            this.menuItemArchivoSalir});
            this.menuItemArchivo.Name = "menuItemArchivo";
            this.menuItemArchivo.Size = new System.Drawing.Size(60, 20);
            this.menuItemArchivo.Text = "Archivo";
            // 
            // menuItemArchivoIngresar
            // 
            this.menuItemArchivoIngresar.Name = "menuItemArchivoIngresar";
            this.menuItemArchivoIngresar.Size = new System.Drawing.Size(143, 22);
            this.menuItemArchivoIngresar.Text = "Ingresar";
            this.menuItemArchivoIngresar.Click += new System.EventHandler(this.menuItemIngresar_Click);
            // 
            // menuItemArchivoCerrarSesion
            // 
            this.menuItemArchivoCerrarSesion.Name = "menuItemArchivoCerrarSesion";
            this.menuItemArchivoCerrarSesion.Size = new System.Drawing.Size(143, 22);
            this.menuItemArchivoCerrarSesion.Text = "Cerrar Sesion";
            this.menuItemArchivoCerrarSesion.Click += new System.EventHandler(this.salirToolStripMenuItem_Click);
            // 
            // menuItemArchivoSalir
            // 
            this.menuItemArchivoSalir.Name = "menuItemArchivoSalir";
            this.menuItemArchivoSalir.Size = new System.Drawing.Size(143, 22);
            this.menuItemArchivoSalir.Text = "Salir";
            this.menuItemArchivoSalir.Click += new System.EventHandler(this.menuItemArchivoSalir_Click);
            // 
            // menuItemRegistro
            // 
            this.menuItemRegistro.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuItemRegistroEmpleados,
            this.menuItemRegistroUsuarios,
            this.menuItemRegistroHistoria});
            this.menuItemRegistro.Name = "menuItemRegistro";
            this.menuItemRegistro.Size = new System.Drawing.Size(62, 20);
            this.menuItemRegistro.Text = "Registro";
            // 
            // menuItemRegistroEmpleados
            // 
            this.menuItemRegistroEmpleados.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuItemRegistroEmpleadosRegistrar,
            this.menuItemRegistroEmpleadosLista});
            this.menuItemRegistroEmpleados.Name = "menuItemRegistroEmpleados";
            this.menuItemRegistroEmpleados.Size = new System.Drawing.Size(154, 22);
            this.menuItemRegistroEmpleados.Text = "Empleados";
            // 
            // menuItemRegistroEmpleadosRegistrar
            // 
            this.menuItemRegistroEmpleadosRegistrar.Name = "menuItemRegistroEmpleadosRegistrar";
            this.menuItemRegistroEmpleadosRegistrar.Size = new System.Drawing.Size(176, 22);
            this.menuItemRegistroEmpleadosRegistrar.Text = "Registrar Empleado";
            this.menuItemRegistroEmpleadosRegistrar.Click += new System.EventHandler(this.nuevoToolStripMenuItem2_Click);
            // 
            // menuItemRegistroEmpleadosLista
            // 
            this.menuItemRegistroEmpleadosLista.Name = "menuItemRegistroEmpleadosLista";
            this.menuItemRegistroEmpleadosLista.Size = new System.Drawing.Size(176, 22);
            this.menuItemRegistroEmpleadosLista.Text = "Lista de Empleados";
            this.menuItemRegistroEmpleadosLista.Click += new System.EventHandler(this.listaDeEmpleadosToolStripMenuItem_Click);
            // 
            // menuItemRegistroUsuarios
            // 
            this.menuItemRegistroUsuarios.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuItemRegistroUsuariosLista});
            this.menuItemRegistroUsuarios.Name = "menuItemRegistroUsuarios";
            this.menuItemRegistroUsuarios.Size = new System.Drawing.Size(154, 22);
            this.menuItemRegistroUsuarios.Text = "Usuarios";
            // 
            // menuItemRegistroUsuariosLista
            // 
            this.menuItemRegistroUsuariosLista.Name = "menuItemRegistroUsuariosLista";
            this.menuItemRegistroUsuariosLista.Size = new System.Drawing.Size(162, 22);
            this.menuItemRegistroUsuariosLista.Text = "Lista de Usuarios";
            this.menuItemRegistroUsuariosLista.Click += new System.EventHandler(this.listaDeUsuariosToolStripMenuItem_Click);
            // 
            // menuItemRegistroHistoria
            // 
            this.menuItemRegistroHistoria.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuItemRegistroHistoriaRegistrar,
            this.menuItemRegistroHistoriaLista});
            this.menuItemRegistroHistoria.Name = "menuItemRegistroHistoria";
            this.menuItemRegistroHistoria.Size = new System.Drawing.Size(154, 22);
            this.menuItemRegistroHistoria.Text = "Historia Clínica";
            // 
            // menuItemRegistroHistoriaRegistrar
            // 
            this.menuItemRegistroHistoriaRegistrar.Name = "menuItemRegistroHistoriaRegistrar";
            this.menuItemRegistroHistoriaRegistrar.Size = new System.Drawing.Size(207, 22);
            this.menuItemRegistroHistoriaRegistrar.Text = "Registrar Historia Clínica";
            this.menuItemRegistroHistoriaRegistrar.Click += new System.EventHandler(this.registrarHistoriaClínicaToolStripMenuItem_Click);
            // 
            // menuItemRegistroHistoriaLista
            // 
            this.menuItemRegistroHistoriaLista.Name = "menuItemRegistroHistoriaLista";
            this.menuItemRegistroHistoriaLista.Size = new System.Drawing.Size(207, 22);
            this.menuItemRegistroHistoriaLista.Text = "Lista de Historias Clínicas";
            this.menuItemRegistroHistoriaLista.Click += new System.EventHandler(this.listaDeHistoriasClínicasToolStripMenuItem_Click);
            // 
            // menuItemCitas
            // 
            this.menuItemCitas.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuItemCitasNueva,
            this.menuItemCitasAgenda});
            this.menuItemCitas.Name = "menuItemCitas";
            this.menuItemCitas.Size = new System.Drawing.Size(92, 20);
            this.menuItemCitas.Text = "CItas Médicas";
            // 
            // menuItemCitasNueva
            // 
            this.menuItemCitasNueva.Name = "menuItemCitasNueva";
            this.menuItemCitasNueva.Size = new System.Drawing.Size(174, 22);
            this.menuItemCitasNueva.Text = "Nueva Cita Médica";
            this.menuItemCitasNueva.Click += new System.EventHandler(this.nuevaCitaMédicaToolStripMenuItem_Click);
            // 
            // menuItemCitasAgenda
            // 
            this.menuItemCitasAgenda.Name = "menuItemCitasAgenda";
            this.menuItemCitasAgenda.Size = new System.Drawing.Size(174, 22);
            this.menuItemCitasAgenda.Text = "Agenda";
            this.menuItemCitasAgenda.Click += new System.EventHandler(this.agendaToolStripMenuItem_Click);
            // 
            // menuItemAtencion
            // 
            this.menuItemAtencion.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuItemAtencionRegistrar,
            this.menuItemAtencionLista});
            this.menuItemAtencion.Name = "menuItemAtencion";
            this.menuItemAtencion.Size = new System.Drawing.Size(67, 20);
            this.menuItemAtencion.Text = "Atención";
            // 
            // menuItemAtencionRegistrar
            // 
            this.menuItemAtencionRegistrar.Name = "menuItemAtencionRegistrar";
            this.menuItemAtencionRegistrar.Size = new System.Drawing.Size(120, 22);
            this.menuItemAtencionRegistrar.Text = "Registrar";
            // 
            // menuItemAtencionLista
            // 
            this.menuItemAtencionLista.Name = "menuItemAtencionLista";
            this.menuItemAtencionLista.Size = new System.Drawing.Size(120, 22);
            this.menuItemAtencionLista.Text = "Lista";
            // 
            // menuItemFactura
            // 
            this.menuItemFactura.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuItemFacturaGenerar,
            this.menuItemFacturaLista});
            this.menuItemFactura.Name = "menuItemFactura";
            this.menuItemFactura.Size = new System.Drawing.Size(81, 20);
            this.menuItemFactura.Text = "Facturación";
            // 
            // menuItemFacturaGenerar
            // 
            this.menuItemFacturaGenerar.Name = "menuItemFacturaGenerar";
            this.menuItemFacturaGenerar.Size = new System.Drawing.Size(157, 22);
            this.menuItemFacturaGenerar.Text = "Generar Factura";
            // 
            // menuItemFacturaLista
            // 
            this.menuItemFacturaLista.Name = "menuItemFacturaLista";
            this.menuItemFacturaLista.Size = new System.Drawing.Size(157, 22);
            this.menuItemFacturaLista.Text = "Lista";
            // 
            // menuItemAyuda
            // 
            this.menuItemAyuda.Name = "menuItemAyuda";
            this.menuItemAyuda.Size = new System.Drawing.Size(53, 20);
            this.menuItemAyuda.Text = "Ayuda";
            // 
            // panel1
            // 
            this.panel1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.Controls.Add(this.btnFacturacion);
            this.panel1.Controls.Add(this.btnAtencion);
            this.panel1.Controls.Add(this.btnNuevaHistoria);
            this.panel1.Controls.Add(this.btnRegistrarCita);
            this.panel1.Controls.Add(this.btnConsultarDisponibilidad);
            this.panel1.Location = new System.Drawing.Point(103, 52);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(504, 265);
            this.panel1.TabIndex = 1;
            // 
            // btnFacturacion
            // 
            this.btnFacturacion.BackColor = System.Drawing.Color.White;
            this.btnFacturacion.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnFacturacion.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFacturacion.Image = global::WindowsFormsAppCliente.Properties.Resources.Factura;
            this.btnFacturacion.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnFacturacion.Location = new System.Drawing.Point(253, 144);
            this.btnFacturacion.Name = "btnFacturacion";
            this.btnFacturacion.Size = new System.Drawing.Size(127, 100);
            this.btnFacturacion.TabIndex = 2;
            this.btnFacturacion.Text = "FACTURACIÓN";
            this.btnFacturacion.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnFacturacion.UseVisualStyleBackColor = false;
            this.btnFacturacion.Click += new System.EventHandler(this.btnFacturacion_Click);
            // 
            // btnAtencion
            // 
            this.btnAtencion.BackColor = System.Drawing.Color.White;
            this.btnAtencion.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAtencion.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAtencion.Image = global::WindowsFormsAppCliente.Properties.Resources.AtencionMedica;
            this.btnAtencion.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnAtencion.Location = new System.Drawing.Point(104, 144);
            this.btnAtencion.Name = "btnAtencion";
            this.btnAtencion.Size = new System.Drawing.Size(127, 100);
            this.btnAtencion.TabIndex = 3;
            this.btnAtencion.Text = "ATENCIÓN";
            this.btnAtencion.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnAtencion.UseVisualStyleBackColor = false;
            this.btnAtencion.Click += new System.EventHandler(this.btnAtencion_Click);
            // 
            // btnNuevaHistoria
            // 
            this.btnNuevaHistoria.BackColor = System.Drawing.Color.White;
            this.btnNuevaHistoria.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnNuevaHistoria.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNuevaHistoria.Image = global::WindowsFormsAppCliente.Properties.Resources.NuevaHistoriaClinica;
            this.btnNuevaHistoria.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnNuevaHistoria.Location = new System.Drawing.Point(340, 25);
            this.btnNuevaHistoria.Name = "btnNuevaHistoria";
            this.btnNuevaHistoria.Size = new System.Drawing.Size(127, 100);
            this.btnNuevaHistoria.TabIndex = 5;
            this.btnNuevaHistoria.Text = "NUEVA HISTORIA CLÍNICA";
            this.btnNuevaHistoria.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnNuevaHistoria.UseVisualStyleBackColor = false;
            this.btnNuevaHistoria.Click += new System.EventHandler(this.btnNuevaHistoria_Click);
            // 
            // btnRegistrarCita
            // 
            this.btnRegistrarCita.BackColor = System.Drawing.Color.White;
            this.btnRegistrarCita.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnRegistrarCita.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRegistrarCita.Image = global::WindowsFormsAppCliente.Properties.Resources.NuevaCita;
            this.btnRegistrarCita.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnRegistrarCita.Location = new System.Drawing.Point(191, 25);
            this.btnRegistrarCita.Name = "btnRegistrarCita";
            this.btnRegistrarCita.Size = new System.Drawing.Size(127, 100);
            this.btnRegistrarCita.TabIndex = 6;
            this.btnRegistrarCita.Text = "REGISTRAR CITA";
            this.btnRegistrarCita.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnRegistrarCita.UseVisualStyleBackColor = false;
            this.btnRegistrarCita.Click += new System.EventHandler(this.btnRegistrarCita_Click);
            // 
            // btnConsultarDisponibilidad
            // 
            this.btnConsultarDisponibilidad.BackColor = System.Drawing.Color.White;
            this.btnConsultarDisponibilidad.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnConsultarDisponibilidad.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConsultarDisponibilidad.Image = global::WindowsFormsAppCliente.Properties.Resources.Pregunta;
            this.btnConsultarDisponibilidad.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnConsultarDisponibilidad.Location = new System.Drawing.Point(34, 25);
            this.btnConsultarDisponibilidad.Name = "btnConsultarDisponibilidad";
            this.btnConsultarDisponibilidad.Size = new System.Drawing.Size(136, 100);
            this.btnConsultarDisponibilidad.TabIndex = 7;
            this.btnConsultarDisponibilidad.Text = "CONSULTAR DISPONIBILIDAD";
            this.btnConsultarDisponibilidad.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnConsultarDisponibilidad.UseVisualStyleBackColor = false;
            this.btnConsultarDisponibilidad.Click += new System.EventHandler(this.btnConsultarDisponibilidad_Click);
            // 
            // lblUsuario
            // 
            this.lblUsuario.AutoSize = true;
            this.lblUsuario.BackColor = System.Drawing.Color.Transparent;
            this.lblUsuario.Location = new System.Drawing.Point(12, 35);
            this.lblUsuario.Name = "lblUsuario";
            this.lblUsuario.Size = new System.Drawing.Size(56, 13);
            this.lblUsuario.TabIndex = 2;
            this.lblUsuario.Text = "USUARIO";
            // 
            // Principal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::WindowsFormsAppCliente.Properties.Resources.fondoMedicina1;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(764, 374);
            this.Controls.Add(this.lblUsuario);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.Name = "Principal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Principal";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.SizeChanged += new System.EventHandler(this.Principal_SizeChanged);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem menuItemArchivo;
        private System.Windows.Forms.ToolStripMenuItem menuItemArchivoIngresar;
        private System.Windows.Forms.ToolStripMenuItem menuItemArchivoCerrarSesion;
        private System.Windows.Forms.ToolStripMenuItem menuItemAyuda;
        private System.Windows.Forms.ToolStripMenuItem menuItemCitas;
        private System.Windows.Forms.ToolStripMenuItem menuItemAtencion;
        private System.Windows.Forms.ToolStripMenuItem menuItemFactura;
        private System.Windows.Forms.ToolStripMenuItem menuItemRegistro;
        private System.Windows.Forms.ToolStripMenuItem menuItemRegistroUsuarios;
        private System.Windows.Forms.ToolStripMenuItem menuItemRegistroHistoria;
        private System.Windows.Forms.ToolStripMenuItem menuItemRegistroEmpleados;
        private System.Windows.Forms.ToolStripMenuItem menuItemRegistroEmpleadosRegistrar;
        private System.Windows.Forms.ToolStripMenuItem menuItemRegistroEmpleadosLista;
        private System.Windows.Forms.ToolStripMenuItem menuItemRegistroUsuariosLista;
        private System.Windows.Forms.ToolStripMenuItem menuItemRegistroHistoriaRegistrar;
        private System.Windows.Forms.ToolStripMenuItem menuItemRegistroHistoriaLista;
        private System.Windows.Forms.ToolStripMenuItem menuItemCitasNueva;
        private System.Windows.Forms.ToolStripMenuItem menuItemCitasAgenda;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnFacturacion;
        private System.Windows.Forms.Button btnAtencion;
        private System.Windows.Forms.Button btnNuevaHistoria;
        private System.Windows.Forms.Button btnRegistrarCita;
        private System.Windows.Forms.Button btnConsultarDisponibilidad;
        private System.Windows.Forms.Label lblUsuario;
        private System.Windows.Forms.ToolStripMenuItem menuItemAtencionRegistrar;
        private System.Windows.Forms.ToolStripMenuItem menuItemAtencionLista;
        private System.Windows.Forms.ToolStripMenuItem menuItemFacturaGenerar;
        private System.Windows.Forms.ToolStripMenuItem menuItemFacturaLista;
        private System.Windows.Forms.ToolStripMenuItem menuItemArchivoSalir;
    }
}