using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;

namespace P6_Hilos
{
    public partial class Principal : Form
    {
        private List<int> m_Valores;
        private int m_Indice;

        // Hilo A
        private Thread m_HiloA;
        private ManualResetEvent m_PararHiloA = new ManualResetEvent(false);
        private ManualResetEvent m_ParadoHiloA = new ManualResetEvent(false);

        // Hilo B
        private Thread m_HiloB;
        private ManualResetEvent m_PararHiloB = new ManualResetEvent(false);
        private ManualResetEvent m_ParadoHiloB = new ManualResetEvent(false);

        private object m_Bloqueo = new object();

        public Principal()
        {
            InitializeComponent();

            // Sincronizamos el maximo inicial de la barra de progreso con el valor en el selector.
            bp_Progreso.Maximum = (int)ct_Velocidad.Value;
        }

        private void bt_Mostrar_Click(object sender, EventArgs e)
        {
            // Muestra / Oculta la imagen y conmuta el texto del botón.
            pb_Imagen.Visible = !pb_Imagen.Visible;
            bt_Mostrar.Text = pb_Imagen.Visible ? "Ocultar Imagen" : "Mostrar Imagen";
        }

        // Su valor define el maximo de la barra de progreso.
        private void ct_Velocidad_ValueChanged(object sender, EventArgs e)
        {
            // Mantiene el valor maximo sincronizado con el valor del selector.
            bp_Progreso.Maximum = (int)ct_Velocidad.Value;
        }

        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void acercaDeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Muestra el cuadro de dialogo al hacer click en el boton "Acerca de".
            MessageBox.Show("Práctica 6: Hilos en C#.NET", "Acerca de", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void bt_Iniciar_Click(object sender, EventArgs e)
        {
            // Inicializamos la lista a 0 elementos y el índice a 0
            m_Valores = new List<int>();
            m_Indice = 0;
            bp_Progreso.Value = 0;

            // Inhabilitamos el boton y selector de velocidad
            bt_Iniciar.Enabled = false;
            ct_Velocidad.Enabled = false;

            // LLamamos al método de actualizar
            //ActualizarA();

            // Reseteamos las señales del hijo por si se pulsa varias veces el botón.
            m_PararHiloA.Reset();
            m_ParadoHiloA.Reset();
            m_PararHiloB.Reset();
            m_ParadoHiloB.Reset();

            // Creamos y lanzamos el hilo.
            m_HiloA = new Thread(new ThreadStart(ActualizarA));
            m_HiloB = new Thread(new ThreadStart(ActualizarB));
            m_HiloA.Start();
            m_HiloB.Start();
        }

        // Bucle que llama a Progresar mientras no llegue al máximo
        private void ActualizarA()
        {
            while (m_Indice < bp_Progreso.Maximum)
            {
                // Comprobamos en cada iteración si nos han ordenado parar
                if (m_PararHiloA.WaitOne(0, false))
                {
                    // Avisamos al hilo principal que ya hemos parado, salimos del método y finalizamos el hilo.
                    m_ParadoHiloA.Set();
                    return;
                }

                // Sección crítica protegida con mutex
                lock (m_Bloqueo)
                {
                    Progresar();
                }
            }

            // Comrpobamos si la lista tiene los valores en orden correlativos
            for (int i = 0; i < m_Valores.Count; i++)
            {
                if (i != m_Valores[i])
                {
                    MessageBox.Show("Valores [" + i + "] = " + m_Valores[i] + " y debía valer " + i);
                    break;
                }
            }
        }

        // Inserta elementos en la lista y avanza en la barra.
        private void Progresar()
        {
            // Añadimos el indice actual a la lista
            m_Valores.Add(m_Indice);

            // Avanzamos un paso la barra
            ActualizarBarraProgreso();

            // Incrementamos el índice
            m_Indice++;

            // Si ha llegado al final, restauramos los controles
            if (m_Indice >= bp_Progreso.Maximum)
            {
                ActualizarBotonIniciar();
                ActualizarCtVelocidad();
            }
        }

        private void ActualizarBarraProgreso()
        {
            // Si se está ejecutando desde un hilo secundario
            if (bp_Progreso.InvokeRequired)
            {
                // Creamos un delegado apuntando al método y lo invoca para obligar a ejecutarlo dentro del hilo principal.
                MethodInvoker delegado = new MethodInvoker(ActualizarBarraProgreso);
                bp_Progreso.Invoke(delegado);
            }

            // Si no está en un hilo secundario, sino en el principal
            else
            {
                bp_Progreso.PerformStep();
            }
        }

        private void ActualizarBotonIniciar()
        {
            // Si se está ejecutando desde un hilo secundario
            if (bp_Progreso.InvokeRequired)
            {
                // Creamos un delegado apuntando al método y lo invoca para obligar a ejecutarlo dentro del hilo principal.
                MethodInvoker delegado = new MethodInvoker(ActualizarBotonIniciar);
                bt_Iniciar.Invoke(delegado);
            }

            // Si no está en un hilo secundario, sino en el principal
            else
            {
                bt_Iniciar.Enabled = true;
            }
        }

        private void ActualizarCtVelocidad()
        {
            // Si se está ejecutando desde un hilo secundario
            if (bp_Progreso.InvokeRequired)
            {
                // Creamos un delegado apuntando al método y lo invoca para obligar a ejecutarlo dentro del hilo principal.
                MethodInvoker delegado = new MethodInvoker(ActualizarCtVelocidad);
                ct_Velocidad.Invoke(delegado);
            }

            // Si no está en un hilo secundario, sino en el principal
            else
            {
                ct_Velocidad.Enabled = true;
            }
        }

        private void PararHiloA()
        {
            if (m_HiloA != null && m_HiloA.IsAlive)
            {
                // Activamos el evento para decirle que pare
                m_PararHiloA.Set();

                // Esperamos a que termine
                while (m_HiloA.IsAlive)
                {
                    // Evita una espera activa que pueda bloquear
                    m_ParadoHiloA.WaitOne(200, false);

                    // Procesa eventos pendientes de la cola.
                    Application.DoEvents();
                }
            }
        }

        // Cuando cerremos el formulario con la barra de progreso sin terminar.
        private void Principal_FormClosed(object sender, FormClosedEventArgs e)
        {
            // Paramos los hilos y sacamos una ventana de aviso de que el hilo se ha detenido.
            PararHilos();
            MessageBox.Show("Los hilos han sido detenidos", "Hilos detenidos", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void ActualizarB()
        {
            while (m_Indice < bp_Progreso.Maximum)
            {
                if (m_PararHiloB.WaitOne(0, false))
                {
                    m_ParadoHiloB.Set();
                    return;
                }

                // Sección crítica protegida con mutex
                lock (m_Bloqueo)
                {
                    Progresar();
                }
            }
        }

        // Método general para parar ambos hilos de forma segura.
        private void PararHilos()
        {
            // Detener Hilo A
            if (m_HiloA != null && m_HiloA.IsAlive)
            {
                m_PararHiloA.Set();
                while (m_HiloA.IsAlive)
                {
                    m_ParadoHiloA.WaitOne(200, false);
                    Application.DoEvents();
                }
            }

            // Detener Hilo B
            if (m_HiloB != null && m_HiloB.IsAlive)
            {
                m_PararHiloB.Set();
                while (m_HiloB.IsAlive)
                {
                    m_ParadoHiloB.WaitOne(200, false);
                    Application.DoEvents();
                }
            }
        }

        private void detenerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Detenemos los hilos
            PararHilos();
            
            // Devolvemos los controles de los botones
            ActualizarBotonIniciar();
            ActualizarCtVelocidad();
        }
    }
}
