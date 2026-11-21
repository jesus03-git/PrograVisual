using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio12_Tema7_BBDD
{
    // Clase de Objeto de Negocio (Business Object) que representa un registro de la tabla telefonos
    public class CTelefonoBO : INotifyPropertyChanged
    {
        // Campos privados que mapean las columnas de la tabla telefonos
        private string nombre;
        private string telefono;
        private string direccion;
        private string observaciones;

        // Constructores
        public CTelefonoBO() { }

        public CTelefonoBO(string nombre, string telefono, string direccion, string observaciones)
        {
            this.nombre = nombre;
            this.telefono = telefono;
            this.direccion = direccion;
            this.observaciones = observaciones;
        }

        // Propiedades públicas para cada columna de la base de datos
        public string Nombre
        {
            get { return nombre; }
            set
            {
                if (nombre != value)
                {
                    nombre = value;
                    OnPropertyChanged(new PropertyChangedEventArgs("Nombre"));
                }
            }
        }

        public string Telefono
        {
            get { return telefono; }
            set
            {
                if (telefono != value)
                {
                    telefono = value;
                    OnPropertyChanged(new PropertyChangedEventArgs("Telefono"));
                }
            }
        }

        public string Direccion
        {
            get { return direccion; }
            set
            {
                if (direccion != value)
                {
                    direccion = value;
                    OnPropertyChanged(new PropertyChangedEventArgs("Direccion"));
                }
            }
        }

        public string Observaciones
        {
            get { return observaciones; }
            set
            {
                if (observaciones != value)
                {
                    observaciones = value;
                    OnPropertyChanged(new PropertyChangedEventArgs("Observaciones"));
                }
            }
        }

        // Implementación de la interfaz INotifyPropertyChanged para sincronización en dos direcciones
        public event PropertyChangedEventHandler PropertyChanged;

        protected void OnPropertyChanged(PropertyChangedEventArgs e)
        {
            if (PropertyChanged != null)
            {
                PropertyChanged(this, e);
            }
        }
    }
}
