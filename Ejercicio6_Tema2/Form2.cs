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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        // Cuando le damos click al botón del formulario
        private void button1_Click(object sender, EventArgs e)
        {
            // Nos cambia el cursor al de "cargando" o "esperando"
            Cursor.Current = Cursors.WaitCursor;

            // Hacemos que el sistema mantenga el cursor por 2 segundos.
            System.Threading.Thread.Sleep(2000);

            // Al pasar los 2 segundos, vuelve al cursor default
            Cursor.Current = Cursors.Default;
        }

        // El resto de cambios se han realizado en la pestaña de "propiedades" que hay en el Visual Studio.
        // Los cambios que se han realizado han sido que, cuando estamos en la parte del formulario, el cursor sea una cruz,
        // y que cuando el cursor esté encima del botón, sea el cursor default (la flechita).
    }
}
