using CapaEntidad;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaDatos
{
    public class DatTipoInsumo
    {

        #region sigleton
        //Patron Singleton
        // Variable estática para la instancia
        private static readonly DatTipoInsumo _instancia = new DatTipoInsumo();
        //privado para evitar la instanciación directa
        public static DatTipoInsumo Instancia
        {
            get
            {
                return DatTipoInsumo._instancia;
            }
        }
        #endregion singleton
        #region metodos
        ////////////////////listado de tipoinsumoentes
        public List<EntTipoInsumo> ListarTipoInsumo()
        {
            SqlCommand cmd = null;
            List<EntTipoInsumo> lista = new List<EntTipoInsumo>();
            try
            {
                SqlConnection cn = Conexion.Instancia.Conectar(); //singleton
                cmd = new SqlCommand("spListarTipoInsumo", cn);
                cmd.CommandType = CommandType.StoredProcedure;
                cn.Open();
                SqlDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    EntTipoInsumo tipoinsumo = new EntTipoInsumo();
                    tipoinsumo.id = dr["tipoinsumoID"].ToString();
                    tipoinsumo.nombre = dr["Nombretipoinsumo"].ToString();
                    tipoinsumo.estado = Convert.ToBoolean(dr["Estadotipoinsumo"]);
                    lista.Add(tipoinsumo);
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
        /////////////////////////Insertatipoinsumoente
        public Boolean InsertarTipoInsumo(EntTipoInsumo tipoinsumo)
        {
            SqlCommand cmd = null;
            Boolean inserta = false;
            try
            {
                SqlConnection cn = Conexion.Instancia.Conectar();
                cmd = new SqlCommand("spInsertartipoinsumo", cn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@tipoinsumoid", tipoinsumo.id);
                cmd.Parameters.AddWithValue("@nombretipoinsumo", tipoinsumo.nombre);
                cmd.Parameters.AddWithValue("@estadotipoinsumo", tipoinsumo.estado);
                cn.Open();
                int i = cmd.ExecuteNonQuery();
                if (i > 0)
                {
                    inserta = true;
                }
            }
            catch (Exception e)
            {
                throw e;
            }
            finally { cmd.Connection.Close(); }
            return inserta;
        }
        //////////////////////////////////Editatipoinsumoente
        public Boolean EditarTipoInsumo(EntTipoInsumo tipoinsumo)
        {
            SqlCommand cmd = null;
            Boolean edita = false;
            try
            {
                SqlConnection cn = Conexion.Instancia.Conectar();
                cmd = new SqlCommand("spEditarTipoInsumo", cn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@tipoinsumoid", tipoinsumo.id);
                cmd.Parameters.AddWithValue("@nombretipoinsumo", tipoinsumo.nombre);
                cmd.Parameters.AddWithValue("@estadotipoinsumo", tipoinsumo.estado);
                cn.Open();
                int i = cmd.ExecuteNonQuery();
                if (i > 0)
                {
                    edita = true;
                }

            }
            catch (Exception e)
            {
                throw e;
            }
            finally { cmd.Connection.Close(); }
            return edita;
        }
        //deshabilitatipoinsumo
        public Boolean DeshabilitarTipoInsumo(EntTipoInsumo tipoinsumo)
        {
            SqlCommand cmd = null;
            Boolean delete = false;
            try
            {
                SqlConnection cn = Conexion.Instancia.Conectar();
                cmd = new SqlCommand("spDeshabilitarTipoInsumo", cn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@tipoinsumoid", tipoinsumo.id);
                cn.Open();
                int i = cmd.ExecuteNonQuery();
                if (i > 0)
                {
                    delete = true;
                }
            }
            catch (Exception e)
            {
                throw e;
            }
            finally { cmd.Connection.Close(); }
            return delete;
        }
        #endregion metodos

    }

}
