using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Tickets
    {
        public int idTickets { get; set; }
        public DateTime Fecha  { get; set; }
        public string CorreoUsuario { get; set; }
        public string Cliente { get; set; }
        public string NombreSoporte { get; set; }
        public string DescripcionSolicitud { get; set; }
        public string DescripcionRespuesta { get; set; }
        public decimal PrecioSoporte { get; set; }
        public decimal Impuesto { get; set; }
        public decimal Descuento { get; set; }
        public decimal Total { get; set; }

    }
}
