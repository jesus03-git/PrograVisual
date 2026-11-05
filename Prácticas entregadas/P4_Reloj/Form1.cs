using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace P1_Reloj
{
    public partial class RelojDigital : Form
    {
        private TimeSpan m_DesfaseHorario = new TimeSpan(0);

        private RelojAnalogico m_RelojAnalogico = new RelojAnalogico();

        private bool m_DespertadorActivado = false;

        //const int MaxZonas = 4;

        private List<ZonaHoraria> m_Zonas = new List<ZonaHoraria>();

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
            toolTip1.SetToolTip(menuStrip1, Properties.Resources.mensajeBarraMenus);

            try
            {
                if (File.Exists("reloj.dat"))
                {
                    using (Stream stream = File.Open("reloj.dat", FileMode.Open))
                    {
                        BinaryFormatter bin = new BinaryFormatter();
                        m_Zonas = (List<ZonaHoraria>)bin.Deserialize(stream);

                        foreach (ZonaHoraria nuevaZona in m_Zonas)
                        {
                            AñadirOrdenZona(nuevaZona);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("No se pudo leer el archivo de zonas. Causa: " +  ex.Message);
            }
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

            if (!DespertadorActivado)
                return;

            // Comprobamos si lo escrito en alarma es una hora válida, si no es válida se da un aviso.
            if (!ct_Alarma.HoraValida)
            {
                System.Diagnostics.Debug.WriteLine("Hora alarma no valida");
                return;
            }

            DateTime horaActual = DateTime.Now + m_DesfaseHorario;
            DateTime horaAlarma = ct_Alarma.Hora;

            int segundosActual = horaActual.Second + horaActual.Minute * 60 + horaActual.Hour * 3600;
            int segundosAlarma = horaAlarma.Second + horaAlarma.Minute * 60 + horaAlarma.Hour * 3600;

            // ¿Hemos llegado o pasado la hora de la alarma?
            if (segundosActual >= segundosAlarma)
            {
                // ¿Han pasado menos de 300 segundos desde la alarma? -> La alarma suena 5 minutos seguidos.
                if (segundosActual -  segundosAlarma < 300)
                {
                    Console.Beep();
                }
            }
            else if (segundosAlarma - segundosActual > 86400 - 300) // En caso de que la alarma atraviese medianoche: 23:59 -> 00:01
            {
                Console.Beep();
            }
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

        private void bt_ZonaHoraria_Click(object sender, EventArgs e)
        {
            DlgDatosZona dlg = new DlgDatosZona();

            // Abre dlgDatosZona y continúa si el diálogo se ha cerrado con datos válidos.
            if (dlg.ShowDialog() == DialogResult.OK)
            {
                string desfase = dlg.Diferencia.ToString();

                // Operador que permite cambiar el signo a positivo o negativo dependiendo de lo que tenga dlg.Positivo.
                string signo = dlg.Positivo ? "Positivo" : "Negativo";

                MessageBox.Show(
                    "Nombre " + dlg.Nombre +
                    "\nDiferencia: " + desfase +
                    "\nSigno: " + signo,
                    "Datos de la zona",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information);
            }
        }

        public bool DespertadorActivado
        {
            get
            {
                return m_DespertadorActivado;
            }
            set
            {
                m_DespertadorActivado = value;

                // Activamos el check visual del checkbox.
                cv_Despertador.Checked = m_DespertadorActivado;

                OpcionesDespertadorActivar.Enabled = !m_DespertadorActivado;
                OpcionesDespertadorDesactivar.Enabled = m_DespertadorActivado;

                // DespertadorActivar.Text = m_DespertadorActivado ? "Desacti&var" : "Acti&var";
                // DespertadorActivar.Checked = m_DespertadorActivado;
            }
        }

        private void DespertadorActivar_Click(object sender, EventArgs e)
        {
            this.DespertadorActivado = !this.DespertadorActivado;
        }

        private void OpcionesDespertadorActivar_Click(object sender, EventArgs e)
        {
            this.DespertadorActivado = true;
        }

        private void OpcionesDespertadorDesactivar_Click(object sender, EventArgs e)
        {
            this.DespertadorActivado = false;
        }

        public int NumeroZonas
        {
            get
            {
                return m_Zonas.Count;
            }
        }

        public List<ZonaHoraria> zonas
        {
            get
            {
                return m_Zonas;
            }
        }

        private void menuZona_DropDownOpened(object sender, EventArgs e)
        {
//            zonaAñadir.Visible = this.NumeroZonas < MaxZonas;

            zonaEliminar.Visible = this.NumeroZonas > 0;

            zonaSeparador.Visible = this.NumeroZonas > 0;
        }

        private void zonaAñadir_Click(object sender, EventArgs e)
        {
            //            if (this.NumeroZonas == MaxZonas)
            //            {
            //                Console.Beep();
            //                return;
            //            }

            //            ToolStripMenuItem zonaNueva = new ToolStripMenuItem();

            //            zonaNueva.Text = "Zona " + (this.NumeroZonas + 1);

            //            zonaNueva.Click += zona_Click;

            //            menuContextoZona.Items.Add(zonaNueva);

            DlgDatosZona dlgZona = new DlgDatosZona();

            if (dlgZona.ShowDialog() == DialogResult.OK)
            {
                bool existe = m_Zonas.Exists(
                    delegate (ZonaHoraria zona)
                    {
                        return zona.Nombre == dlgZona.Nombre;
                    }
                );

                if (existe)
                {
                    MessageBox.Show("Ya existe una zona llamada " + dlgZona.Nombre);
                    return;
                }

                ZonaHoraria nuevaZona = new ZonaHoraria();
                nuevaZona.Nombre = dlgZona.Nombre;
                nuevaZona.Diferencia = dlgZona.Diferencia;
                nuevaZona.Positivo = dlgZona.Positivo;

                m_Zonas.Add(nuevaZona);

                // Llamamos al nuevo método auxiliar
                AñadirOrdenZona(nuevaZona);
            }
        }

        private void AñadirOrdenZona(ZonaHoraria nuevaZona)
        {
            ToolStripMenuItem nuevaOpcion = new ToolStripMenuItem(nuevaZona.Nombre);
            nuevaOpcion.Click += new EventHandler(zona_Click);
            menuZona.DropDownItems.Add(nuevaOpcion);
        }

        private void zonaEliminar_Click(object sender, EventArgs e)
        {
            if (this.NumeroZonas == 0)
            {
                Console.Beep();
                return;
            }

            //menuContextoZona.Items.RemoveAt(
            //    menuContextoZona.Items.Count - 1);

            //if (m_Zonas.Count > 0)
            //{
            //    m_Zonas.RemoveAt(m_Zonas.Count - 1);
            //}

            DlgEliminarZona dlg = new DlgEliminarZona();

            dlg.Owner = this;

            if (dlg.ShowDialog() == DialogResult.OK)
            {
                int indice = dlg.ZonaSeleccionada;

                if (indice != -1)
                {
                    string nombreZonaABorrar = m_Zonas[indice].Nombre;

                    m_Zonas.RemoveAt(indice);

                    foreach (ToolStripItem item in menuZona.DropDownItems)
                    {
                        if (item.Text == nombreZonaABorrar)
                        {
                            menuZona.DropDownItems.Remove(item);
                            break; 
                        }
                    }
                }
            }
        }

        private void zona_Click(object sender, EventArgs e)
        {
            //ToolStripMenuItem zona = (ToolStripMenuItem)sender;

            //MessageBox.Show(
            //    "Ha seleccionado " + zona.Text,
            //    "Zona seleccionada",
            //    MessageBoxButtons.OK,
            //    MessageBoxIcon.Information);

            ToolStripMenuItem opcion = (ToolStripMenuItem)sender;
            string nombreZona = opcion.Text;

            ZonaHoraria zona = m_Zonas.Find(
                delegate (ZonaHoraria z)
                {
                    return z.Nombre == nombreZona;
                }
            );

            if (zona != null)
            {
                DateTime horaZona;

                if (zona.Positivo)
                    horaZona = DateTime.Now + m_DesfaseHorario + zona.Diferencia;
                else
                    horaZona = DateTime.Now + m_DesfaseHorario - zona.Diferencia;

                MessageBox.Show("Hora en " + zona.Nombre + ": " + horaZona.ToLongTimeString());
            }
        }

        private void cv_Despertador_CheckedChanged(object sender, EventArgs e)
        {
            // Vinculamos el check del despertador con el check de la checkbox.
            this.DespertadorActivado = cv_Despertador.Checked;
        }

        private void RelojDigital_FormClosing(object sender, FormClosingEventArgs e)
        {
            try
            {
                using (Stream stream = File.Open("reloj.dat", FileMode.Create))
                {
                    BinaryFormatter bin = new BinaryFormatter();
                    bin.Serialize(stream, m_Zonas);
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("No se pudo crear el archivo de zonas. Causa: " + ex.Message);
            }
        }
    }
}
    

