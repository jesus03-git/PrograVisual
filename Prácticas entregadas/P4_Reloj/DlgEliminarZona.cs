using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace P1_Reloj
{
    public partial class DlgEliminarZona : Form
    {

        private List<ZonaHoraria> m_Zonas;

        private int m_ZonaSeleccionada = -1;

        public int ZonaSeleccionada
        {
            get
            {
                return m_ZonaSeleccionada;
            }
        }

        public DlgEliminarZona()
        {
            InitializeComponent();

            this.MinimumSize = this.Size;
        }

        private void DlgEliminarZona_Load(object sender, EventArgs e)
        {
            RelojDigital ventanaPrincipal = (RelojDigital)this.Owner;
            m_Zonas = ventanaPrincipal.zonas;

            foreach (ZonaHoraria zona in m_Zonas)
            {
                lb_Zonas.Items.Add(zona.Nombre);
            }

            if (lb_Zonas.Items.Count > 0)
            {
                lb_Zonas.SelectedIndex = 0;
            }
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void lb_Zonas_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Si no hay nada seleccionado, salimos para evitar errores
            if (lb_Zonas.SelectedItem == null)
            {
                return;
            }

            string nombreZona = lb_Zonas.SelectedItem.ToString();

            ZonaHoraria zonaSeleccionada = m_Zonas.Find(
                delegate (ZonaHoraria zona)
                {
                    return zona.Nombre == nombreZona;
                }
            );

            if (zonaSeleccionada != null)
            {
                ct_Diferencia.Text = zonaSeleccionada.Diferencia.ToString();

                if (zonaSeleccionada.Positivo)
                {
                    ct_Signo.Text = "+";
                }
                else
                {
                    ct_Signo.Text = "-";
                }
            }
        }

        private void bt_Aceptar_Click(object sender, EventArgs e)
        {
            m_ZonaSeleccionada = lb_Zonas.SelectedIndex;
            this.DialogResult = DialogResult.OK;
        }
    }
}
