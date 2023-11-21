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
    public class DatTipoPlato
    {
        #region sigleton
        //Patron Singleton
        // Variable estática para la instancia
        private static readonly DatTipoPlato _instancia = new DatTipoPlato();
        //privado para evitar la instanciación directa
        public static DatTipoPlato Instancia
        {
            get
            {
                return DatTipoPlato._instancia;
            }
        }
        #endregion singleton
        #region metodos
        ////////////////////listado de tipoPlatoentes
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
                    EntTipoPlato tipoPlato = new EntTipoPlato();
                    tipoPlato.id = dr["TipoPlatoID"].ToString();
                    tipoPlato.nombre = dr["NombreTipoPlato"].ToString();
                    tipoPlato.estado = Convert.ToBoolean(dr["EstadoTipoPlato"]);
                    lista.Add(tipoPlato);
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
        /////////////////////////InsertatipoPlatoente
        public Boolean InsertarTipoPlato(EntTipoPlato tipoPlato)
        {
            SqlCommand cmd = null;
            Boolean inserta = false;
            try
            {
                SqlConnection cn = Conexion.Instancia.Conectar();
                cmd = new SqlCommand("spInsertarTipoPlato", cn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@tipoplatoid", tipoPlato.id);
                cmd.Parameters.AddWithValue("@nombretipoplato", tipoPlato.nombre);
                cmd.Parameters.AddWithValue("@estadotipoplato", tipoPlato.estado);
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
        //////////////////////////////////EditatipoPlatoente
        public Boolean EditarTipoPlato(EntTipoPlato tipoPlato)
        {
            SqlCommand cmd = null;
            Boolean edita = false;
            try
            {
                SqlConnection cn = Conexion.Instancia.Conectar();
                cmd = new SqlCommand("spEditarTipoPlato", cn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@tipoplatoid", tipoPlato.id);
                cmd.Parameters.AddWithValue("@nombretipoplato", tipoPlato.nombre);
                cmd.Parameters.AddWithValue("@estadotipoplato", tipoPlato.estado);
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
        //deshabilitatipoPlato
        public Boolean DeshabilitarTipoPlato(EntTipoPlato tipoPlato)
        {
            SqlCommand cmd = null;
            Boolean delete = false;
            try
            {
                SqlConnection cn = Conexion.Instancia.Conectar();
                cmd = new SqlCommand("spDeshabilitarTipoPlato", cn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@tipoplatoid", tipoPlato.id);
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
