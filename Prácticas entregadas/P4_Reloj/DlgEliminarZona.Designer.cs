namespace P1_Reloj
{
    partial class DlgEliminarZona
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
            this.bt_Cancelar = new System.Windows.Forms.Button();
            this.bt_Aceptar = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lb_Zonas = new System.Windows.Forms.ListBox();
            this.ct_Diferencia = new System.Windows.Forms.TextBox();
            this.ct_Signo = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // bt_Cancelar
            // 
            this.bt_Cancelar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.bt_Cancelar.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.bt_Cancelar.Location = new System.Drawing.Point(44, 301);
            this.bt_Cancelar.Name = "bt_Cancelar";
            this.bt_Cancelar.Size = new System.Drawing.Size(75, 23);
            this.bt_Cancelar.TabIndex = 13;
            this.bt_Cancelar.Text = "Cancelar";
            this.bt_Cancelar.UseVisualStyleBackColor = true;
            // 
            // bt_Aceptar
            // 
            this.bt_Aceptar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.bt_Aceptar.Location = new System.Drawing.Point(44, 262);
            this.bt_Aceptar.Name = "bt_Aceptar";
            this.bt_Aceptar.Size = new System.Drawing.Size(75, 23);
            this.bt_Aceptar.TabIndex = 12;
            this.bt_Aceptar.Text = "Aceptar";
            this.bt_Aceptar.UseVisualStyleBackColor = true;
            this.bt_Aceptar.Click += new System.EventHandler(this.bt_Aceptar_Click);
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(41, 167);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(93, 13);
            this.label2.TabIndex = 14;
            this.label2.Text = "Diferencia horaria:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(41, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 13);
            this.label1.TabIndex = 15;
            this.label1.Text = "Nombre:";
            // 
            // lb_Zonas
            // 
            this.lb_Zonas.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lb_Zonas.FormattingEnabled = true;
            this.lb_Zonas.Location = new System.Drawing.Point(44, 52);
            this.lb_Zonas.Name = "lb_Zonas";
            this.lb_Zonas.Size = new System.Drawing.Size(120, 95);
            this.lb_Zonas.TabIndex = 16;
            this.lb_Zonas.SelectedIndexChanged += new System.EventHandler(this.lb_Zonas_SelectedIndexChanged);
            // 
            // ct_Diferencia
            // 
            this.ct_Diferencia.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.ct_Diferencia.Location = new System.Drawing.Point(44, 186);
            this.ct_Diferencia.Name = "ct_Diferencia";
            this.ct_Diferencia.ReadOnly = true;
            this.ct_Diferencia.Size = new System.Drawing.Size(100, 20);
            this.ct_Diferencia.TabIndex = 17;
            this.ct_Diferencia.TabStop = false;
            // 
            // ct_Signo
            // 
            this.ct_Signo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.ct_Signo.Location = new System.Drawing.Point(44, 236);
            this.ct_Signo.Name = "ct_Signo";
            this.ct_Signo.ReadOnly = true;
            this.ct_Signo.Size = new System.Drawing.Size(100, 20);
            this.ct_Signo.TabIndex = 18;
            this.ct_Signo.TabStop = false;
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(41, 220);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(37, 13);
            this.label3.TabIndex = 19;
            this.label3.Text = "Signo:";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // DlgEliminarZona
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.ct_Signo);
            this.Controls.Add(this.ct_Diferencia);
            this.Controls.Add(this.lb_Zonas);
            this.Controls.Add(this.bt_Cancelar);
            this.Controls.Add(this.bt_Aceptar);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "DlgEliminarZona";
            this.Text = "Eliminar zona horaria";
            this.Load += new System.EventHandler(this.DlgEliminarZona_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button bt_Cancelar;
        private System.Windows.Forms.Button bt_Aceptar;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox lb_Zonas;
        private System.Windows.Forms.TextBox ct_Diferencia;
        private System.Windows.Forms.TextBox ct_Signo;
        private System.Windows.Forms.Label label3;
    }
}