using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaEntidad;

namespace CapaDatos
{
    public class DatProveedor
    {
        #region sigleton
        //Patron Singleton
        // Variable estática para la instancia
        private static readonly DatProveedor _instancia = new DatProveedor();
        //privado para evitar la instanciación directa
        public static DatProveedor Instancia
        {
            get
            {
                return DatProveedor._instancia;
            }
        }
        #endregion singleton
        #region metodos
        //LISTADO DE PROVEEDOR
        public List<entProveedor> ListarProveedor()
        {
            SqlCommand cmd = null;
            List<entProveedor> lista = new List<entProveedor>();
            try
            {
                SqlConnection cn = Conexion.Instancia.Conectar(); //singleton
                cmd = new SqlCommand("spListaProveedor", cn);
                cmd.CommandType = CommandType.StoredProcedure;
                cn.Open();
                SqlDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    entProveedor pv = new entProveedor();
                    pv.Id = Convert.ToInt32(dr["Id"]);
                    pv.Nombre = dr["Nombre"].ToString();
                    pv.RazonSocial = dr["RazonSocial"].ToString();
                    pv.Telefono = dr["Telefono"].ToString();
                    pv.Estado = Convert.ToBoolean(dr["Estado"]);
                    lista.Add(pv);
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

        //INSERTAR
        public Boolean InsertarProveedor(entProveedor pv)
        {
            SqlCommand cmd = null;
            Boolean inserta = false;
            try
            {
                SqlConnection cn = Conexion.Instancia.Conectar();
                cmd = new SqlCommand("spInsertarProveedor", cn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@nombre", pv.Nombre);
                cmd.Parameters.AddWithValue("@razonsocial", pv.RazonSocial);
                cmd.Parameters.AddWithValue("@telefono", pv.Telefono);
                cmd.Parameters.AddWithValue("@estado", pv.Estado);
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

        // EDITAR
        public Boolean EditarProveedor(entProveedor pv)
        {
            SqlCommand cmd = null;
            Boolean edita = false;
            try
            {
                SqlConnection cn = Conexion.Instancia.Conectar();
                cmd = new SqlCommand("spEditaProveedor", cn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@idproveedor", pv.Id);
                cmd.Parameters.AddWithValue("@nombre", pv.Nombre);
                cmd.Parameters.AddWithValue("@razonsocial", pv.RazonSocial);
                cmd.Parameters.AddWithValue("@telefono", pv.Telefono);
                cmd.Parameters.AddWithValue("@estado", pv.Estado);
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

        //DESHABILITAR
        public Boolean EliminarProveedor(entProveedor pv)
        {
            SqlCommand cmd = null;
            Boolean delete = false;
            try
            {
                SqlConnection cn = Conexion.Instancia.Conectar();
                cmd = new SqlCommand("spEliminarProveedor", cn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@idproveedor", pv.Id);
                //cmd.Parameters.AddWithValue("@estCliente", Cli.estCliente);
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

        //LEER
        public List<entProveedor> LeerProveedor()
        {
            SqlCommand cmd = null;
            List<entProveedor> leer = new List<entProveedor>();
            try
            {
                SqlConnection cn = Conexion.Instancia.Conectar(); //singleton
                cmd = new SqlCommand("spLeerProveedor", cn);
                cmd.CommandType = CommandType.StoredProcedure;
                cn.Open();
                SqlDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    entProveedor pv = new entProveedor();
                    pv.Id = Convert.ToInt32(dr["Id"]);
                    pv.Nombre = dr["Nombre"].ToString();
                    pv.RazonSocial = dr["RazonSocial"].ToString();
                    pv.Telefono = dr["Telefono"].ToString();
                    pv.Estado = Convert.ToBoolean(dr["Estado"]);
                    leer.Add(pv);
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
            return leer;
        }
        #endregion metodos;
    }
}
