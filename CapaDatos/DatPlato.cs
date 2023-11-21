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
    public class DatPlato
    {

        #region sigleton
        //Patron Singleton
        // Variable estática para la instancia
        private static readonly DatPlato _instancia = new DatPlato();
        //privado para evitar la instanciación directa
        public static DatPlato Instancia
        {
            get
            {
                return DatPlato._instancia;
            }
        }
        #endregion singleton
        #region metodos
        ////////////////////listado de platoentes
        public List<String> ListarTipoPlato()
        {
            SqlCommand cmd = null;
            List<String> ids = new List<string>();
            try
            {
                SqlConnection cn = Conexion.Instancia.Conectar();
                cmd = new SqlCommand("spListarTipoPlato", cn);
                cmd.CommandType = CommandType.StoredProcedure;
                cn.Open();

                SqlDataReader dr = cmd.ExecuteReader();

                while (dr.Read())
                {
                    string idTp = dr["tipoplatoid"].ToString();
                    ids.Add(idTp);
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
        public EntInsumo ListarInsumoEscogido(string idInsumo)
        {
            SqlCommand cmd = null;
            EntInsumo insumo = new EntInsumo();

            try
            {
                SqlConnection cn = Conexion.Instancia.Conectar();
                cmd = new SqlCommand("spListarInsumoEscogido", cn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("insumoId", idInsumo);
                cn.Open();

                SqlDataReader dr = cmd.ExecuteReader();

                while (dr.Read())
                {
                    insumo.id = dr["insumoid"].ToString();
                    insumo.nombre = dr["Nombreinsumo"].ToString();
                    insumo.idtipoinsumo = dr["tipoinsumoid"].ToString();
                    insumo.cantidad = Convert.ToInt16(dr["cantidadinsumo"]);
                    insumo.estado = Convert.ToBoolean(dr["Estadoinsumo"]);
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
            return insumo;
        }



        public List<String> ListarInsumo()
        {
            SqlCommand cmd = null;
            List<String> ids = new List<string>();
            try
            {
                SqlConnection cn = Conexion.Instancia.Conectar();
                cmd = new SqlCommand("spListarInsumo", cn);
                cmd.CommandType = CommandType.StoredProcedure;
                cn.Open();

                SqlDataReader dr = cmd.ExecuteReader();

                while (dr.Read())
                {
                    string idI = dr["insumoid"].ToString();
                    ids.Add(idI);
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


        ////////////////////listado de platoentes
        public List<EntPlato> ListarPlato()
        {
            SqlCommand cmd = null;

            List<EntPlato> lista = new List<EntPlato>();
            try
            {
                SqlConnection cn = Conexion.Instancia.Conectar(); //singleton
                cmd = new SqlCommand("spListarPlato", cn);
                cmd.CommandType = CommandType.StoredProcedure;
                cn.Open();
                SqlDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    EntPlato plato = new EntPlato();
                    plato.id = dr["platoID"].ToString();
                    plato.nombre = dr["Nombreplato"].ToString();
                    plato.idTipoPlato = dr["TipoPlatoID"].ToString();
                    plato.precio = Convert.ToDouble(dr["PrecioPlato"]);
                    plato.estado = Convert.ToBoolean(dr["Estadoplato"]);
                    lista.Add(plato);
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

        public List<EntInsumo> ListarInsumoPlato(string idPlato)
        {
            SqlCommand cmd = null;

            List<EntInsumo> lista = new List<EntInsumo>();
            try
            {
                SqlConnection cn = Conexion.Instancia.Conectar(); //singleton
                cmd = new SqlCommand("spListarDetallePlato", cn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@platoid", idPlato);
                cn.Open();
                SqlDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    EntInsumo insumo = new EntInsumo();
                    insumo.id = dr["insumoid"].ToString();
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


        /////////////////////////Insertaplatoente
        public Boolean InsertarPlato(EntPlato plato)
        {
            SqlCommand cmd = null;
            SqlCommand cmd1 = null;
            Boolean inserta = false;
            try
            {
                SqlConnection cn = Conexion.Instancia.Conectar();
                cmd = new SqlCommand("spInsertarplato", cn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@platoid", plato.id);
                cmd.Parameters.AddWithValue("@nombreplato", plato.nombre);
                cmd.Parameters.AddWithValue("@tipoplatoid", plato.idTipoPlato);
                cmd.Parameters.AddWithValue("@precioplato", plato.precio);
                cmd.Parameters.AddWithValue("@estadoplato", plato.estado);

                cn.Open();
                int i = cmd.ExecuteNonQuery();

                foreach (EntInsumoPlato ip in plato.insumosPlato)
                {
                    cmd1 = new SqlCommand("spInsertarInsumoPlato", cn);
                    cmd1.CommandType = CommandType.StoredProcedure;
                    cmd1.Parameters.AddWithValue("@insumoid", ip.idInsumo);
                    cmd1.Parameters.AddWithValue("@platoid", ip.idPlato);
                    cmd1.Parameters.AddWithValue("@estadoinsumoplato", 1);
                    cmd1.ExecuteNonQuery();
                }

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
        //////////////////////////////////Editaplatoente
        public Boolean EditarPlato(EntPlato plato)
        {
            SqlCommand cmd = null;

            Boolean edita = false;
            try
            {
                SqlConnection cn = Conexion.Instancia.Conectar();
                cmd = new SqlCommand("spEditarplato", cn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@platoid", plato.id);
                cmd.Parameters.AddWithValue("@nombreplato", plato.nombre);
                cmd.Parameters.AddWithValue("@tipoplatoid", plato.idTipoPlato);
                cmd.Parameters.AddWithValue("@precioplato", plato.precio);
                cmd.Parameters.AddWithValue("@estadoplato", plato.estado);
                cn.Open();
                int i = cmd.ExecuteNonQuery();

                foreach (EntInsumoPlato ip in plato.insumosPlato)
                {
                    cmd = new SqlCommand("spInsertarInsumoPlato", cn);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@insumoid", ip.idInsumo);
                    cmd.Parameters.AddWithValue("@platoid", ip.idPlato);
                    cmd.Parameters.AddWithValue("@estadoinsumoplato", 1);
                    cmd.ExecuteNonQuery();
                }

                foreach (string ipr in plato.insumosPlatoRetirados)
                {
                    cmd = new SqlCommand("spDeshabilitarInsumoPlato", cn);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@insumoid", ipr);
                    cmd.Parameters.AddWithValue("@platoid", plato.id);
                    cmd.ExecuteNonQuery();
                }

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
        //deshabilitaplato
        public Boolean DeshabilitarPlato(EntPlato plato)
        {
            SqlCommand cmd = null;
            SqlCommand cmd1 = null;

            Boolean delete = false;
            try
            {
                SqlConnection cn = Conexion.Instancia.Conectar();
                cmd = new SqlCommand("spDeshabilitarplato", cn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@platoid", plato.id);
                cn.Open();
                int i = cmd.ExecuteNonQuery();

                foreach (EntInsumoPlato ip in plato.insumosPlato)
                {
                    cmd = new SqlCommand("spDeshabilitarInsumoPlato", cn);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@insumoid", ip.idInsumo);
                    cmd.Parameters.AddWithValue("@platoid", ip.idPlato);
                    cmd.ExecuteNonQuery();
                }

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
