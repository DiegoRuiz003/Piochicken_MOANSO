using CapaDatos;
using CapaEntidad;
using System.Collections.Generic;

namespace CapaLogica
{
    public class LogMetodoPago
    {
        #region sigleton
        private static readonly LogMetodoPago _instancia = new LogMetodoPago();
        public static LogMetodoPago Instancia
        {
            get
            {
                return LogMetodoPago._instancia;
            }
        }
        #endregion singleton
        #region metodos

        //LISTAR
        public List<EntMetodoPago> ListarMetodoPago()
        {
            return DatMetodoPago.Instancia.ListarMetodoPago();
        }

        //INSERTAR
        public void InsertarMetodoPago(EntMetodoPago mp)
        {
            DatMetodoPago.Instancia.InsertarMetodoPago(mp);
        }

        ////EDITARR
        public void EditarMetodoPago(EntMetodoPago mp)
        {
            DatMetodoPago.Instancia.EditarMetodoPago(mp);
        }

        ////ELIMINAR
        public void EliminarMetodoPago(EntMetodoPago mp)
        {
            DatMetodoPago.Instancia.EliminarMetodoPago(mp);
        }

        ////LEER
        //public List<entCliente> LeerCliente()
        //{
        //    return datCliente.Instancia.LeerCliente();
        //}

        #endregion metodos;
    }
}
