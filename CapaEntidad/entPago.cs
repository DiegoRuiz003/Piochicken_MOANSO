using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaEntidad
{
    public class entPago
    {
        public int Id { get; set; }
        public int IdMetodoPago { get; set; }
        public int IdNotaVenta { get; set; }
        public DateTime Fecha { get; set; }
        public Decimal Total { get; set; }
        public Boolean Estado { get; set; }
    }
}
