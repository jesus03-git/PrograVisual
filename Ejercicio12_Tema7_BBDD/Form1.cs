using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ejercicio12_Tema7_BBDD
{
    public partial class Form1 : Form
    {
        // Instancia de la capa de acceso a datos y de la colección enlazable
        private CTelefonoDAL dal = new CTelefonoDAL();
        private ColeccionTfnos coleccionTfnos = new ColeccionTfnos();

        public Form1()
        {
            InitializeComponent();
        }

        // Evento Load del formulario: cargamos los datos de la base de datos y establecemos los enlaces
        private void Form1_Load(object sender, EventArgs e)
        {
            try
            {
                // Paso 7: Crear el objeto ColeccionTfnos realizando una consulta a la BD
                // utilizando la interfaz de CTelefonoDAL
                coleccionTfnos = dal.ObtenerTodos();

                // Paso 5 y 7: Asignamos la colección a la propiedad DataSource del objeto BindingSource
                bindingSourceTelefonos.DataSource = coleccionTfnos;

                // Paso 6: Vincular los controles con el origen de datos
                // Para la lista (Nombre): asignamos DataSource al BindingSource y DisplayMember a "Nombre"
                listBoxTelefonos.DataSource = bindingSourceTelefonos;
                listBoxTelefonos.DisplayMember = "Nombre";

                // Vinculamos las tres cajas de texto a las propiedades del objeto seleccionado
                // Caja de texto de teléfono (sólo lectura)
                txtTelefono.DataBindings.Add("Text", bindingSourceTelefonos, "Telefono", true, DataSourceUpdateMode.OnPropertyChanged);

                // Caja de texto de dirección
                txtDireccion.DataBindings.Add("Text", bindingSourceTelefonos, "Direccion", true, DataSourceUpdateMode.OnPropertyChanged);

                // Caja de texto de observaciones (multilínea)
                txtObservaciones.DataBindings.Add("Text", bindingSourceTelefonos, "Observaciones", true, DataSourceUpdateMode.OnPropertyChanged);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar los datos: " + ex.Message, "Error de conexión", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // Paso 8: Añadir el controlador del botón "Actualizar datos"
        private void btnActualizarDatos_Click(object sender, EventArgs e)
        {
            try
            {
                // Finalizamos cualquier edición pendiente en los controles enlazados
                bindingSourceTelefonos.EndEdit();

                // Obtenemos el objeto CTelefonoBO actualmente seleccionado en el BindingSource
                CTelefonoBO contactoSeleccionado = (CTelefonoBO)bindingSourceTelefonos.Current;

                if (contactoSeleccionado != null)
                {
                    // Llamamos a CTelefonoDAL para actualizar los datos en la base de datos
                    // mediante el procedimiento almacenado parametrizado
                    dal.ActualizarTelefono(contactoSeleccionado);

                    MessageBox.Show("Datos actualizados correctamente en la base de datos.", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al actualizar los datos: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
