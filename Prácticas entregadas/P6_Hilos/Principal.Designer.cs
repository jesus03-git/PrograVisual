namespace P6_Hilos
{
    partial class Principal
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Principal));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.archivoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.salirToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ayudaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.acercaDeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pb_Imagen = new System.Windows.Forms.PictureBox();
            this.bp_Progreso = new System.Windows.Forms.ProgressBar();
            this.bt_Mostrar = new System.Windows.Forms.Button();
            this.bt_Iniciar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.ct_Velocidad = new System.Windows.Forms.NumericUpDown();
            this.detenerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pb_Imagen)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ct_Velocidad)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.GripMargin = new System.Windows.Forms.Padding(2, 2, 0, 2);
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(32, 32);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.archivoToolStripMenuItem,
            this.ayudaToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1131, 42);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // archivoToolStripMenuItem
            // 
            this.archivoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripSeparator1,
            this.salirToolStripMenuItem,
            this.detenerToolStripMenuItem});
            this.archivoToolStripMenuItem.Name = "archivoToolStripMenuItem";
            this.archivoToolStripMenuItem.Size = new System.Drawing.Size(114, 38);
            this.archivoToolStripMenuItem.Text = "Archivo";
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(356, 6);
            // 
            // salirToolStripMenuItem
            // 
            this.salirToolStripMenuItem.Name = "salirToolStripMenuItem";
            this.salirToolStripMenuItem.Size = new System.Drawing.Size(359, 44);
            this.salirToolStripMenuItem.Text = "Salir";
            this.salirToolStripMenuItem.Click += new System.EventHandler(this.salirToolStripMenuItem_Click);
            // 
            // ayudaToolStripMenuItem
            // 
            this.ayudaToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.acercaDeToolStripMenuItem});
            this.ayudaToolStripMenuItem.Name = "ayudaToolStripMenuItem";
            this.ayudaToolStripMenuItem.Size = new System.Drawing.Size(101, 36);
            this.ayudaToolStripMenuItem.Text = "Ayuda";
            // 
            // acercaDeToolStripMenuItem
            // 
            this.acercaDeToolStripMenuItem.Name = "acercaDeToolStripMenuItem";
            this.acercaDeToolStripMenuItem.Size = new System.Drawing.Size(251, 44);
            this.acercaDeToolStripMenuItem.Text = "Acerca de";
            this.acercaDeToolStripMenuItem.Click += new System.EventHandler(this.acercaDeToolStripMenuItem_Click);
            // 
            // pb_Imagen
            // 
            this.pb_Imagen.Image = ((System.Drawing.Image)(resources.GetObject("pb_Imagen.Image")));
            this.pb_Imagen.Location = new System.Drawing.Point(68, 90);
            this.pb_Imagen.Name = "pb_Imagen";
            this.pb_Imagen.Size = new System.Drawing.Size(394, 370);
            this.pb_Imagen.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pb_Imagen.TabIndex = 1;
            this.pb_Imagen.TabStop = false;
            // 
            // bp_Progreso
            // 
            this.bp_Progreso.Location = new System.Drawing.Point(668, 327);
            this.bp_Progreso.Name = "bp_Progreso";
            this.bp_Progreso.Size = new System.Drawing.Size(280, 87);
            this.bp_Progreso.Step = 1;
            this.bp_Progreso.TabIndex = 2;
            // 
            // bt_Mostrar
            // 
            this.bt_Mostrar.Location = new System.Drawing.Point(607, 519);
            this.bt_Mostrar.Name = "bt_Mostrar";
            this.bt_Mostrar.Size = new System.Drawing.Size(282, 75);
            this.bt_Mostrar.TabIndex = 3;
            this.bt_Mostrar.Text = "Ocultar imagen";
            this.bt_Mostrar.UseVisualStyleBackColor = true;
            this.bt_Mostrar.Click += new System.EventHandler(this.bt_Mostrar_Click);
            // 
            // bt_Iniciar
            // 
            this.bt_Iniciar.Location = new System.Drawing.Point(607, 618);
            this.bt_Iniciar.Name = "bt_Iniciar";
            this.bt_Iniciar.Size = new System.Drawing.Size(282, 75);
            this.bt_Iniciar.TabIndex = 4;
            this.bt_Iniciar.Text = "Iniciar";
            this.bt_Iniciar.UseVisualStyleBackColor = true;
            this.bt_Iniciar.Click += new System.EventHandler(this.bt_Iniciar_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(607, 179);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(107, 25);
            this.label1.TabIndex = 5;
            this.label1.Text = "Velocidad";
            // 
            // ct_Velocidad
            // 
            this.ct_Velocidad.Increment = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.ct_Velocidad.Location = new System.Drawing.Point(758, 177);
            this.ct_Velocidad.Maximum = new decimal(new int[] {
            10000000,
            0,
            0,
            0});
            this.ct_Velocidad.Name = "ct_Velocidad";
            this.ct_Velocidad.Size = new System.Drawing.Size(120, 31);
            this.ct_Velocidad.TabIndex = 6;
            this.ct_Velocidad.Value = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.ct_Velocidad.ValueChanged += new System.EventHandler(this.ct_Velocidad_ValueChanged);
            // 
            // detenerToolStripMenuItem
            // 
            this.detenerToolStripMenuItem.Name = "detenerToolStripMenuItem";
            this.detenerToolStripMenuItem.Size = new System.Drawing.Size(359, 44);
            this.detenerToolStripMenuItem.Text = "Detener";
            this.detenerToolStripMenuItem.Click += new System.EventHandler(this.detenerToolStripMenuItem_Click);
            // 
            // Principal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1131, 757);
            this.Controls.Add(this.ct_Velocidad);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.bt_Iniciar);
            this.Controls.Add(this.bt_Mostrar);
            this.Controls.Add(this.bp_Progreso);
            this.Controls.Add(this.pb_Imagen);
            this.Controls.Add(this.menuStrip1);
            this.Name = "Principal";
            this.Text = "Hilos";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Principal_FormClosed);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pb_Imagen)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ct_Velocidad)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem archivoToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem salirToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ayudaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem acercaDeToolStripMenuItem;
        private System.Windows.Forms.PictureBox pb_Imagen;
        private System.Windows.Forms.ProgressBar bp_Progreso;
        private System.Windows.Forms.Button bt_Mostrar;
        private System.Windows.Forms.Button bt_Iniciar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown ct_Velocidad;
        private System.Windows.Forms.ToolStripMenuItem detenerToolStripMenuItem;
    }
}

