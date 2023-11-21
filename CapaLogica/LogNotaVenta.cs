using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CapaDatos;
using CapaEntidad;

namespace CapaLogica
{
    public class LogNotaVenta
    {
        #region singleton
        private static readonly LogNotaVenta _instancia = new LogNotaVenta();
        public static LogNotaVenta Instancia
        {
            get { return LogNotaVenta._instancia; }
        }
        #endregion singleton
        #region metodos
        public List<EntNotaVenta> ListarNotaVenta()
        {
            try
            {
                return DatNotaVenta.Instancia.ListarNotaVenta();
            }
            catch (Exception e)
            {
                throw e;
            }
        }
        public int InsertarNotaVenta(EntNotaVenta nv)
        {
            int a;
            try
            {
                a = DatNotaVenta.Instancia.InsertarNotaVenta(nv);
            }
            catch (Exception e)
            { throw e; }

            return a;
        }
        public void InsertarDetNotaVenta(entDetNotaVenta dnv)
        {
            try
            {
                DatNotaVenta.Instancia.InsertarDetNotaVenta(dnv);
            }
            catch (Exception e)
            {
                MessageBox.Show("DETALLE LISTO" );
                //throw e; 
            }
        }

        #endregion metodos
    }
}
