using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using System.Data.SqlTypes;
using static System.ComponentModel.Design.ObjectSelectorEditor;
using System.Windows.Forms;

namespace PruebaTecnicaNetForemost
{
    internal class ConexionDB
    {
        private SqlConnection conex;
        private string connectionString;

        // Constructor
        public ConexionDB()
        {
            // Inicializar la cadena de conexión
            connectionString = "Server=(LocalDB)\\MSSQLLocalDB;Database=PruebaNetForemostDB;integrated security=true";

            // Inicializar el objeto SqlConnection
            conex = new SqlConnection(connectionString);
        }

        // Método para abrir la conexión y ejecutar una consulta
        public void ConectarYConsultar(DataGridView dgv)
        {
            try
            {
                // Abrir la conexión
                conex.Open();
                MessageBox.Show("Conexión exitosa!");

                // Crear una consulta SQL
                //string query = "SELECT * FROM tu_tabla";
                string query = @"SELECT Cliente.nombre AS ClienteNombre, 
                        Cuenta.saldo AS CuentaSaldo, 
                        GestorCobros.nombre AS GestorNombre
                 FROM Cliente
                 JOIN Cuenta ON Cliente.idCuenta = Cuenta.idCuenta
                 LEFT JOIN GestorCobros ON Cuenta.idGestor = GestorCobros.idGestor
                 ORDER BY Cuenta.saldo DESC";  // Ordenando por el nombre del cliente en orden descendente




                // Ejecutar la consulta
                SqlDataAdapter adapter = new SqlDataAdapter(query, conex);
                DataTable dataTable = new DataTable();
                // Llenar el DataTable con los resultados de la consulta
                adapter.Fill(dataTable);
                // Asignar el DataTable como fuente de datos del DataGridView
                dgv.DataSource = dataTable;
                //using (SqlCommand command = new SqlCommand(query, conex))
                //{
                //    using (SqlDataReader reader = command.ExecuteReader())
                //    {
                //        // Leer los datos y mostrarlos en la consola
                //        while (reader.Read())
                //        {
                //            Console.WriteLine(reader[0].ToString());
                //        }
                //    }
                //}
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
            finally
            {
                // Cerrar la conexión
                if (conex != null && conex.State == System.Data.ConnectionState.Open)
                {
                    conex.Close();
                }
            }
        }
        public void EjecutarProcedimientoAlmacenado(DataGridView dgv)
        {
            // Cadena de conexión
            string connectionString = "Server=(LocalDB)\\MSSQLLocalDB;Database=PruebaNetForemostDB;Integrated Security=true;";

            // Crear una conexión a la base de datos
            using (SqlConnection conex = new SqlConnection(connectionString))
            {
                try
                {
                    // Abrir la conexión
                    conex.Open();

                    // Crear un SqlCommand para ejecutar el procedimiento almacenado
                    SqlCommand command = new SqlCommand("AsignarSaldosAGestores", conex);
                    command.CommandType = CommandType.StoredProcedure;

                    // Usar un SqlDataAdapter para llenar un DataTable con los resultados
                    SqlDataAdapter adapter = new SqlDataAdapter(command);
                    DataTable dataTable = new DataTable();

                    // Llenar el DataTable con los datos del procedimiento almacenado
                    adapter.Fill(dataTable);

                    // Asignar el DataTable como el origen de datos del DataGridView
                    dgv.DataSource = dataTable;
                }
                catch (Exception ex)
                {
                    // Manejar cualquier excepción
                    MessageBox.Show("Error: " + ex.Message);
                }
            }
        }

    }
}
