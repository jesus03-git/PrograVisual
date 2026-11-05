namespace P1_Reloj
{
    partial class DlgDatosZona
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
            this.label1 = new System.Windows.Forms.Label();
            this.ct_Nombre = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.ct_Diferencia = new P1_Reloj.EditHora();
            this.rb_Positivo = new System.Windows.Forms.RadioButton();
            this.rb_Negativo = new System.Windows.Forms.RadioButton();
            this.bt_Aceptar = new System.Windows.Forms.Button();
            this.bt_Cancelar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(47, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "Nombre:";
            // 
            // ct_Nombre
            // 
            this.ct_Nombre.Location = new System.Drawing.Point(50, 53);
            this.ct_Nombre.Name = "ct_Nombre";
            this.ct_Nombre.Size = new System.Drawing.Size(100, 20);
            this.ct_Nombre.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(47, 98);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(93, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Diferencia horaria:";
            // 
            // ct_Diferencia
            // 
            this.ct_Diferencia.BeepOnError = true;
            this.ct_Diferencia.Hora = new System.DateTime(((long)(0)));
            this.ct_Diferencia.Location = new System.Drawing.Point(50, 125);
            this.ct_Diferencia.Mask = "90:00:99";
            this.ct_Diferencia.Name = "ct_Diferencia";
            this.ct_Diferencia.PromptChar = '-';
            this.ct_Diferencia.Size = new System.Drawing.Size(100, 20);
            this.ct_Diferencia.TabIndex = 1;
            this.ct_Diferencia.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.ct_Diferencia.TextMaskFormat = System.Windows.Forms.MaskFormat.IncludePromptAndLiterals;
            // 
            // rb_Positivo
            // 
            this.rb_Positivo.AutoSize = true;
            this.rb_Positivo.Checked = true;
            this.rb_Positivo.Location = new System.Drawing.Point(49, 161);
            this.rb_Positivo.Name = "rb_Positivo";
            this.rb_Positivo.Size = new System.Drawing.Size(62, 17);
            this.rb_Positivo.TabIndex = 2;
            this.rb_Positivo.TabStop = true;
            this.rb_Positivo.Text = "Positivo";
            this.rb_Positivo.UseVisualStyleBackColor = true;
            // 
            // rb_Negativo
            // 
            this.rb_Negativo.AutoSize = true;
            this.rb_Negativo.Location = new System.Drawing.Point(49, 184);
            this.rb_Negativo.Name = "rb_Negativo";
            this.rb_Negativo.Size = new System.Drawing.Size(68, 17);
            this.rb_Negativo.TabIndex = 3;
            this.rb_Negativo.Text = "Negativo";
            this.rb_Negativo.UseVisualStyleBackColor = true;
            // 
            // bt_Aceptar
            // 
            this.bt_Aceptar.Location = new System.Drawing.Point(50, 216);
            this.bt_Aceptar.Name = "bt_Aceptar";
            this.bt_Aceptar.Size = new System.Drawing.Size(75, 23);
            this.bt_Aceptar.TabIndex = 4;
            this.bt_Aceptar.Text = "Aceptar";
            this.bt_Aceptar.UseVisualStyleBackColor = true;
            this.bt_Aceptar.Click += new System.EventHandler(this.bt_Aceptar_Click);
            // 
            // bt_Cancelar
            // 
            this.bt_Cancelar.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.bt_Cancelar.Location = new System.Drawing.Point(50, 255);
            this.bt_Cancelar.Name = "bt_Cancelar";
            this.bt_Cancelar.Size = new System.Drawing.Size(75, 23);
            this.bt_Cancelar.TabIndex = 5;
            this.bt_Cancelar.Text = "Cancelar";
            this.bt_Cancelar.UseVisualStyleBackColor = true;
            // 
            // DlgDatosZona
            // 
            this.AcceptButton = this.bt_Aceptar;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.bt_Cancelar;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.bt_Cancelar);
            this.Controls.Add(this.bt_Aceptar);
            this.Controls.Add(this.rb_Negativo);
            this.Controls.Add(this.rb_Positivo);
            this.Controls.Add(this.ct_Diferencia);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.ct_Nombre);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "DlgDatosZona";
            this.Text = "DlgDatosZona";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox ct_Nombre;
        private System.Windows.Forms.Label label2;
        private EditHora ct_Diferencia;
        private System.Windows.Forms.RadioButton rb_Positivo;
        private System.Windows.Forms.RadioButton rb_Negativo;
        private System.Windows.Forms.Button bt_Aceptar;
        private System.Windows.Forms.Button bt_Cancelar;
    }
}