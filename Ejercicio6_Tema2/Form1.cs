using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ejercicio6_Tema2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        // Le ponemos el metodo para cuando se hace click en el botón.
        private void button1_Click(object sender, EventArgs e)
        {
            // Se configuran las opciones iniciales de dialogo.
            fontDialog1.Font = textBox1.Font;
            colorDialog1.Color = textBox1.ForeColor;

            // Muestra el cuadro de editar la fuente del dialogo
            if (fontDialog1.ShowDialog() == DialogResult.OK)
            {
                // Y lo aplica al texto
                textBox1.Font = fontDialog1.Font;
            }

            // Muestra el cuadro de editar el color de la fuente del dialogo.
            if (colorDialog1.ShowDialog() == DialogResult.OK)
            {
                // Y lo aplica al texto.
                textBox1.ForeColor = colorDialog1.Color;
            }
        }

        // Haciendo doble click en el boton color del menuItem, nos sale este método
        private void colorToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            // En el que le ponemos que si se hace click o se hace su ShortCut, que se abra el cuadro de cambio de color de fuente.
            if (colorDialog1.ShowDialog() == DialogResult.OK)
            {
                // Y lo aplica al texto.
                textBox1.ForeColor = colorDialog1.Color;
            }
        }

        // Haciendo doble click en el boton color del menuItem, nos sale este método.
        private void fuenteToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            // En el que le ponemos que si se hace click, que se abra el cuadro de cambio de fuente.
            if (fontDialog1.ShowDialog() == DialogResult.OK)
            {
                // Y lo aplica al texto
                textBox1.Font = fontDialog1.Font;
            }
        }

        // Si le damos al botón de copiar, CON EL TEXTO DE LA PRIMERA TEXTBOX SELECCIONADO
        private void copiarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Primero lo copiamos de la primera textBox
            textBox1.Copy();
            // Y luego lo pegamos en la segunda textBox
            textBox2.Paste();
        }

        // Si cuando hacemos click en "Dialogo" no hay texto seleccionado, no permite darle al botón de copiar.
        // Si cuando hacemos click en "Dialogo" si hay texto seleccionado, si permite darle al botón de copiar.
        private void dialogoToolStripMenuItem_DropDownOpening(object sender, EventArgs e)
        {
            copiarToolStripMenuItem.Enabled = textBox1.SelectionLength != 0;
        }

        // Si le damos click al boton de cursor, nos aparece el nuevo form (Form2)
        private void cursorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form2 ventanaCursor = new Form2();
            ventanaCursor.Show();
        }
    }
}
