using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ejercicio3_Tema1_Parte1
{
    public partial class Form1 : Form
    {

        private Form2 dlg;

        private List<string> mensaje = new List<string>();
        public Form1()
        {
            InitializeComponent();
        }

        // Mensaje que se pondrá al terminar de enseñar todas las MessageBox del Form2
        public void Mensaje(string textoHora)
        {
            // Le añadimos al mensaje la hora recibida por el Form2
            this.mensaje.Add(textoHora);

            // Y creamos el MessageBox que saldrá justo después de enseñar todas las horas en el Form2.
            MessageBox.Show($"Mensaje recibido de Form2 y guardado en lista {textoHora}");
        }

        // Creamos la referencia de cuando le demos click al botón de "Mostrar hora actual".
        private void button1_Click(object sender, EventArgs e)
        {
            // Comprueba si el dialogo no ha sido creado previamente o si ya fue destruido con IsDisposed.
            if (dlg == null || dlg.IsDisposed)
            {
                dlg = new Form2();
            }

            // Comprueba si la ventana secundaria no se encuentra visible en pantalla
            if (!dlg.Visible)
            {
                // Entonces muestra Form2 como una caja de dialogo pasándole la referencia del formulario (Form 1) como "Owner".
                dlg.Show(this);
            }
        }

        // Si hacemos click en el boton de salir, se cierra el programa.
        private void button2_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
