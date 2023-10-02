using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AccesoDatos.Ferreteria
{
    public class Conexion
    {
        private MySqlConnection _connection;
        public Conexion(string Server, string UserID, string Password, string Database, uint Port)
        {
            MySqlConnectionStringBuilder CadenaConexion = new MySqlConnectionStringBuilder();
            CadenaConexion.Server = Server;
            CadenaConexion.UserID = UserID;
            CadenaConexion.Password = Password;
            CadenaConexion.Database = Database;
            CadenaConexion.Port = Port;
            _connection = new MySqlConnection(CadenaConexion.ToString());
        }
        public void EjecutarConsulta(string Consulta)
        {
            try
            {
                _connection.Open();
                using (MySqlCommand command = new MySqlCommand(Consulta, _connection))
                {
                    command.ExecuteNonQuery();
                    Console.WriteLine("Consulta Ejecutada Correctamente");
                }
                _connection.Close();
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error al Ejecutar La Consulta", ex.Message);
            }
        }
        //DataSet guarda varias tablas y Datatable guarda una tabla
        public DataTable ObtenerDatos(string Consulta)
        {
            DataTable table = new DataTable();
            try
            {
                _connection.Open();
                using (MySqlCommand command = new MySqlCommand(Consulta, _connection))
                {
                    using (MySqlDataAdapter adapter = new MySqlDataAdapter(command))
                    {
                        adapter.Fill(table);
                        Console.WriteLine("Consulta Ejecutada Correctamente");
                    }
                }
                _connection.Close();
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error al Ejecutar La Consulta", ex.Message);
            }
            return table;
        }
        public DataSet Permisos(string q, string t)
        {
            DataSet ds = new DataSet();
            try
            {
                MySqlDataAdapter da = new MySqlDataAdapter(q, _connection);
                _connection.Open();
                da.Fill(ds, t);
                _connection.Close();
                return ds;
            }
            catch (Exception)
            {
                _connection.Close();
                return ds;
            }
        }
    }
}