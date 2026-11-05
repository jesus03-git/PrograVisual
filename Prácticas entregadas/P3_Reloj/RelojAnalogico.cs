using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing.Drawing2D;

namespace P1_Reloj
{
    public partial class RelojAnalogico : Form
    {
        private Point m_Centro = new Point();
        private int m_Radio;
        private DateTime m_Hora;

        public RelojAnalogico()
        {
            InitializeComponent();

            m_Hora = DateTime.Now;
            ActualizarDimensiones();
        }

        public DateTime Hora
        {
            set
            {
                m_Hora = value;
                Invalidate();
            }
        }

        private void RelojAnalogico_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (this.Focused)
            {
                e.Cancel = true;
            }
        }

        private void ActualizarDimensiones()
        {
            m_Centro.X = this.ClientSize.Width / 2;
            m_Centro.Y = this.ClientSize.Height / 2;
            m_Radio = Math.Min(m_Centro.X, m_Centro.Y);
        }

        private void RelojAnalogico_Resize(object sender, EventArgs e)
        {
            ActualizarDimensiones ();
            Invalidate();
        }

        private void RelojAnalogico_Paint(object sender, PaintEventArgs e)
        {
            if (m_Radio <= 10)
                return;

            Graphics gfx = e.Graphics;

            Pen lapizNormal = new Pen(Color.Black, 1);
            Pen lapizGordoNegro = new Pen(Color.Black, 2);
            Pen lapizGordoRojo = new Pen(Color.Red, 2);
            Pen lapizMuyGordoAzul = new Pen(Color.Blue, 4);

            HatchBrush brochaGris =
                new HatchBrush(HatchStyle.Sphere, Color.Gray, Color.Gray);

            float alfa, x, y;

            // Llevamos el origen de coordenadas al centro
            // y hacemos que el eje Y aumente hacia arriba
            Matrix matriz = new Matrix(
                1, 0,
                0, -1,
                m_Centro.X,
                m_Centro.Y);

            gfx.Transform = matriz;

            // Esfera
            float radioEsfera = m_Radio * 0.95f;

            gfx.DrawEllipse(
                lapizNormal,
                -radioEsfera,
                -radioEsfera,
                radioEsfera * 2,
                radioEsfera * 2);

            // Marcas de los minutos
            for (int i = 0; i < 60; i++)
            {
                alfa = (float)(i * Math.PI * 2 / 60);

                x = (float)(Math.Sin(alfa) * m_Radio);
                y = (float)(Math.Cos(alfa) * m_Radio);

                if (i % 5 == 0)
                {
                    gfx.DrawLine(
                        lapizGordoNegro,
                        x * 0.85f, y * 0.85f,
                        x * 0.95f, y * 0.95f);
                }
                else
                {
                    gfx.DrawLine(
                        lapizNormal,
                        x * 0.9f, y * 0.9f,
                        x * 0.95f, y * 0.95f);
                }
            }

            // Manecilla de las horas
            alfa = (float)((m_Hora.Hour % 12) * Math.PI * 2 / 12);
            alfa += (float)(m_Hora.Minute * Math.PI * 2 / 12 / 60);

            x = (float)(Math.Sin(alfa) * m_Radio);
            y = (float)(Math.Cos(alfa) * m_Radio);

            gfx.DrawLine(
                lapizMuyGordoAzul,
                0, 0,
                x * 0.5f, y * 0.5f);

            // Manecilla de los minutos
            alfa = (float)((m_Hora.Minute % 60) * Math.PI * 2 / 60);
            alfa += (float)(m_Hora.Second * Math.PI * 2 / 60 / 60);

            x = (float)(Math.Sin(alfa) * m_Radio);
            y = (float)(Math.Cos(alfa) * m_Radio);

            gfx.DrawLine(
                lapizGordoNegro,
                0, 0,
                x * 0.75f, y * 0.75f);

            // Manecilla de los segundos
            alfa = (float)((m_Hora.Second % 60) * Math.PI * 2 / 60);

            x = (float)(Math.Sin(alfa) * m_Radio);
            y = (float)(Math.Cos(alfa) * m_Radio);

            gfx.DrawLine(
                lapizGordoRojo,
                0, 0,
                x * 0.9f, y * 0.9f);

            // Botón central
            float radioBoton = m_Radio * 0.1f / 2;

            gfx.DrawEllipse(
                lapizGordoNegro,
                -radioBoton,
                -radioBoton,
                radioBoton * 2,
                radioBoton * 2);

            gfx.FillEllipse(
                brochaGris,
                -radioBoton,
                -radioBoton,
                radioBoton * 2,
                radioBoton * 2);
        }

        private void RelojAnalogico_MouseDown(object sender, MouseEventArgs e)
        {
            ArrastrarAgujas(sender, e);
        }

        private void RelojAnalogico_MouseMove(object sender, MouseEventArgs e)
        {
            ArrastrarAgujas(sender, e);
        }

        private void ArrastrarAgujas(object sender, MouseEventArgs e)
        {
            bool botonDerIzq = e.Button == MouseButtons.Right ||
                               e.Button == MouseButtons.Left;

            bool pulsadoCentro =
                (e.X == m_Centro.X && e.Y == m_Centro.Y);

            if (m_Radio < 10 || !botonDerIzq || pulsadoCentro)
                return;

            double alfa;

            int horas = m_Hora.Hour;
            int minutos = m_Hora.Minute;

            int minutosAntes = m_Hora.Minute;

            alfa = Math.Atan2(
                m_Centro.X - e.X,
                e.Y - m_Centro.Y);

            // BOTÓN IZQUIERDO:
            // ajustar horas y minutos
            if (e.Button == MouseButtons.Left)
            {
                minutos = (int)((12 * alfa / (2 * Math.PI) + 6) * 60);

                horas = (minutos / 60) % 12;

                minutos %= 60;

                // Ctrl + botón izquierdo → PM
                if ((Control.ModifierKeys & Keys.Control) == Keys.Control)
                    horas += 12;
            }

            // BOTÓN DERECHO:
            // ajustar solamente los minutos
            if (e.Button == MouseButtons.Right)
            {
                minutos = (int)(60 * alfa / (2 * Math.PI) + 30) % 60;

                // Si cruzamos las 12 hacia atrás
                if (minutos > minutosAntes &&
                    minutos - minutosAntes > 30)
                {
                    horas--;
                }

                // Si cruzamos las 12 hacia delante
                else if (minutos < minutosAntes &&
                         minutosAntes - minutos > 30)
                {
                    horas++;
                }

                if (horas == -1)
                    horas = 23;

                else if (horas == 24)
                    horas = 0;
            }

            RelojDigital relojD = (RelojDigital)this.Owner;

            relojD.CambiarHora(
                horas,
                minutos,
                m_Hora.Second);
        }
    }
}
