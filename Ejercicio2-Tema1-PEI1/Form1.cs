using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ejercicio2_Tema1_PEI1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Contraseña dlg = new Contraseña();

            int contador = 0;

            do
            {
                if (dlg.ShowDialog() == DialogResult.OK)
                {
                    if (dlg.sContraseña == "1234")
                    {
                        MessageBox.Show("La palabra de paso es correcta", "Correcto", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        contador = 10;
                        this.Close();
                    }
                    else
                    {
                        MessageBox.Show("La palabra de paso no es correcta", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    this.Close();
                }

                contador++;
            } while (contador < 3);

            if (contador == 3)
            {
                this.Close();
            }

        }
    }
}
