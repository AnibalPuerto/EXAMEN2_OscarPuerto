using Entidades;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaseDatos
{
    public class TicketsDatos
    {
        public async Task<bool> InsertarDatosTicketsAsync(Tickets tickets)
        {
            bool insertar = false;
            try
            {
                string sql = "INSERT INTO tickets VALUES (@Fecha,@CorreoUsuario,@Cliente,@NombreSoporte,@DescripcionSolicitud,@DescripcionRespuesta,@PrecioSoporte,@Impuesto,@Descuento,@Total);";

                using (MySqlConnection _conexion = new MySqlConnection(CadenaConexion.Cadena))
                {
                    await _conexion.OpenAsync();
                    using (MySqlCommand comando = new MySqlCommand(sql, _conexion))
                    {
                        comando.CommandType = System.Data.CommandType.Text;
                        comando.Parameters.Add("@Fecha", MySqlDbType.DateTime).Value = tickets.Fecha;
                        comando.Parameters.Add("@CorreoUsuario", MySqlDbType.VarChar, 50).Value = tickets.CorreoUsuario;
                        comando.Parameters.Add("@Cliente", MySqlDbType.VarChar, 45).Value = tickets.Cliente;
                        comando.Parameters.Add("@NombreSoporte", MySqlDbType.VarChar, 45).Value = tickets.NombreSoporte;
                        comando.Parameters.Add("@DescripcionSolicitud", MySqlDbType.VarChar, 100).Value = tickets.DescripcionSolicitud;
                        comando.Parameters.Add("@DescripcionRespuesta", MySqlDbType.VarChar, 100).Value = tickets.DescripcionRespuesta;
                        comando.Parameters.Add("@PrecioSoporte", MySqlDbType.Decimal).Value = tickets.PrecioSoporte;
                        comando.Parameters.Add("@Impuesto", MySqlDbType.Decimal).Value = tickets.Impuesto;
                        comando.Parameters.Add("@Descuento", MySqlDbType.Decimal).Value = tickets.Descuento;
                        comando.Parameters.Add("@Total", MySqlDbType.Decimal).Value = tickets.Total;

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
    }


}
