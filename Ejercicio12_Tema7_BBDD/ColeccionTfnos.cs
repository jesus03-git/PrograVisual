using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio12_Tema7_BBDD
{
    // Clase colección derivada de BindingList<CTelefonoBO> para permitir el enlace bidireccional de datos
    public class ColeccionTfnos : BindingList<CTelefonoBO>
    {
    }
}
