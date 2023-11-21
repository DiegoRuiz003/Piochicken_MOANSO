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
    public class DatInsumo
    {

        #region sigleton
        //Patron Singleton
        // Variable estática para la instancia
        private static readonly DatInsumo _instancia = new DatInsumo();
        //privado para evitar la instanciación directa
        public static DatInsumo Instancia
        {
            get
            {
                return DatInsumo._instancia;
            }
        }
        #endregion singleton
        #region metodos
        ////////////////////listado de insumoentes
        public List<String> ListarTipoInsumo()
        {
            SqlCommand cmd = null;
            List<String> ids = new List<string>();
            try
            {
                SqlConnection cn = Conexion.Instancia.Conectar();
                cmd = new SqlCommand("splistartipoinsumo", cn);
                cmd.CommandType = CommandType.StoredProcedure;
                cn.Open();

                SqlDataReader dr = cmd.ExecuteReader();

                while (dr.Read())
                {
                    string idTi = dr["tipoinsumoid"].ToString();
                    ids.Add(idTi);
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
            return ids;
        }

        ////////////////////listado de insumoentes
        public List<EntInsumo> ListarInsumo()
        {
            SqlCommand cmd = null;
            List<EntInsumo> lista = new List<EntInsumo>();
            try
            {
                SqlConnection cn = Conexion.Instancia.Conectar(); //singleton
                cmd = new SqlCommand("spListarInsumo", cn);
                cmd.CommandType = CommandType.StoredProcedure;
                cn.Open();
                SqlDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    EntInsumo insumo = new EntInsumo();
                    insumo.id = dr["insumoID"].ToString();
                    insumo.nombre = dr["Nombreinsumo"].ToString();
                    insumo.idtipoinsumo = dr["tipoinsumoid"].ToString();
                    insumo.cantidad = Convert.ToInt16(dr["cantidadinsumo"]);
                    insumo.estado = Convert.ToBoolean(dr["Estadoinsumo"]);
                    lista.Add(insumo);
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
        /////////////////////////Insertainsumoente
        public Boolean InsertarInsumo(EntInsumo insumo)
        {
            SqlCommand cmd = null;
            Boolean inserta = false;
            try
            {
                SqlConnection cn = Conexion.Instancia.Conectar();
                cmd = new SqlCommand("spInsertarinsumo", cn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@insumoid", insumo.id);
                cmd.Parameters.AddWithValue("@nombreinsumo", insumo.nombre);
                cmd.Parameters.AddWithValue("@idtipoinsumo", insumo.idtipoinsumo);
                cmd.Parameters.AddWithValue("@cantidadinsumo", insumo.cantidad);
                cmd.Parameters.AddWithValue("@estadoinsumo", insumo.estado);
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
        //////////////////////////////////Editainsumoente
        public Boolean EditarInsumo(EntInsumo insumo)
        {
            SqlCommand cmd = null;
            Boolean edita = false;
            try
            {
                SqlConnection cn = Conexion.Instancia.Conectar();
                cmd = new SqlCommand("spEditarinsumo", cn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@insumoid", insumo.id);
                cmd.Parameters.AddWithValue("@nombreinsumo", insumo.nombre);
                cmd.Parameters.AddWithValue("@idtipoinsumo", insumo.idtipoinsumo);
                cmd.Parameters.AddWithValue("@cantidadinsumo", insumo.cantidad);
                cmd.Parameters.AddWithValue("@estadoinsumo", insumo.estado);
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
        //deshabilitainsumo
        public Boolean DeshabilitarInsumo(EntInsumo insumo)
        {
            SqlCommand cmd = null;
            Boolean delete = false;
            try
            {
                SqlConnection cn = Conexion.Instancia.Conectar();
                cmd = new SqlCommand("spDeshabilitarinsumo", cn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@insumoid", insumo.id);
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
