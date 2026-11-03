using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ejercicio10_Tema5_Imagenes
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        // Evento Click para la orden "Abrir imagen"
        private void abrirImagenToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Mostramos el cuadro de diálogo estándar para seleccionar el fichero de imagen
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                // Para obtener la imagen utilizamos el método FromFile de la clase Image
                // pasándole la ruta del fichero seleccionado por el usuario.
                // Liberamos la imagen previa si existía para no dejar recursos colgados
                if (pictureBox1.Image != null)
                {
                    pictureBox1.Image.Dispose();
                }

                pictureBox1.Image = Image.FromFile(openFileDialog1.FileName);

                // El PictureBox tiene SizeMode = AutoSize y está dentro de un Panel con AutoScroll = true,
                // por lo que si la imagen no cabe en el panel, se activarán las barras de scroll automáticamente.
            }
        }

        // Evento Click para la orden "Girar imagen"
        private void girarImagenToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Comprobamos que haya una imagen cargada antes de girar
            if (pictureBox1.Image != null)
            {
                // Para girar la imagen cambiamos el ancho del PictureBox por su alto (y viceversa)
                int temp = pictureBox1.Width;
                pictureBox1.Width = pictureBox1.Height;
                pictureBox1.Height = temp;

                // Utilizamos el método RotateFlip de la imagen asociada al PictureBox para girar 90 grados
                pictureBox1.Image.RotateFlip(RotateFlipType.Rotate90FlipNone);

                // Forzamos el redibujado del PictureBox para que muestre la imagen rotada
                pictureBox1.Refresh();
            }
        }

        // Evento Click para la orden "escala de grises"
        private void escalaDeGrisesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Comprobamos que haya una imagen cargada
            if (pictureBox1.Image != null)
            {
                // Creamos una copia en Bitmap de la imagen actual
                Bitmap imagenOriginal = new Bitmap(pictureBox1.Image);
                Bitmap imagenGris = new Bitmap(imagenOriginal.Width, imagenOriginal.Height);

                // Obtenemos el contexto gráfico para dibujar sobre la nueva imagen
                using (Graphics g = Graphics.FromImage(imagenGris))
                {
                    // Definimos la matriz ColorMatrix según la documentación para convertir a escala de grises
                    // basada en la luminancia de los colores rojo (0.30), verde (0.59) y azul (0.11)
                    ColorMatrix cm = new ColorMatrix(new float[][] {
                        new float[] { 0.30f, 0.30f, 0.30f, 0, 0 },
                        new float[] { 0.59f, 0.59f, 0.59f, 0, 0 },
                        new float[] { 0.11f, 0.11f, 0.11f, 0, 0 },
                        new float[] { 0,     0,     0,     1, 0 },
                        new float[] { 0,     0,     0,     0, 1 }
                    });

                    // Configuramos los atributos de la imagen con la matriz de color creada
                    using (ImageAttributes atributos = new ImageAttributes())
                    {
                        atributos.SetColorMatrix(cm);

                        // Redibujamos la imagen aplicando la transformación de color a escala de grises
                        g.DrawImage(
                            imagenOriginal,
                            new Rectangle(0, 0, imagenOriginal.Width, imagenOriginal.Height),
                            0, 0,
                            imagenOriginal.Width, imagenOriginal.Height,
                            GraphicsUnit.Pixel,
                            atributos
                        );
                    }
                }

                // Liberamos la imagen anterior y asignamos la imagen transformada en escala de grises
                pictureBox1.Image.Dispose();
                pictureBox1.Image = imagenGris;
                imagenOriginal.Dispose();

                // Forzamos el repintado
                pictureBox1.Refresh();
            }
        }

        // Evento Click para la orden "Salir"
        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Cierra la aplicación
            this.Close();
        }
    }
}
