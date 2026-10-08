namespace Ejercicio2_Tema1_PEI1
{
    partial class Contraseña
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
            this.ctContraseña = new System.Windows.Forms.TextBox();
            this.bt_Contraseña = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.SuspendLayout();
            // 
            // ctContraseña
            // 
            this.ctContraseña.Location = new System.Drawing.Point(71, 78);
            this.ctContraseña.Name = "ctContraseña";
            this.ctContraseña.Size = new System.Drawing.Size(136, 20);
            this.ctContraseña.TabIndex = 0;
            this.ctContraseña.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // bt_Contraseña
            // 
            this.bt_Contraseña.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.bt_Contraseña.Location = new System.Drawing.Point(99, 129);
            this.bt_Contraseña.Name = "bt_Contraseña";
            this.bt_Contraseña.Size = new System.Drawing.Size(75, 23);
            this.bt_Contraseña.TabIndex = 1;
            this.bt_Contraseña.Text = "Aceptar";
            this.bt_Contraseña.UseVisualStyleBackColor = true;
            this.bt_Contraseña.Click += new System.EventHandler(this.sContraseña_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(68, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(61, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Contraseña";
            // 
            // Contraseña
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(285, 191);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.bt_Contraseña);
            this.Controls.Add(this.ctContraseña);
            this.Name = "Contraseña";
            this.Text = "Contraseña";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox ctContraseña;
        private System.Windows.Forms.Button bt_Contraseña;
        private System.Windows.Forms.Label label1;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
    }
}

