using CapaDatos;
using CapaEntidad;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
        ///listado

        public List<string> ListarTipoPlato()
        {
            return DatPlato.Instancia.ListarTipoPlato();
        }
        public EntInsumo ListarInsumoEscogido(string idInsumo)
        {
            return DatPlato.Instancia.ListarInsumoEscogido(idInsumo);
        }

        public List<string> ListarInsumo()
        {
            return DatPlato.Instancia.ListarInsumo();
        }

        public List<EntPlato> ListarPlato()
        {
            return DatPlato.Instancia.ListarPlato();
        }

        public List<EntInsumo> ListarInsumoPlato(string idPlato)
        {
            return DatPlato.Instancia.ListarInsumoPlato(idPlato);
        }

        ///inserta
        public void InsertarPlato(EntPlato plato)
        {
            DatPlato.Instancia.InsertarPlato(plato);
        }
        //edita
        public void EditarPlato(EntPlato plato)
        {
            DatPlato.Instancia.EditarPlato(plato);
        }
        public void DeshabilitarPlato(EntPlato plato)
        {
            DatPlato.Instancia.DeshabilitarPlato(plato);
        }
        #endregion metodos

    }
}
