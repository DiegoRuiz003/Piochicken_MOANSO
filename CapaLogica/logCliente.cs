using CapaDatos;
using CapaEntidad;
using System;
using System.Collections.Generic;

namespace CapaLogica
{
    public class logCliente
    {
        #region sigleton
        //Patron Singleton
        // Variable estática para la instancia
        private static readonly logCliente _instancia = new logCliente();
        //privado para evitar la instanciación directa
        public static logCliente Instancia
        {
            get
            {
                return logCliente._instancia;
            }
        }
        #endregion singleton
        #region metodos

        //LISTAR
        public List<entCliente> ListarCliente()
        {
            return datCliente.Instancia.ListarCliente();
        }

        //INSERTAR
        public void InsertarCliente(entCliente cl)
        {
            datCliente.Instancia.InsertarCliente(cl);
        }

        //EDITARR
        public void EditarCliente(entCliente cl)
        {
            datCliente.Instancia.EditarCliente(cl);
        }

        //ELIMINAR
        public void EliminarCliente(entCliente cl)
        {
            datCliente.Instancia.EliminarCliente(cl);
        }

        //LEER
        public List<entCliente> LeerCliente()
        {
            return datCliente.Instancia.LeerCliente();
        }
        //BUSCAR
        public entCliente BuscarCliente(string DniCliente)
        {
            try
            {
                return datCliente.Instancia.BuscarCliente(DniCliente);
            }
            catch (Exception e) { throw e; }
        }

        #endregion metodos;

    }
}
