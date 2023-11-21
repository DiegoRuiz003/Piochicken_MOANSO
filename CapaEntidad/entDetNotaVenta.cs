using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaEntidad
{
    public class entDetNotaVenta
    {
        public int Id { get; set; }
        public int IdNotaventa { get; set; }
        public EntPlatoR IdPlato { get; set;}
        public int Cantidad { get; set; }
        public Decimal Precio { get; set; }
        public Decimal SubTotal { get; set; }

    }
}
