﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaEntidad
{
    public class EntPlatoR
    {
        public  string Id { get; set; }
        public string Nombre { get; set; }
        public string Descripcion { get; set;}
        public EntTipoPlatoR IdTipoPlato { get; set; }
        public Decimal Precio { get; set; }
        public Boolean Estado { get; set; }

    }
}
