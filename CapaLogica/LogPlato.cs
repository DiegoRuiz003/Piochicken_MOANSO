using CapaDatos;
using CapaEntidad;
using System;
using System.Collections.Generic;

namespace CapaLogica
{
    public class LogPlato
    {
        #region sigleton
        //Patron Singleton
        // Variable estática para la instancia
        private static readonly LogPlato _instancia = new LogPlato();
        //privado para evitar la instanciación directa
        public static LogPlato Instancia
        {
            get
            {
                return LogPlato._instancia;
            }
        }
        #endregion singleton
        #region metodos

        //LISTAR
        public List<EntPlato> ListarPlato()
        {
            return DatPlato.Instancia.ListarPlato();
        }

        //LISTAR PLATO_TIPO
        public List<EntPlato> ListarPlato_Tipo(int idtipoplato)
        {
            return DatPlato.Instancia.ListarPlato_Tipo(idtipoplato);
        }

        //BUSCAR
        public EntPlato BuscarPlato(string idplato)
        {
            try
            {
                return DatPlato.Instancia.BuscarPlato(idplato);
            }
            catch (Exception e) { throw e; }
        }
        #endregion metodos
    }
}
