using CapaDatos;
using CapaEntidad;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
        ///listado

        public List<EntTipoPlato> ListarTipoPlato()
        {
            return DatTipoPlato.Instancia.ListarTipoPlato();
        }
        ///inserta
        public void InsertarTipoPlato(EntTipoPlato tipoPlato)
        {
            DatTipoPlato.Instancia.InsertarTipoPlato(tipoPlato);
        }
        //edita
        public void EditarTipoPlato(EntTipoPlato tipoPlato)
        {
            DatTipoPlato.Instancia.EditarTipoPlato(tipoPlato);
        }
        public void DeshabilitarTipoPlato(EntTipoPlato tipoPlato)
        {
            DatTipoPlato.Instancia.DeshabilitarTipoPlato(tipoPlato);
        }
        #endregion metodos
    }
}
