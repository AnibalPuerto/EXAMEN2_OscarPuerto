using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entidades;

namespace BaseDatos
{
    public class SoporteDatos
    {
        public async Task<DataTable> MostrarTablaSoporteAsync()
        {
            DataTable dt = new DataTable();
            try
            {
                string sql = "SELECT * FROM soporte;";

                using (MySqlConnection _conexion = new MySqlConnection(CadenaConexion.Cadena))
                {
                    await _conexion.OpenAsync();
                    using (MySqlCommand comando = new MySqlCommand(sql, _conexion))
                    {
                        comando.CommandType = System.Data.CommandType.Text;
                        MySqlDataReader dr = (MySqlDataReader)await comando.ExecuteReaderAsync();
                        dt.Load(dr);
                    }
                }
            }
            catch (Exception ex)
            {
            }
            return dt;
        }

        public async Task<bool> InsertarDatosSoporteAsync(Soporte soporte)
        {
            bool insertar = false;
            try
            {
                string sql = "INSERT INTO soporte VALUES (@Codigo, @Nombre, @Descripcion, @Precio);";

                using (MySqlConnection _conexion = new MySqlConnection(CadenaConexion.Cadena))
                {
                    await _conexion.OpenAsync();
                    using (MySqlCommand comando = new MySqlCommand(sql, _conexion))
                    {
                        comando.CommandType = System.Data.CommandType.Text;
                        comando.Parameters.Add("@Codigo", MySqlDbType.Int32).Value = soporte.Codigo;
                        comando.Parameters.Add("@Nombre", MySqlDbType.VarChar, 45).Value = soporte.Nombre;
                        comando.Parameters.Add("@Descripcion", MySqlDbType.VarChar, 100).Value = soporte.Descripcion;
                        comando.Parameters.Add("@Precio", MySqlDbType.Decimal).Value = soporte.Precio;

                        await comando.ExecuteNonQueryAsync();
                        insertar = true;
                    }
                }
            }
            catch (Exception ex)
            {
            }
            return insertar;
        }

        public async Task<bool> ModificarDatosSoporteAsync(Soporte soporte)
        {
            bool modificar = false;
            try
            {
                string sql = "UPDATE soporte SET Nombre=@Nombre, Descripcion=@Descripcion, Precio=@Precio WHERE Codigo=@Codigo;";

                using (MySqlConnection _conexion = new MySqlConnection(CadenaConexion.Cadena))
                {
                    await _conexion.OpenAsync();
                    using (MySqlCommand comando = new MySqlCommand(sql, _conexion))
                    {
                        comando.CommandType = System.Data.CommandType.Text;
                        comando.Parameters.Add("@Codigo", MySqlDbType.Int32).Value = soporte.Codigo;
                        comando.Parameters.Add("@Nombre", MySqlDbType.VarChar, 45).Value = soporte.Nombre;
                        comando.Parameters.Add("@Descripcion", MySqlDbType.VarChar, 100).Value = soporte.Descripcion;
                        comando.Parameters.Add("@Precio", MySqlDbType.Decimal).Value = soporte.Precio;



                        await comando.ExecuteNonQueryAsync();
                        modificar = true;
                    }
                }
            }
            catch (Exception)
            {
            }
            return modificar;
        }
    }
}
