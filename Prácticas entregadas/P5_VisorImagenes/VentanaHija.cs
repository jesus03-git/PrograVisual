using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing.Imaging;
using System.Drawing.Drawing2D;
using System.IO;

namespace P5_VisorImagenes
{
    public partial class VentanaHija : Form
    {
        // Propiedad de solo lectura para acceder a PictureBox
        public PictureBox PictureBox
        {
            get
            {
                return m_PictureBox;
            }
        }

        // Propiedad de solo lectura para acceder al toolStripHija
        public ToolStrip toolStrip1
        {
            get
            {
                return this.toolStrip1Hija;
            }
        }

        // Modificamos el constructor para que reciba el nombre de la ventana
        public VentanaHija(string titulo)
        {
            InitializeComponent();

            // Le ponemos el nombre recibido al titulo de la ventana
            this.Text = titulo;
        }

        private void ImagenAjustar_Click(object sender, EventArgs e)
        {
            // Si la imagen está en tamaño real, cambiamos a modo ajustado
            if (this.PictureBox.SizeMode == PictureBoxSizeMode.AutoSize)
            {
                this.AutoScroll = false;
                this.PictureBox.Size = this.ClientSize;
                this.PictureBox.SizeMode = PictureBoxSizeMode.Zoom;
            }
            // Si ya está en modo ajustado, lo cambiamos a tamaño real.
            else if (this.PictureBox.SizeMode == PictureBoxSizeMode.Zoom)
            {
                this.AutoScroll = true;
                this.PictureBox.SizeMode = PictureBoxSizeMode.AutoSize;
            }

            // Marcamos el check si estamos en modo ajustado. También en el toolStrip
            this.ImagenAjustar.Checked = (this.PictureBox.SizeMode == PictureBoxSizeMode.Zoom);
            this.toolStripButton2.Checked = (this.PictureBox.SizeMode == PictureBoxSizeMode.Zoom);
        }

        private void VentanaHija_Resize(object sender, EventArgs e)
        {
            // Si está ajustada, redimensionamos el PictureBox al nuevo tamaño de ventana.
            if (this.PictureBox.SizeMode == PictureBoxSizeMode.Zoom)
            {
                this.PictureBox.Size = this.ClientSize;
            }
        }

        private void rotarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (this.PictureBox.Image != null)
            {
                // Aplicamos un giro de 90 grados
                this.PictureBox.Image.RotateFlip(RotateFlipType.Rotate90FlipNone);

                // Si estamos en tamaño real, reasignar la imagen o forzar redibujado, para que PictureBox calcule el intercambio de ancho por alto.
                if (this.PictureBox.SizeMode == PictureBoxSizeMode.AutoSize)
                {
                    this.PictureBox.Image = this.PictureBox.Image;
                }

                // Forzamos el repintado para que muestre la nueva imagen.
                this.PictureBox.Refresh();
            }
        }

        private void añadirTextoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Comprobamoos que la imagen no esté vacia
            if (this.PictureBox.Image != null)
            {
                // Obtenemos el contexto gráfico de la imagen
                using (Graphics gfx = Graphics.FromImage(this.PictureBox.Image))
                {
                    // Definimos la fuente y el estilo de letra
                    using (Font fuente = new Font("Arial", 20, FontStyle.Bold))
                    {
                        // Dibujamos el texto en la coordenada (0,0)
                        gfx.DrawString("Programación Visual", fuente, Brushes.Yellow, new PointF(0, 0));
                    }
                }

                // Forzamos el repintado.
                this.PictureBox.Refresh();
            }
        }

        private void ImagenEscalaDeGrises_Click(object sender, EventArgs e)
        {
            if (this.PictureBox.Image == null)
            {
                return;
            }

            Image imagen = this.PictureBox.Image;

            // Obtenemos el contexto gráfico de la imagen
            using (Graphics gfx = Graphics.FromImage(imagen))
            {
                // Definimos la matriz para transformar al gris según la luminancia
                ColorMatrix cm = new ColorMatrix(new float[][] {
                    new float[] {0.3f,  0.3f,  0.3f,  0, 0},
                    new float[] {0.59f, 0.59f, 0.59f, 0, 0},
                    new float[] {0.11f, 0.11f, 0.11f, 0, 0},
                    new float[] {0,     0,     0,     1, 0},
                    new float[] {0,     0,     0,     0, 1}
                });

                // Asignamos la matriz de color a los atributos de la imagen
                ImageAttributes atrImg = new ImageAttributes();
                atrImg.SetColorMatrix(cm);

                // Redibujamos la imagen sobre sí misma aplicando la matriz
                gfx.DrawImage(
                    imagen,
                    new Rectangle(0, 0, imagen.Width, imagen.Height), // Rectángulo de destino
                    0, 0,                                             // Coordenada origen X, Y
                    imagen.Width, imagen.Height,                      // Ancho y alto de la fuente
                    GraphicsUnit.Pixel,                               // Unidades de medida
                    atrImg                                            // Atributos de transformación
                );
            }

            // Forzamos el repintado.
            this.PictureBox.Refresh();
        }

        // Creamos un método auxiliar para no duplicar código entre las dos opciones de guardado
        public void GuardarComo()
        {
            using (SaveFileDialog dlg = new SaveFileDialog())
            {
                dlg.Title = "Guardar imagen como...";
                dlg.Filter = "Imagen JPEG (*.jpg)|*.jpg|Mapa de bits (*.bmp)|*.bmp|Imagen GIF (*.gif)|*.gif";

                if (dlg.ShowDialog() == DialogResult.OK)
                {
                    // Guardamos el archivo y actualizamos el titulo de la ventana.
                    GuardarEnRuta(dlg.FileName);
                    this.Text = dlg.FileName;
                }
            }
        }

        // Método para realizar la persistencia en disco según el formato
        private void GuardarEnRuta(string ruta)
        {
            string extension = Path.GetExtension(ruta).ToUpper();
            ImageFormat formato = ImageFormat.Jpeg;

            if (extension == ".BMP")
            {
                formato = ImageFormat.Bmp;
            }
            else if (extension == ".GIF")
            {
                formato = ImageFormat.Gif;
            }

            this.PictureBox.Image.Save(ruta, formato);
        }

        private void guardarComoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            GuardarComo();
        }

        private void guardarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Si la imagen proviene de un recurso y no tiene ruta en disco
            if (this.Text.StartsWith("Doc"))
            {
                GuardarComo();
            }
            // Si ya tiene una ruta existente
            else
            {
                // Guardamos directamente y sobreescribimos los datos sobre él mismo.
                GuardarEnRuta(this.Text);
            }
        }
    }
}
