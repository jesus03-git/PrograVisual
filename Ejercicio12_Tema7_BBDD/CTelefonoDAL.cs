using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio12_Tema7_BBDD
{
    // Clase de Acceso a Datos (Data Access Layer) que gestiona la comunicación con la base de datos SQL Server
    public class CTelefonoDAL
    {
        // Cadena de conexión hacia la instancia LocalDB con la base de datos bd_telefonos
        private string strConexion = @"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=bd_telefonos;Integrated Security=True";

        public CTelefonoDAL()
        {
            // Verificamos y aseguramos que la base de datos y la tabla existan al instanciar el DAL
            AsegurarBaseDeDatos();
        }

        // Método auxiliar para garantizar que la base de datos y los datos iniciales existan en cualquier equipo
        private void AsegurarBaseDeDatos()
        {
            try
            {
                // Comprobamos si la base de datos bd_telefonos existe en el servidor LocalDB
                using (SqlConnection conMaster = new SqlConnection(@"Data Source=(localdb)\MSSQLLocalDB;Integrated Security=True"))
                {
                    conMaster.Open();
                    string sqlCrearBD = @"
                        IF NOT EXISTS (SELECT name FROM sys.databases WHERE name = 'bd_telefonos')
                        BEGIN
                            CREATE DATABASE bd_telefonos;
                        END";
                    using (SqlCommand cmd = new SqlCommand(sqlCrearBD, conMaster))
                    {
                        cmd.ExecuteNonQuery();
                    }
                }

                // Aseguramos la tabla telefonos, el procedimiento almacenado y los registros iniciales
                using (SqlConnection conBD = new SqlConnection(strConexion))
                {
                    conBD.Open();
                    string sqlCrearTabla = @"
                        IF NOT EXISTS (SELECT * FROM sys.tables WHERE name = 'telefonos')
                        BEGIN
                            CREATE TABLE telefonos (
                                Nombre NVARCHAR(100) NOT NULL,
                                Telefono NVARCHAR(20) NOT NULL PRIMARY KEY,
                                Direccion NVARCHAR(200) NULL,
                                Observaciones NVARCHAR(MAX) NULL
                            );

                            INSERT INTO telefonos (Nombre, Telefono, Direccion, Observaciones) VALUES
                            ('Leticia Aguirre Soriano', '111222333', 'Triana, Sevilla', 'Ninguna'),
                            ('Pedro Luis Perez', '222333444', 'Gran Vía, Madrid', 'Amigo de la universidad'),
                            ('Pedro Aguado Rodriguez', '333444555', 'Calle Mayor, Alcalá de Henares', 'Compañero de trabajo');
                        END";
                    using (SqlCommand cmd = new SqlCommand(sqlCrearTabla, conBD))
                    {
                        cmd.ExecuteNonQuery();
                    }

                    // Procedimiento almacenado para actualizar datos
                    string sqlCrearProc = @"
                        IF NOT EXISTS (SELECT * FROM sys.procedures WHERE name = 'stproActualizarTelefono')
                        BEGIN
                            EXEC('
                            CREATE PROCEDURE stproActualizarTelefono
                                @Telefono NVARCHAR(20),
                                @Direccion NVARCHAR(200),
                                @Observaciones NVARCHAR(MAX),
                                @Nombre NVARCHAR(100) = NULL
                            AS
                            BEGIN
                                SET NOCOUNT ON;
                                UPDATE telefonos
                                SET Direccion = @Direccion,
                                    Observaciones = @Observaciones
                                WHERE Telefono = @Telefono;
                            END')
                        END";
                    using (SqlCommand cmd = new SqlCommand(sqlCrearProc, conBD))
                    {
                        cmd.ExecuteNonQuery();
                    }
                }
            }
            catch
            {
                // Si la instancia ya existe o no se requiere crear, continuamos normalmente
            }
        }

        // Método 1: Obtener todas las filas de la tabla utilizando una orden SELECT en un string
        public ColeccionTfnos ObtenerTodos()
        {
            try
            {
                // Usamos using para garantizar que la conexión se cierre y libere correctamente
                using (SqlConnection conexion = new SqlConnection(strConexion))
                {
                    // Orden SQL SELECT mediante un string
                    string consulta = "SELECT Nombre, Telefono, Direccion, Observaciones FROM telefonos";
                    using (SqlCommand ordenSql = new SqlCommand(consulta, conexion))
                    {
                        ColeccionTfnos coleccion = new ColeccionTfnos();

                        conexion.Open();
                        using (SqlDataReader lector = ordenSql.ExecuteReader())
                        {
                            while (lector.Read())
                            {
                                CTelefonoBO fila = new CTelefonoBO(
                                    lector["Nombre"] != DBNull.Value ? (string)lector["Nombre"] : string.Empty,
                                    lector["Telefono"] != DBNull.Value ? (string)lector["Telefono"] : string.Empty,
                                    lector["Direccion"] != DBNull.Value ? (string)lector["Direccion"] : string.Empty,
                                    lector["Observaciones"] != DBNull.Value ? (string)lector["Observaciones"] : string.Empty
                                );
                                coleccion.Add(fila);
                            }
                        }

                        return coleccion;
                    }
                }
            }
            catch (SqlException err)
            {
                throw new ApplicationException("Error al consultar la tabla telefonos: " + err.Message);
            }
        }

        // Método 2: Actualizar los datos utilizando un procedimiento almacenado parametrizado
        public void ActualizarTelefono(CTelefonoBO bo)
        {
            if (bo == null) return;

            try
            {
                using (SqlConnection conexion = new SqlConnection(strConexion))
                {
                    // Procedimiento almacenado parametrizado
                    using (SqlCommand ordenSql = new SqlCommand("stproActualizarTelefono", conexion))
                    {
                        ordenSql.CommandType = CommandType.StoredProcedure;

                        // Parámetros de la orden parametrizada
                        ordenSql.Parameters.AddWithValue("@Telefono", bo.Telefono);
                        ordenSql.Parameters.AddWithValue("@Direccion", (object)bo.Direccion ?? DBNull.Value);
                        ordenSql.Parameters.AddWithValue("@Observaciones", (object)bo.Observaciones ?? DBNull.Value);
                        ordenSql.Parameters.AddWithValue("@Nombre", (object)bo.Nombre ?? DBNull.Value);

                        conexion.Open();
                        ordenSql.ExecuteNonQuery(); // Ejecuta la orden UPDATE en la base de datos
                    }
                }
            }
            catch (SqlException err)
            {
                throw new ApplicationException("Error al actualizar el teléfono " + bo.Telefono + ": " + err.Message);
            }
        }
    }
}
