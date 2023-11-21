using CapaDatos;
using CapaEntidad;
using System.Collections.Generic;

namespace CapaLogica
{
    public class LogTipoPlatoR
    {
        #region sigleton
        //Patron Singleton
        // Variable estática para la instancia
        private static readonly LogTipoPlatoR _instancia = new LogTipoPlatoR();
        //privado para evitar la instanciación directa
        public static LogTipoPlatoR Instancia
        {
            get
            {
                return LogTipoPlatoR._instancia;
            }
        }
        #endregion singleton
        #region metodos

        //LISTAR
        public List<EntTipoPlatoR> ListarTipoPlato()
        {
            return DatTipoPlatoR.Instancia.ListarTipoPlato();
        }
        #endregion metodos

    }
}
