namespace P1_Reloj
{
    partial class RelojDigital
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.archivoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.salirToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.opcionesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mostrarAnalógicoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.colorFondoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.fuenteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.despertadorToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.menuContextoAlarma = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.OpcionesDespertadorActivar = new System.Windows.Forms.ToolStripMenuItem();
            this.OpcionesDespertadorDesactivar = new System.Windows.Forms.ToolStripMenuItem();
            this.menuZona = new System.Windows.Forms.ToolStripMenuItem();
            this.ayudaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.acercaDeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ct_HoraActual = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.label2 = new System.Windows.Forms.Label();
            this.bt_ZonaHoraria = new System.Windows.Forms.Button();
            this.ct_Alarma = new P1_Reloj.EditHora();
            this.menuContextoZona = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.zonaAñadir = new System.Windows.Forms.ToolStripMenuItem();
            this.zonaEliminar = new System.Windows.Forms.ToolStripMenuItem();
            this.zonaSeparador = new System.Windows.Forms.ToolStripSeparator();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.menuStrip1.SuspendLayout();
            this.menuContextoAlarma.SuspendLayout();
            this.menuContextoZona.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(32, 32);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.archivoToolStripMenuItem,
            this.opcionesToolStripMenuItem,
            this.menuZona,
            this.ayudaToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(3, 1, 0, 1);
            this.menuStrip1.Size = new System.Drawing.Size(737, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            this.toolTip1.SetToolTip(this.menuStrip1, "Añada/elimine una zona pulsando el botón derecho del ratón.");
            // 
            // archivoToolStripMenuItem
            // 
            this.archivoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.salirToolStripMenuItem});
            this.archivoToolStripMenuItem.Name = "archivoToolStripMenuItem";
            this.archivoToolStripMenuItem.Size = new System.Drawing.Size(60, 22);
            this.archivoToolStripMenuItem.Text = "Archivo";
            // 
            // salirToolStripMenuItem
            // 
            this.salirToolStripMenuItem.Name = "salirToolStripMenuItem";
            this.salirToolStripMenuItem.Size = new System.Drawing.Size(96, 22);
            this.salirToolStripMenuItem.Text = "Salir";
            this.salirToolStripMenuItem.Click += new System.EventHandler(this.salirToolStripMenuItem_Click);
            // 
            // opcionesToolStripMenuItem
            // 
            this.opcionesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mostrarAnalógicoToolStripMenuItem,
            this.colorFondoToolStripMenuItem,
            this.fuenteToolStripMenuItem,
            this.despertadorToolStripMenuItem1});
            this.opcionesToolStripMenuItem.Name = "opcionesToolStripMenuItem";
            this.opcionesToolStripMenuItem.Size = new System.Drawing.Size(69, 22);
            this.opcionesToolStripMenuItem.Text = "Opciones";
            this.opcionesToolStripMenuItem.DropDownOpened += new System.EventHandler(this.opcionesToolStripMenuItem_DropDownOpened);
            // 
            // mostrarAnalógicoToolStripMenuItem
            // 
            this.mostrarAnalógicoToolStripMenuItem.Name = "mostrarAnalógicoToolStripMenuItem";
            this.mostrarAnalógicoToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.mostrarAnalógicoToolStripMenuItem.Text = "Mostrar analógico";
            this.mostrarAnalógicoToolStripMenuItem.Click += new System.EventHandler(this.mostrarAnalógicoToolStripMenuItem_Click);
            // 
            // colorFondoToolStripMenuItem
            // 
            this.colorFondoToolStripMenuItem.Name = "colorFondoToolStripMenuItem";
            this.colorFondoToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.colorFondoToolStripMenuItem.Text = "Color fondo";
            this.colorFondoToolStripMenuItem.Click += new System.EventHandler(this.colorFondoToolStripMenuItem_Click);
            // 
            // fuenteToolStripMenuItem
            // 
            this.fuenteToolStripMenuItem.Name = "fuenteToolStripMenuItem";
            this.fuenteToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.fuenteToolStripMenuItem.Text = "Fuente";
            this.fuenteToolStripMenuItem.Click += new System.EventHandler(this.fuenteToolStripMenuItem_Click);
            // 
            // despertadorToolStripMenuItem1
            // 
            this.despertadorToolStripMenuItem1.DropDown = this.menuContextoAlarma;
            this.despertadorToolStripMenuItem1.Name = "despertadorToolStripMenuItem1";
            this.despertadorToolStripMenuItem1.Size = new System.Drawing.Size(180, 22);
            this.despertadorToolStripMenuItem1.Text = "Despertador";
            // 
            // menuContextoAlarma
            // 
            this.menuContextoAlarma.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.OpcionesDespertadorActivar,
            this.OpcionesDespertadorDesactivar});
            this.menuContextoAlarma.Name = "menuContextoAlarma";
            this.menuContextoAlarma.Size = new System.Drawing.Size(170, 48);
            // 
            // OpcionesDespertadorActivar
            // 
            this.OpcionesDespertadorActivar.Name = "OpcionesDespertadorActivar";
            this.OpcionesDespertadorActivar.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.T)));
            this.OpcionesDespertadorActivar.Size = new System.Drawing.Size(169, 22);
            this.OpcionesDespertadorActivar.Text = "Activar";
            this.OpcionesDespertadorActivar.Click += new System.EventHandler(this.OpcionesDespertadorActivar_Click);
            // 
            // OpcionesDespertadorDesactivar
            // 
            this.OpcionesDespertadorDesactivar.Enabled = false;
            this.OpcionesDespertadorDesactivar.Name = "OpcionesDespertadorDesactivar";
            this.OpcionesDespertadorDesactivar.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.V)));
            this.OpcionesDespertadorDesactivar.Size = new System.Drawing.Size(169, 22);
            this.OpcionesDespertadorDesactivar.Text = "Desactivar";
            this.OpcionesDespertadorDesactivar.Click += new System.EventHandler(this.OpcionesDespertadorDesactivar_Click);
            // 
            // menuZona
            // 
            this.menuZona.DropDown = this.menuContextoZona;
            this.menuZona.Name = "menuZona";
            this.menuZona.Size = new System.Drawing.Size(46, 22);
            this.menuZona.Text = "Zona";
            this.menuZona.DropDownOpened += new System.EventHandler(this.menuZona_DropDownOpened);
            // 
            // ayudaToolStripMenuItem
            // 
            this.ayudaToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.acercaDeToolStripMenuItem});
            this.ayudaToolStripMenuItem.Name = "ayudaToolStripMenuItem";
            this.ayudaToolStripMenuItem.Size = new System.Drawing.Size(53, 22);
            this.ayudaToolStripMenuItem.Text = "Ayuda";
            // 
            // acercaDeToolStripMenuItem
            // 
            this.acercaDeToolStripMenuItem.Name = "acercaDeToolStripMenuItem";
            this.acercaDeToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.acercaDeToolStripMenuItem.Text = "Acerca de";
            this.acercaDeToolStripMenuItem.Click += new System.EventHandler(this.acercaDeToolStripMenuItem_Click);
            // 
            // ct_HoraActual
            // 
            this.ct_HoraActual.Location = new System.Drawing.Point(130, 148);
            this.ct_HoraActual.Name = "ct_HoraActual";
            this.ct_HoraActual.ReadOnly = true;
            this.ct_HoraActual.Size = new System.Drawing.Size(100, 20);
            this.ct_HoraActual.TabIndex = 1;
            this.ct_HoraActual.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(127, 113);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Hora actual:";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(127, 180);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(39, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Alarma";
            // 
            // bt_ZonaHoraria
            // 
            this.bt_ZonaHoraria.Location = new System.Drawing.Point(362, 148);
            this.bt_ZonaHoraria.Name = "bt_ZonaHoraria";
            this.bt_ZonaHoraria.Size = new System.Drawing.Size(105, 33);
            this.bt_ZonaHoraria.TabIndex = 5;
            this.bt_ZonaHoraria.Text = "Diálogo zona";
            this.bt_ZonaHoraria.UseVisualStyleBackColor = true;
            this.bt_ZonaHoraria.Click += new System.EventHandler(this.bt_ZonaHoraria_Click);
            // 
            // ct_Alarma
            // 
            this.ct_Alarma.BeepOnError = true;
            this.ct_Alarma.ContextMenuStrip = this.menuContextoAlarma;
            this.ct_Alarma.Hora = new System.DateTime(((long)(0)));
            this.ct_Alarma.Location = new System.Drawing.Point(130, 205);
            this.ct_Alarma.Mask = "90:00:99";
            this.ct_Alarma.Name = "ct_Alarma";
            this.ct_Alarma.PromptChar = '-';
            this.ct_Alarma.Size = new System.Drawing.Size(100, 20);
            this.ct_Alarma.TabIndex = 3;
            this.ct_Alarma.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.ct_Alarma.TextMaskFormat = System.Windows.Forms.MaskFormat.IncludePromptAndLiterals;
            // 
            // menuContextoZona
            // 
            this.menuContextoZona.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.zonaAñadir,
            this.zonaEliminar,
            this.zonaSeparador});
            this.menuContextoZona.Name = "menuContextoZona";
            this.menuContextoZona.Size = new System.Drawing.Size(204, 54);
            this.menuContextoZona.Opened += new System.EventHandler(this.menuZona_DropDownOpened);
            // 
            // zonaAñadir
            // 
            this.zonaAñadir.Name = "zonaAñadir";
            this.zonaAñadir.ShortcutKeys = ((System.Windows.Forms.Keys)(((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Shift) 
            | System.Windows.Forms.Keys.R)));
            this.zonaAñadir.Size = new System.Drawing.Size(203, 22);
            this.zonaAñadir.Text = "Añadir";
            this.zonaAñadir.Click += new System.EventHandler(this.zonaAñadir_Click);
            // 
            // zonaEliminar
            // 
            this.zonaEliminar.Name = "zonaEliminar";
            this.zonaEliminar.ShortcutKeys = ((System.Windows.Forms.Keys)(((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Shift) 
            | System.Windows.Forms.Keys.L)));
            this.zonaEliminar.Size = new System.Drawing.Size(203, 22);
            this.zonaEliminar.Text = "Eliminar";
            this.zonaEliminar.Click += new System.EventHandler(this.zonaEliminar_Click);
            // 
            // zonaSeparador
            // 
            this.zonaSeparador.Name = "zonaSeparador";
            this.zonaSeparador.Size = new System.Drawing.Size(114, 6);
            // 
            // RelojDigital
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(737, 450);
            this.ContextMenuStrip = this.menuContextoZona;
            this.Controls.Add(this.bt_ZonaHoraria);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.ct_Alarma);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ct_HoraActual);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.Name = "RelojDigital";
            this.Text = "Reloj Digital";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.Shown += new System.EventHandler(this.RelojDigital_Shown);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.menuContextoAlarma.ResumeLayout(false);
            this.menuContextoZona.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem archivoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem salirToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ayudaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem acercaDeToolStripMenuItem;
        private System.Windows.Forms.TextBox ct_HoraActual;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.ToolStripMenuItem opcionesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mostrarAnalógicoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem colorFondoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem fuenteToolStripMenuItem;
        private EditHora ct_Alarma;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button bt_ZonaHoraria;
        private System.Windows.Forms.ToolStripMenuItem despertadorToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem menuZona;
        private System.Windows.Forms.ContextMenuStrip menuContextoAlarma;
        private System.Windows.Forms.ToolStripMenuItem OpcionesDespertadorActivar;
        private System.Windows.Forms.ToolStripMenuItem OpcionesDespertadorDesactivar;
        private System.Windows.Forms.ContextMenuStrip menuContextoZona;
        private System.Windows.Forms.ToolStripMenuItem zonaAñadir;
        private System.Windows.Forms.ToolStripMenuItem zonaEliminar;
        private System.Windows.Forms.ToolStripSeparator zonaSeparador;
        private System.Windows.Forms.ToolTip toolTip1;
    }
}

