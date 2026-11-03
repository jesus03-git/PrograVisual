using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;

namespace Ejercicio11_Tema6_Hilos
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        // Evento Load del formulario para inicializar la hora
        private void Form1_Load(object sender, EventArgs e)
        {
            // Mostramos la hora actual desde el inicio
            lblHora.Text = DateTime.Now.ToLongTimeString();
        }

        // Evento Tick del temporizador para actualizar el reloj en tiempo real
        private void timerHora_Tick(object sender, EventArgs e)
        {
            // Mientras la barra de progreso avanza, el Timer sigue atendiendo eventos
            // y la hora se actualiza sin congelar la interfaz gráfica
            lblHora.Text = DateTime.Now.ToLongTimeString();
        }

        // Evento Click del botón "Cálculo" para iniciar la tarea en segundo plano
        private void btnIniciar_Click(object sender, EventArgs e)
        {
            // Comprobamos que el hilo no esté ocupado antes de lanzarlo
            if (!hiloTrabajador.IsBusy)
            {
                // Reiniciamos la barra de progreso
                bpProgreso.Value = 0;

                // Deshabilitamos el botón para evitar ejecuciones concurrentes
                btnIniciar.Enabled = false;
                numCargaUCP.Enabled = false;

                // Lanzamos la ejecución del componente BackgroundWorker
                // Esto disparará el evento DoWork en un hilo secundario
                hiloTrabajador.RunWorkerAsync();
            }
        }

        // Evento DoWork que ejecuta la tarea secundaria en segundo plano
        private void hiloTrabajador_DoWork(object sender, DoWorkEventArgs e)
        {
            // El método asociado a DoWork llama a TareaSecundaria pasándole el
            // hiloTrabajador y la información del evento, recibidos ambos como parámetros
            BackgroundWorker hiloTr = (BackgroundWorker)sender;
            TareaSecundaria(hiloTr, e);
        }

        // Tarea secundaria que realiza el cómputo y reporta el progreso
        private void TareaSecundaria(BackgroundWorker hiloTr, DoWorkEventArgs e)
        {
            int hecho = 0, tpHecho = 0;

            // La propiedad Value de la caja numérica será tenida en cuenta para finalizar la cuenta
            while (hecho < numCargaUCP.Value)
            {
                // Si la aplicación solicita cancelar, activamos e.Cancel y salimos
                if (hiloTr.CancellationPending)
                {
                    e.Cancel = true;
                    return;
                }

                // Tarea secundaria (cómputo)
                hecho += 1;

                // Mostrar progreso calculando el porcentaje completado
                tpHecho = (int)(hecho / numCargaUCP.Value * 100);

                if (tpHecho > bpProgreso.Value)
                {
                    // Reportamos el valor necesario para actualizar la barra de progreso
                    // mediante el evento ProgressChanged
                    hiloTr.ReportProgress(tpHecho);
                }
            }
        }

        // Evento ProgressChanged que actualiza la interfaz de usuario en el hilo principal
        private void hiloTrabajador_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            // Actualizamos la barra de progreso con el porcentaje de actividad reportado
            bpProgreso.Value = e.ProgressPercentage;
        }

        // Evento RunWorkerCompleted al finalizar o cancelarse la tarea secundaria
        private void hiloTrabajador_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            // Detectamos si el hilo fue cancelado o si terminó correctamente
            if (e.Cancelled)
            {
                Debug.WriteLine("El HiloTrabajador ha sido cancelado.");
            }
            else if (e.Error != null)
            {
                Debug.WriteLine("Error en HiloTrabajador: " + e.Error.Message);
            }
            else
            {
                Debug.WriteLine("El HiloTrabajador terminó correctamente su tarea.");
            }

            // Rehabilitamos los controles al finalizar
            btnIniciar.Enabled = true;
            numCargaUCP.Enabled = true;
        }

        // Evento que se dispara al cerrar el formulario
        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            // En caso de que se cierre la aplicación, cancelamos el hilo secundario
            if (hiloTrabajador.IsBusy)
            {
                hiloTrabajador.CancelAsync();
            }
        }
    }
}
