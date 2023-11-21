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
    public class DatTipoPlatoR
    {
        #region sigleton    
        private static readonly DatTipoPlatoR _instancia = new DatTipoPlatoR();
        public static DatTipoPlatoR Instancia
        {
            get
            {
                return DatTipoPlatoR._instancia;
            }
        }
        #endregion singleton
        #region metodos
        //LISTADO
        public List<EntTipoPlatoR> ListarTipoPlato()
        {
            SqlCommand cmd = null;
            List<EntTipoPlatoR> lista = new List<EntTipoPlatoR>();
            try
            {
                SqlConnection cn = Conexion.Instancia.Conectar(); //singleton
                cmd = new SqlCommand("spListarTipoPlato", cn);
                cmd.CommandType = CommandType.StoredProcedure;
                cn.Open();
                SqlDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    EntTipoPlatoR tp = new EntTipoPlatoR();
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
