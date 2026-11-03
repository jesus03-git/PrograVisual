namespace Ejercicio11_Tema6_Hilos
{
    partial class Form1
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
            this.lblHora = new System.Windows.Forms.Label();
            this.bpProgreso = new System.Windows.Forms.ProgressBar();
            this.btnIniciar = new System.Windows.Forms.Button();
            this.lblCargaUCP = new System.Windows.Forms.Label();
            this.numCargaUCP = new System.Windows.Forms.NumericUpDown();
            this.timerHora = new System.Windows.Forms.Timer(this.components);
            this.hiloTrabajador = new System.ComponentModel.BackgroundWorker();
            ((System.ComponentModel.ISupportInitialize)(this.numCargaUCP)).BeginInit();
            this.SuspendLayout();
            // 
            // lblHora
            // 
            this.lblHora.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHora.Location = new System.Drawing.Point(24, 25);
            this.lblHora.Name = "lblHora";
            this.lblHora.Size = new System.Drawing.Size(432, 40);
            this.lblHora.TabIndex = 0;
            this.lblHora.Text = "00:00:00";
            this.lblHora.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // bpProgreso
            // 
            this.bpProgreso.Location = new System.Drawing.Point(30, 85);
            this.bpProgreso.Name = "bpProgreso";
            this.bpProgreso.Size = new System.Drawing.Size(420, 28);
            this.bpProgreso.TabIndex = 1;
            // 
            // btnIniciar
            // 
            this.btnIniciar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnIniciar.Location = new System.Drawing.Point(180, 135);
            this.btnIniciar.Name = "btnIniciar";
            this.btnIniciar.Size = new System.Drawing.Size(120, 35);
            this.btnIniciar.TabIndex = 2;
            this.btnIniciar.Text = "Cálculo";
            this.btnIniciar.UseVisualStyleBackColor = true;
            this.btnIniciar.Click += new System.EventHandler(this.btnIniciar_Click);
            // 
            // lblCargaUCP
            // 
            this.lblCargaUCP.AutoSize = true;
            this.lblCargaUCP.Location = new System.Drawing.Point(215, 205);
            this.lblCargaUCP.Name = "lblCargaUCP";
            this.lblCargaUCP.Size = new System.Drawing.Size(79, 16);
            this.lblCargaUCP.TabIndex = 3;
            this.lblCargaUCP.Text = "Carga UCP:";
            // 
            // numCargaUCP
            // 
            this.numCargaUCP.Increment = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this.numCargaUCP.Location = new System.Drawing.Point(305, 203);
            this.numCargaUCP.Maximum = new decimal(new int[] {
            100000000,
            0,
            0,
            0});
            this.numCargaUCP.Minimum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this.numCargaUCP.Name = "numCargaUCP";
            this.numCargaUCP.Size = new System.Drawing.Size(145, 22);
            this.numCargaUCP.TabIndex = 4;
            this.numCargaUCP.Value = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            // 
            // timerHora
            // 
            this.timerHora.Enabled = true;
            this.timerHora.Interval = 1000;
            this.timerHora.Tick += new System.EventHandler(this.timerHora_Tick);
            // 
            // hiloTrabajador
            // 
            this.hiloTrabajador.WorkerReportsProgress = true;
            this.hiloTrabajador.WorkerSupportsCancellation = true;
            this.hiloTrabajador.DoWork += new System.ComponentModel.DoWorkEventHandler(this.hiloTrabajador_DoWork);
            this.hiloTrabajador.ProgressChanged += new System.ComponentModel.ProgressChangedEventHandler(this.hiloTrabajador_ProgressChanged);
            this.hiloTrabajador.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.hiloTrabajador_RunWorkerCompleted);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(482, 253);
            this.Controls.Add(this.numCargaUCP);
            this.Controls.Add(this.lblCargaUCP);
            this.Controls.Add(this.btnIniciar);
            this.Controls.Add(this.bpProgreso);
            this.Controls.Add(this.lblHora);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Multiproceso";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.numCargaUCP)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblHora;
        private System.Windows.Forms.ProgressBar bpProgreso;
        private System.Windows.Forms.Button btnIniciar;
        private System.Windows.Forms.Label lblCargaUCP;
        private System.Windows.Forms.NumericUpDown numCargaUCP;
        private System.Windows.Forms.Timer timerHora;
        private System.ComponentModel.BackgroundWorker hiloTrabajador;
    }
}
