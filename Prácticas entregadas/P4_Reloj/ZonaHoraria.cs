using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;

namespace P1_Reloj
{
    [Serializable]
    public class ZonaHoraria
    {
        private TimeSpan m_Diferencia = new TimeSpan();
        private bool m_Positivo = true;
        private string m_Nombre = "";

        public TimeSpan Diferencia
        {
            get
            {
                return m_Diferencia;
            }
            set
            {
                m_Diferencia = value;
            }
        }

        public bool Positivo
        {
            get
            {
                return m_Positivo;
            }
            set
            {
                m_Positivo = value;
            }
        }

        public string Nombre
        {
            get
            {
                return m_Nombre;
            }
            set
            {
                m_Nombre = value;
            }
        }
    }
}
