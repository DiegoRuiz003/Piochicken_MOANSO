using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaEntidad
{
    public class EntNotaVenta
    {
        public int Id { get; set; }
        public entCliente IdCliente { get; set;}
        public DateTime Fecha { get; set; }
        public Decimal Total { get; set; }
        public Boolean Estado { get; set; }
        public List<entDetNotaVenta> DetNotaVenta { get; set; }
    }
}
