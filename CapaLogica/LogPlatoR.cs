using CapaDatos;
using CapaEntidad;
using System;
using System.Collections.Generic;

namespace CapaLogica
{
    public class LogPlatoR
    {
        #region sigleton
        //Patron Singleton
        // Variable estática para la instancia
        private static readonly LogPlatoR _instancia = new LogPlatoR();
        //privado para evitar la instanciación directa
        public static LogPlatoR Instancia
        {
            get
            {
                return LogPlatoR._instancia;
            }
        }
        #endregion singleton
        #region metodos

        //LISTAR
        public List<EntPlatoR> ListarPlato()
        {
            return DatPlatoR.Instancia.ListarPlato();
        }

        //LISTAR PLATO_TIPO
        public List<EntPlatoR> ListarPlato_Tipo(int idtipoplato)
        {
            return DatPlatoR.Instancia.ListarPlato_Tipo(idtipoplato);
        }

        //BUSCAR
        public EntPlatoR BuscarPlato(string idplato)
        {
            try
            {
                return DatPlatoR.Instancia.BuscarPlato(idplato);
            }
            catch (Exception e) { throw e; }
        }
        #endregion metodos
    }
}
