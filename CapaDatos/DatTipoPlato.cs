using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaEntidad;
using System.Data.SqlClient;
using System.Data;

namespace CapaDatos
{
    public class DatTipoPlato
    {
        #region sigleton    
        private static readonly DatTipoPlato _instancia = new DatTipoPlato();
        public static DatTipoPlato Instancia
        {
            get
            {
                return DatTipoPlato._instancia;
            }
        }
        #endregion singleton
        #region metodos
        //LISTADO
        public List<EntTipoPlato> ListarTipoPlato()
        {
            SqlCommand cmd = null;
            List<EntTipoPlato> lista = new List<EntTipoPlato>();
            try
            {
                SqlConnection cn = Conexion.Instancia.Conectar(); //singleton
                cmd = new SqlCommand("spListarTipoPlato", cn);
                cmd.CommandType = CommandType.StoredProcedure;
                cn.Open();
                SqlDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    EntTipoPlato tp = new EntTipoPlato();
                    tp.Id = Convert.ToInt32(dr["Id"]);
                    tp.Nombre = dr["Nombre"].ToString();
                    tp.Estado = Convert.ToBoolean(dr["Estado"]);
                    lista.Add(tp);
                }

            }
            catch (Exception e)
            {
                throw e;
            }
            finally
            {
                cmd.Connection.Close();
            }
            return lista;
        }


        #endregion metodos

    }
}
