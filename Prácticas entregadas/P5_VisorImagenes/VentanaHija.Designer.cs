namespace P5_VisorImagenes
{
    partial class VentanaHija
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(VentanaHija));
            this.m_PictureBox = new System.Windows.Forms.PictureBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.imagenToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ImagenAjustar = new System.Windows.Forms.ToolStripMenuItem();
            this.rotarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.añadirTextoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ImagenEscalaDeGrises = new System.Windows.Forms.ToolStripMenuItem();
            this.archivoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.guardarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.guardarComoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStrip1Hija = new System.Windows.Forms.ToolStrip();
            this.toolStripButton1 = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripButton2 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton3 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton4 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton5 = new System.Windows.Forms.ToolStripButton();
            ((System.ComponentModel.ISupportInitialize)(this.m_PictureBox)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.toolStrip1Hija.SuspendLayout();
            this.SuspendLayout();
            // 
            // m_PictureBox
            // 
            this.m_PictureBox.Location = new System.Drawing.Point(12, 60);
            this.m_PictureBox.Name = "m_PictureBox";
            this.m_PictureBox.Size = new System.Drawing.Size(313, 223);
            this.m_PictureBox.TabIndex = 0;
            this.m_PictureBox.TabStop = false;
            // 
            // menuStrip1
            // 
            this.menuStrip1.GripMargin = new System.Windows.Forms.Padding(2, 2, 0, 2);
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(32, 32);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.imagenToolStripMenuItem,
            this.archivoToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 42);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            this.menuStrip1.Visible = false;
            // 
            // imagenToolStripMenuItem
            // 
            this.imagenToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ImagenAjustar,
            this.rotarToolStripMenuItem,
            this.añadirTextoToolStripMenuItem,
            this.ImagenEscalaDeGrises});
            this.imagenToolStripMenuItem.MergeAction = System.Windows.Forms.MergeAction.Insert;
            this.imagenToolStripMenuItem.MergeIndex = 2;
            this.imagenToolStripMenuItem.Name = "imagenToolStripMenuItem";
            this.imagenToolStripMenuItem.Size = new System.Drawing.Size(114, 38);
            this.imagenToolStripMenuItem.Text = "Imagen";
            // 
            // ImagenAjustar
            // 
            this.ImagenAjustar.Name = "ImagenAjustar";
            this.ImagenAjustar.Size = new System.Drawing.Size(331, 44);
            this.ImagenAjustar.Text = "Ajustar a ventana";
            this.ImagenAjustar.Click += new System.EventHandler(this.ImagenAjustar_Click);
            // 
            // rotarToolStripMenuItem
            // 
            this.rotarToolStripMenuItem.Name = "rotarToolStripMenuItem";
            this.rotarToolStripMenuItem.Size = new System.Drawing.Size(331, 44);
            this.rotarToolStripMenuItem.Text = "Rotar";
            this.rotarToolStripMenuItem.Click += new System.EventHandler(this.rotarToolStripMenuItem_Click);
            // 
            // añadirTextoToolStripMenuItem
            // 
            this.añadirTextoToolStripMenuItem.Name = "añadirTextoToolStripMenuItem";
            this.añadirTextoToolStripMenuItem.Size = new System.Drawing.Size(331, 44);
            this.añadirTextoToolStripMenuItem.Text = "Añadir texto";
            this.añadirTextoToolStripMenuItem.Click += new System.EventHandler(this.añadirTextoToolStripMenuItem_Click);
            // 
            // ImagenEscalaDeGrises
            // 
            this.ImagenEscalaDeGrises.Name = "ImagenEscalaDeGrises";
            this.ImagenEscalaDeGrises.Size = new System.Drawing.Size(331, 44);
            this.ImagenEscalaDeGrises.Text = "Escala de grises";
            this.ImagenEscalaDeGrises.Click += new System.EventHandler(this.ImagenEscalaDeGrises_Click);
            // 
            // archivoToolStripMenuItem
            // 
            this.archivoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.guardarToolStripMenuItem,
            this.guardarComoToolStripMenuItem,
            this.toolStripSeparator1});
            this.archivoToolStripMenuItem.MergeAction = System.Windows.Forms.MergeAction.MatchOnly;
            this.archivoToolStripMenuItem.Name = "archivoToolStripMenuItem";
            this.archivoToolStripMenuItem.Size = new System.Drawing.Size(114, 38);
            this.archivoToolStripMenuItem.Text = "Archivo";
            // 
            // guardarToolStripMenuItem
            // 
            this.guardarToolStripMenuItem.MergeAction = System.Windows.Forms.MergeAction.Insert;
            this.guardarToolStripMenuItem.MergeIndex = 3;
            this.guardarToolStripMenuItem.Name = "guardarToolStripMenuItem";
            this.guardarToolStripMenuItem.Size = new System.Drawing.Size(359, 44);
            this.guardarToolStripMenuItem.Text = "Guardar";
            this.guardarToolStripMenuItem.Click += new System.EventHandler(this.guardarToolStripMenuItem_Click);
            // 
            // guardarComoToolStripMenuItem
            // 
            this.guardarComoToolStripMenuItem.MergeAction = System.Windows.Forms.MergeAction.Insert;
            this.guardarComoToolStripMenuItem.MergeIndex = 4;
            this.guardarComoToolStripMenuItem.Name = "guardarComoToolStripMenuItem";
            this.guardarComoToolStripMenuItem.Size = new System.Drawing.Size(359, 44);
            this.guardarComoToolStripMenuItem.Text = "Guardar como";
            this.guardarComoToolStripMenuItem.Click += new System.EventHandler(this.guardarComoToolStripMenuItem_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.MergeAction = System.Windows.Forms.MergeAction.Insert;
            this.toolStripSeparator1.MergeIndex = 5;
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(356, 6);
            // 
            // toolStrip1Hija
            // 
            this.toolStrip1Hija.ImageScalingSize = new System.Drawing.Size(32, 32);
            this.toolStrip1Hija.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripButton1,
            this.toolStripSeparator2,
            this.toolStripButton2,
            this.toolStripButton3,
            this.toolStripButton4,
            this.toolStripButton5});
            this.toolStrip1Hija.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1Hija.Name = "toolStrip1Hija";
            this.toolStrip1Hija.Size = new System.Drawing.Size(800, 50);
            this.toolStrip1Hija.TabIndex = 2;
            this.toolStrip1Hija.Text = "toolStrip1";
            this.toolStrip1Hija.Visible = false;
            // 
            // toolStripButton1
            // 
            this.toolStripButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton1.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton1.Image")));
            this.toolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton1.MergeAction = System.Windows.Forms.MergeAction.Insert;
            this.toolStripButton1.MergeIndex = 2;
            this.toolStripButton1.Name = "toolStripButton1";
            this.toolStripButton1.Size = new System.Drawing.Size(46, 44);
            this.toolStripButton1.Text = "Guardar";
            this.toolStripButton1.Click += new System.EventHandler(this.guardarToolStripMenuItem_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.MergeAction = System.Windows.Forms.MergeAction.Insert;
            this.toolStripSeparator2.MergeIndex = 3;
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 50);
            // 
            // toolStripButton2
            // 
            this.toolStripButton2.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton2.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton2.Image")));
            this.toolStripButton2.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton2.MergeAction = System.Windows.Forms.MergeAction.Insert;
            this.toolStripButton2.MergeIndex = 4;
            this.toolStripButton2.Name = "toolStripButton2";
            this.toolStripButton2.Size = new System.Drawing.Size(46, 44);
            this.toolStripButton2.Text = "Ajustar";
            this.toolStripButton2.Click += new System.EventHandler(this.ImagenAjustar_Click);
            // 
            // toolStripButton3
            // 
            this.toolStripButton3.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton3.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton3.Image")));
            this.toolStripButton3.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton3.MergeAction = System.Windows.Forms.MergeAction.Insert;
            this.toolStripButton3.MergeIndex = 5;
            this.toolStripButton3.Name = "toolStripButton3";
            this.toolStripButton3.Size = new System.Drawing.Size(46, 44);
            this.toolStripButton3.Text = "Rotar";
            this.toolStripButton3.Click += new System.EventHandler(this.rotarToolStripMenuItem_Click);
            // 
            // toolStripButton4
            // 
            this.toolStripButton4.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton4.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton4.Image")));
            this.toolStripButton4.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton4.MergeAction = System.Windows.Forms.MergeAction.Insert;
            this.toolStripButton4.MergeIndex = 6;
            this.toolStripButton4.Name = "toolStripButton4";
            this.toolStripButton4.Size = new System.Drawing.Size(46, 44);
            this.toolStripButton4.Text = "Texto";
            this.toolStripButton4.Click += new System.EventHandler(this.añadirTextoToolStripMenuItem_Click);
            // 
            // toolStripButton5
            // 
            this.toolStripButton5.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton5.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton5.Image")));
            this.toolStripButton5.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton5.MergeAction = System.Windows.Forms.MergeAction.Insert;
            this.toolStripButton5.MergeIndex = 7;
            this.toolStripButton5.Name = "toolStripButton5";
            this.toolStripButton5.Size = new System.Drawing.Size(46, 44);
            this.toolStripButton5.Text = "escalaGrises";
            this.toolStripButton5.Click += new System.EventHandler(this.ImagenEscalaDeGrises_Click);
            // 
            // VentanaHija
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.toolStrip1Hija);
            this.Controls.Add(this.m_PictureBox);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "VentanaHija";
            this.Text = "VentanaHija";
            this.Resize += new System.EventHandler(this.VentanaHija_Resize);
            ((System.ComponentModel.ISupportInitialize)(this.m_PictureBox)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.toolStrip1Hija.ResumeLayout(false);
            this.toolStrip1Hija.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox m_PictureBox;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem imagenToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ImagenAjustar;
        private System.Windows.Forms.ToolStripMenuItem rotarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem añadirTextoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ImagenEscalaDeGrises;
        private System.Windows.Forms.ToolStripMenuItem archivoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem guardarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem guardarComoToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStrip toolStrip1Hija;
        private System.Windows.Forms.ToolStripButton toolStripButton1;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripButton toolStripButton2;
        private System.Windows.Forms.ToolStripButton toolStripButton3;
        private System.Windows.Forms.ToolStripButton toolStripButton4;
        private System.Windows.Forms.ToolStripButton toolStripButton5;
    }
}