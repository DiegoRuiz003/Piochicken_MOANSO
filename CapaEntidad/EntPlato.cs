using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaEntidad
{
    public class EntPlato
    {
        public  string Id { get; set; }
        public string Nombre { get; set; }
        public string Descripcion { get; set;}
        public EntTipoPlato IdTipoPlato { get; set; }
        public Decimal Precio { get; set; }
        public Boolean Estado { get; set; }

    }
}
