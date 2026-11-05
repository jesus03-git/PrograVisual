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
    public partial class RelojDigital : Form
    {
        private TimeSpan m_DesfaseHorario = new TimeSpan(0);

        private RelojAnalogico m_RelojAnalogico = new RelojAnalogico();

        public RelojDigital()
        {
            InitializeComponent();

            ct_HoraActual.Font = new Font("Arial", 12, FontStyle.Bold);

            ct_HoraActual.BackColor = Color.White;
            ct_HoraActual.ForeColor = Color.Blue;

            MostrarHoraActual();

            //m_RelojAnalogico.Show(this);
        }

        private void MostrarHoraActual()
        {
            DateTime hora = DateTime.Now + m_DesfaseHorario;
            ct_HoraActual.Text = hora.ToLongTimeString();
            m_RelojAnalogico.Hora = hora;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
            //this.Close();
        }

        private void acercaDeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AcercaDe dlg = new AcercaDe(); // Creamos un objeto de clase "AcercaDe"
            dlg.ShowDialog(); // Muestra esa ventana como un diálogo
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            MostrarHoraActual();
        }

        private void RelojDigital_Shown(object sender, EventArgs e)
        {
            m_RelojAnalogico.Location = new Point(this.Right + 10, this.Top);

            m_RelojAnalogico.Show(this);
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            MostrarHoraActual();
        }

        private void bt_Mostrar_Click(object sender, EventArgs e)
        {
            m_RelojAnalogico.Visible = !m_RelojAnalogico.Visible;

        }
        internal void CambiarHora(int horas, int minutos, int segundos)
        {
            DateTime actual = DateTime.Now;

            DateTime hora = new DateTime(
                actual.Year,
                actual.Month,
                actual.Day,
                horas,
                minutos,
                segundos);

            m_DesfaseHorario = hora - actual;

            MostrarHoraActual();
        }

        private void bt_ColorFondo_Click(object sender, EventArgs e)
        {
            ColorDialog dlgColor = new ColorDialog();

            dlgColor.Color = ct_HoraActual.BackColor;

            if (dlgColor.ShowDialog() == DialogResult.OK)
            {
                ct_HoraActual.BackColor = dlgColor.Color;
            }
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            FontDialog dlgFuente = new FontDialog();

            dlgFuente.Font = ct_HoraActual.Font;
            dlgFuente.Color = ct_HoraActual.ForeColor;
            dlgFuente.ShowColor = true;

            if (dlgFuente.ShowDialog() == DialogResult.OK)
            {
                ct_HoraActual.Font = dlgFuente.Font;
                ct_HoraActual.ForeColor = dlgFuente.Color;
            }
        }

        private void mostrarAnalógicoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            m_RelojAnalogico.Visible = !m_RelojAnalogico.Visible;
        }

        private void colorFondoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ColorDialog dlgColor = new ColorDialog();

            dlgColor .Color = ct_HoraActual.BackColor;

            if (dlgColor .ShowDialog() == DialogResult.OK)
            {
                ct_HoraActual .BackColor = dlgColor.Color;
            }
        }

        private void fuenteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FontDialog dlgFuente = new FontDialog();

            dlgFuente.Font = ct_HoraActual.Font;
            dlgFuente.Color = ct_HoraActual.ForeColor;
            dlgFuente.ShowColor = true;

            if (dlgFuente.ShowDialog() == DialogResult.OK)
            {
                ct_HoraActual.Font = dlgFuente.Font;
                ct_HoraActual.ForeColor = dlgFuente.Color;
            }
        }

        private void opcionesToolStripMenuItem_DropDownOpened(object sender, EventArgs e)
        {
            mostrarAnalógicoToolStripMenuItem.Checked = m_RelojAnalogico.Visible;
        }
    }
}
    

