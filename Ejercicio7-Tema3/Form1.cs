using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ejercicio7_Tema3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        public double numero;

        // Comprueba que los datos son correctos (doubles y no otra cosa)
        private void textBox1_Validating(object sender, CancelEventArgs e)
        {
            // Identificamos cual caja originó el evento.
            TextBox objeto = (TextBox)sender;

            try
            {
                // Intentamos convertir el texto que hemos recogido de la caja a un double y lo guardamos en nuestra variable PUBLICA.
                numero = Convert.ToDouble(objeto.Text);
            }
            catch
            {
                // Si se produce un fallo, se cancela la pérdida de foco y se selecciona el texto erróneo.
                e.Cancel = true;
                objeto.SelectAll();

                // A su vez, muestra un mensaje de error con el componente "ErrorProvider" puesto desde el cuadro de herramientas (zona izquierda).
                errorProvider1.SetError(objeto, "Tiene que ser numerico");
            }
        }

        // Hacemos la conversión y lo mandamos a la otra caja
        private void textBox1_Validated(object sender, EventArgs e)
        {
            // Identificamos de donde viene el texto
            TextBox objeto = (TextBox)sender;

            // Limpiamos posibles errores que se puedan haber quedado de forma residual
            errorProvider1.Clear();

            // Si el texto viene de centigrados
            if (objeto == textBox1)
            {
                // Lo convertimos en fahrenheit
                double Fah = (numero * 1.8) + 32;

                // Y lo ponemos en la caja de Fahrenheit con un máximo de 2 decimales ("F2").
                textBox2.Text = Fah.ToString("F2");
            }
            // Si el texto viene de fahrenheit
            else
            {
                // Lo convertimos a centígrados.
                double Cent = (numero - 32) / 1.8;

                // Y lo ponemos en la caja de centígrados con un máximo de 2 decimales ("F2").
                textBox1.Text = Cent.ToString("F2");
            }
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Comprobamos si se ha presionado la tecla "Enter"
            if (e.KeyChar == (char)Keys.Enter)
            {
                // Identificamos cual caja originó el evento (desde donde se presiono enter).
                TextBox objeto = (TextBox)sender;

                // Si lo originó la primera, es la de centígrados, por lo que marcamos la de fahrenheit.
                if (objeto == textBox1)
                {
                    textBox2.Focus();
                }
                // Si lo origninó la segunda, es la de fahrenheit, por lo que marcamos la de centígrados.
                else
                {
                    textBox1.Focus();
                }
            }
        }
    }
}
