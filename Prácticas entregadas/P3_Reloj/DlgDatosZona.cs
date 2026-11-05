using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace P1_Reloj
{
    public partial class DlgDatosZona : Form
    {
        // Campos privados para los datos del formulario
        private string m_Nombre;
        private TimeSpan m_Diferencia;
        private bool m_Positivo;
        public DlgDatosZona()
        {
            InitializeComponent();
        }

        public string Nombre
        {
            get
            {
                return m_Nombre;
            }
            set
            {
                m_Nombre = value;
            }
        }

        public TimeSpan Diferencia
        {
            get
            {
                return m_Diferencia;
            }
            set
            {
                m_Diferencia = value;
            }
        }

        public bool Positivo
        {
            get
            {
                return m_Positivo;
            }
            set
            {
                m_Positivo = value;
            }
        }

        private void bt_Aceptar_Click(object sender, EventArgs e)
        {
            // Comprobamos que se ha introducido un nombre
            if (ct_Nombre.Text != "")
            {
                this.Nombre = ct_Nombre.Text;
            }
            else
            {
                MessageBox.Show(
                    "Introduzca un nombre para la zona",
                    "Error en los datos",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
                
                ct_Nombre.Focus();
                return;
            }

            if (ct_Diferencia.HoraValida)
            {
                DateTime hora = ct_Diferencia.Hora;

                this.Diferencia = new TimeSpan(
                    hora.Hour,
                    hora.Minute,
                    hora.Second);
            }
            else
            {
                MessageBox.Show(
                    "Introduzca una diferencia horaria válida",
                    "Error en los datos",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);

                ct_Diferencia.Focus();
                ct_Diferencia.SelectAll();

                return;
            }

            // Si la diferencia es positiva o negativa, la guardamos.
            this.Positivo = rb_Positivo.Checked;

            // Ponemos un mensaje de OK si todos los datos son válidos.
            this.DialogResult = DialogResult.OK;
        }
    }
}
