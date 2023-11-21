using CapaDatos;
using CapaEntidad;
using System.Collections.Generic;

namespace CapaLogica
{
    public class logProveedor
    {
        #region sigleton
        //Patron Singleton
        // Variable estática para la instancia
        private static readonly logProveedor _instancia = new logProveedor();
        //privado para evitar la instanciación directa
        public static logProveedor Instancia
        {
            get
            {
                return logProveedor._instancia;
            }
        }
        #endregion singleton

        #region metodos

        //LISTAR
        public List<entProveedor> ListarProveedor()
        {
            return DatProveedor.Instancia.ListarProveedor();
        }
        //INSERTAR
        public void InsertaProveedor(entProveedor pv)
        {
            DatProveedor.Instancia.InsertarProveedor(pv);
        }

        //EDITARR
        public void EditarProveedor(entProveedor pv)
        {
            DatProveedor.Instancia.EditarProveedor(pv);
        }

        //ELIMINAR
        public void EliminarProveedor(entProveedor pv)
        {
            DatProveedor.Instancia.EliminarProveedor(pv);
        }

        //LEER
        public List<entProveedor> LeerProveedor()
        {
            return DatProveedor.Instancia.LeerProveedor();
        }
        #endregion metodos;
    }
}
