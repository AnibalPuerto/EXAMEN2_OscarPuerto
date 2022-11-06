using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaseDatos
{
    public class UsuarioDatos
    {
        public async Task<bool> LoginAsync(string Correo, string Contraseña)
        {
            bool verificar = false;
            try
            {
                string sql = "SELECT 1 FROM usuario WHERE Correo=@Correo AND Contraseña=@Contraseña;";

                using (MySqlConnection _conexion_Ejercicio = new MySqlConnection(CadenaConexion.Cadena))
                {
                    await _conexion_Ejercicio.OpenAsync();
                    using (MySqlCommand comando = new MySqlCommand(sql, _conexion_Ejercicio))
                    {
                        comando.CommandType = System.Data.CommandType.Text;
                        comando.Parameters.Add("@Correo", MySqlDbType.VarChar, 50).Value = Correo;
                        comando.Parameters.Add("@Contraseña", MySqlDbType.VarChar, 50).Value = Contraseña;
                        verificar = Convert.ToBoolean(await comando.ExecuteScalarAsync());
                    }

                }

            }
            catch (Exception ex)
            {

            }
            return verificar;
        }
    }
}
