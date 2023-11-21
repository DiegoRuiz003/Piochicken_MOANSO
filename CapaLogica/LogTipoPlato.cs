using CapaDatos;
using CapaEntidad;
using System.Collections.Generic;

namespace CapaLogica
{
    public class LogTipoPlato
    {
        #region sigleton
        //Patron Singleton
        // Variable estática para la instancia
        private static readonly LogTipoPlato _instancia = new LogTipoPlato();
        //privado para evitar la instanciación directa
        public static LogTipoPlato Instancia
        {
            get
            {
                return LogTipoPlato._instancia;
            }
        }
        #endregion singleton
        #region metodos

        //LISTAR
        public List<EntTipoPlato> ListarTipoPlato()
        {
            return DatTipoPlato.Instancia.ListarTipoPlato();
        }
        #endregion metodos

    }
}
