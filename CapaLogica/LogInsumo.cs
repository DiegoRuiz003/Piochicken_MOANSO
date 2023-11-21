using CapaDatos;
using CapaEntidad;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaLogica
{
    public class LogInsumo
    {

        #region sigleton
        //Patron Singleton
        // Variable estática para la instancia
        private static readonly LogInsumo _instancia = new LogInsumo();
        //privado para evitar la instanciación directa
        public static LogInsumo Instancia
        {
            get
            {
                return LogInsumo._instancia;
            }
        }
        #endregion singleton
        #region metodos
        ///listado

        public List<string> ListarTipoInsumo()
        {
            return DatInsumo.Instancia.ListarTipoInsumo();
        }
        public List<EntInsumo> ListarInsumo()
        {
            return DatInsumo.Instancia.ListarInsumo();
        }
        ///inserta
        public void InsertarInsumo(EntInsumo insumo)
        {
            DatInsumo.Instancia.InsertarInsumo(insumo);
        }
        //edita
        public void EditarInsumo(EntInsumo insumo)
        {
            DatInsumo.Instancia.EditarInsumo(insumo);
        }
        public void DeshabilitarInsumo(EntInsumo insumo)
        {
            DatInsumo.Instancia.DeshabilitarInsumo(insumo);
        }
        #endregion metodos
    }

}
