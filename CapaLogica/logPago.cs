using CapaDatos;
using CapaEntidad;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaLogica
{
    public class logPago
    {
        #region sigleton
        //Patron Singleton
        // Variable estática para la instancia
        private static readonly logPago _instancia = new logPago();
        //privado para evitar la instanciación directa
        public static logPago Instancia
        {
            get
            {
                return logPago._instancia;
            }
        }
        #endregion singleton

        #region metodos

        //LISTAR
        public List<entDetNotaVenta> ListarDetNotaVenta(int idnotaventa)
        {
            return datPago.Instancia.ListarDetNotaVenta(idnotaventa);
        }

        //INSERTAR
        public void InsertarPago(entPago pl)
        {
            datPago.Instancia.InsertarPago(pl);
        }

        //BUSCAR
        public EntNotaVenta BuscarNotaVenta(int idventa)
        {
            try
            {
                return datPago.Instancia.BuscarNotaVenta(idventa);
            }
            catch (Exception e) { throw e; }
        }



        #endregion metodos
    }
}
