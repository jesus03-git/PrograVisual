using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace P5_VisorImagenes
{
    public partial class VisorImagenes : Form
    {
        public VisorImagenes()
        {
            InitializeComponent();

            // Estado inicial sin ventanas
            ActualizarMenus();
        }

        public VentanaHija HijaActiva
        {
            get
            {
                return (VentanaHija)this.ActiveMdiChild;
            }
        }

        private void cascadaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Organiza las ventanas hijas en cascada
            this.LayoutMdi(MdiLayout.Cascade);
        }

        private void mosaicoHorizontalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Organiza las ventanas hijas en horizontal
            this.LayoutMdi(MdiLayout.TileHorizontal);
        }

        private void mosaicoVerticalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Organiza las ventanas hijas en vertical
            this.LayoutMdi(MdiLayout.TileVertical);
        }

        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Cierra el programa.
            this.Close();
        }

        private void nuevoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Guardamos en una variable cuantas ventanas existen en ese momento
            int numeroHijas = this.MdiChildren.Length;

            // Añadimos la variable "titulo" para ir agregando los títulos a las ventanas hijas que creemos
            string titulo = "Documento" + (numeroHijas + 1);

            // Llammamos al metodo NuevaHija, que se encarga de construir la ventana hija.
            NuevaHija(titulo);
        }

        private void NuevaHija(string titulo)
        {
            // Instanciamos la clase creada con el título que le hemos pasado
            VentanaHija hija = new VentanaHija(titulo);

            // Indicamos que el formulario padre es el actual
            hija.MdiParent = this;

            //  Ajustamos el PictureBox para que tome el tamaño de la imagen
            hija.PictureBox.SizeMode = PictureBoxSizeMode.AutoSize;

            // Activamos la barra de desplazamiento por si la imagen es más grande que el contenedor.
            hija.AutoScroll = true;

            // Asignamos la imagen desde los recursos del proyecto
            hija.PictureBox.Image = Properties.Resources.Imagen1;

            // Hacemos visible la ventana hija.
            hija.Show();
        }

        private void cerrarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Comprobamos si hay alguna ventana abierta
            if (this.HijaActiva != null)
            {
                // Cerramos la ventana activa
                this.HijaActiva.Close();
            }
        }

        private void abrirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Configuramos el cuadro de dialogo para seleccionar archivos
            using (OpenFileDialog dlg = new OpenFileDialog())
            {
                dlg.Title = "Abrir imagen";
                dlg.Filter = "Imágenes (*.bmp;*.jpg;*.gif)|*.bmp;*.jpg;*.gif|Todos los archivos (*.*)|*.*";

                if (dlg.ShowDialog() == DialogResult.OK)
                {
                    AbrirArchivo(dlg.FileName);
                }
                else
                {
                    return;
                }
            }
        }

        private void ActualizarMenus()
        {
            // Comprobamos si hay alguna ventana hija abierta
            bool hayHija = (this.HijaActiva != null);

            // Polarizamos las opciones según estén en ese momento
            this.cerrarToolStripMenuItem.Enabled = hayHija;
            this.cascadaToolStripMenuItem.Enabled = hayHija;
            this.mosaicoHorizontalToolStripMenuItem.Enabled = hayHija;
            this.mosaicoVerticalToolStripMenuItem.Enabled = hayHija;
        }

        private void VisorImagenes_MdiChildActivate(object sender, EventArgs e)
        {
            // Deshacemos la fusión anterior de la barra de herramientas
            ToolStripManager.RevertMerge(this.toolStrip1);

            // Si hay una ventana activa, fusionamos su barra con la principal
            if (this.HijaActiva != null)
            {
                ToolStripManager.Merge(this.HijaActiva.toolStrip1, this.toolStrip1);
            }

            // Actualizamos el estado de los menús.
            ActualizarMenus();
        }

        // Creamos un método para no duplicar codigo de abrir archivos.
        private void AbrirArchivo(string rutaArchivo)
        {
            // Leemos los bytes del archivo a un flujo en memoria para no bloquear el archivo en disco
            byte[] contenidoArchivo = File.ReadAllBytes(rutaArchivo);
            using (MemoryStream ms = new MemoryStream(contenidoArchivo))
            {
                Image imagen = Image.FromStream(ms);

                // Creamos una nueva ventana hija usando la ruta del fichero
                NuevaHija(rutaArchivo);

                // Asignamos la imagen abierta al PictureBox de la ventana nueva
                this.HijaActiva.PictureBox.Image = imagen;
            }
        }

        private void VisorImagenes_DragEnter(object sender, DragEventArgs e)
        {
            // Verificamos si lo que se arrastra es una lista de archivos
            if (!e.Data.GetDataPresent(DataFormats.FileDrop))
            {
                e.Effect = DragDropEffects.None;
                return;
            }

            // Obtenemos las rutas de los archivos
            string[] files = (string[])e.Data.GetData(DataFormats.FileDrop);

            // Comprobamos que todos los archivos arrastrados sean imágenes validas.
            foreach (string file in files)
            {
                string extension = Path.GetExtension(file).ToUpper();
                if (extension != ".JPG" && extension != ".BMP" && extension != ".GIF")
                {
                    e.Effect = DragDropEffects.None; // Alguno de los archivos no es válido
                    return;
                }
            }

            // Si todos son válidos, permitimos la acción de copiar
            e.Effect = DragDropEffects.Copy;
        }

        private void VisorImagenes_DragDrop(object sender, DragEventArgs e)
        {
            string[] files = (string[])e.Data.GetData(DataFormats.FileDrop);
            foreach (string file in files)
            {
                AbrirArchivo(file);
            }
        }

        // Cuando el ratón pasa por encima de un botón o comando
        private void Elemento_MouseEnter(object sender, EventArgs e)
        {
            if (sender == this.nuevoToolStripMenuItem || sender == this.toolStripButton1)
            {
                this.toolStripStatusLabel1.Text = "Crea una nueva ventana con una imagen predefinida";
            }
            else if (sender == this.abrirToolStripMenuItem || sender == this.toolStripButton2)
            {
                this.toolStripStatusLabel1.Text = "Abre una imagen existente desde el disco";
            }
            else if (sender == this.cerrarToolStripMenuItem)
            {
                this.toolStripStatusLabel1.Text = "Cierra la ventana activa";
            }
            else if (sender == this.salirToolStripMenuItem)
            {
                this.toolStripStatusLabel1.Text = "Cierra la aplicación por completo";
            }

            this.statusStrip1.Refresh();
        }

        // Cuando el ratón sale del botón, limpiamos la barra de estado
        private void Elemento_MouseLeave(object sender, EventArgs e)
        {
            this.toolStripStatusLabel1.Text = "Listo";
            this.statusStrip1.Refresh();
        }

        private void barraDeHerramientasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Alternar entre visible y oculto
            this.toolStrip1.Visible = !this.toolStrip1.Visible;
        }

        private void barraDeEstadoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Alterna entre visible y oculto
            this.statusStrip1.Visible = !this.statusStrip1.Visible;
        }

        private void verToolStripMenuItem_DropDownOpened(object sender, EventArgs e)
        {
            // Sincroniza la marca de check con la visibilidad
            this.barraDeHerramientasToolStripMenuItem.Checked = this.toolStrip1.Visible;
            this.barraDeEstadoToolStripMenuItem.Checked = this.statusStrip1.Visible;
        }
    }
}