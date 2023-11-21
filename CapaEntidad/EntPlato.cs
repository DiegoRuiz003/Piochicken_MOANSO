using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaEntidad
{
    public class EntPlato
    {
        public string id { get; set; }
        public string nombre { get; set; }
        public string idTipoPlato { get; set; }

        public List<EntInsumoPlato> insumosPlato { get; set; }

        public List<string> insumosPlatoRetirados { get; set; }

        public double precio { get; set; }
        public bool estado { get; set; }

        public EntPlato()
        {
            insumosPlato = new List<EntInsumoPlato>();
            insumosPlatoRetirados = new List<string>();
        }


    }
}
