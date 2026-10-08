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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Guardamos la variable de la fecha + hora actual en una variable
            DateTime Hora = DateTime.Now;

            // Sacamos MessageBox por cada pestaña que queremos añadir con los distintos tipos de fecha que queremos poner.
            // Todas las opciones las da directamente el programa.
            MessageBox.Show(Hora.ToString("dd/MM/yyyy HH:mm:ss"));
            MessageBox.Show(Hora.ToLongDateString());
            MessageBox.Show(Hora.ToLongTimeString());
            MessageBox.Show(Hora.ToShortDateString());

            // Si la propiedad del owner existe y es la del Form1
            if (this.Owner != null && this.Owner is Form1)
            {
                // Realiza un cast del Form1 desde el Form2 invocando su método "Mensaje" pasándole solamente la hora actual.
                (this.Owner as Form1).Mensaje(DateTime.Now.ToShortTimeString());
            }
        }

        // Cuando aparezca el Form2 al haberle dado click a "Mostrar hora actual" en Form1
        private void Form2_Shown(object sender, EventArgs e)
        {
            // Si no nos pasa ningún Owner, entonces pondrá un texto de que la referencia no fue establecida.
            if (this.Owner == null)
            {
                label1.Text = "Referencia al propietario no establecida";
            }
            // En caso de que si nos pase un Owner, cambiaremos el texto por el nombre del Owner.
            else
            {
                label1.Text = this.Owner.ToString();
            }
        }
    }
}
