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
    public partial class Contraseña : Form
    {
        const string CLAVE = "1234";

        public Contraseña()
        {
            InitializeComponent();
        }

        public string sContraseña
        {
            get
            {
                return this.ctContraseña.Text;
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void sContraseña_Click(object sender, EventArgs e)
        {

        }


    }
}
