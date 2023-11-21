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
    public class datCliente
    {
        #region sigleton    
        private static readonly datCliente _instancia = new datCliente();
        public static datCliente Instancia
        {
            get
            {
                return datCliente._instancia;
            }
        }
        #endregion singleton
        #region metodos
        //LISTADO
        public List<entCliente> ListarCliente()
        {
            SqlCommand cmd = null;
            List<entCliente> lista = new List<entCliente>();
            try
            {
                SqlConnection cn = Conexion.Instancia.Conectar(); //singleton
                cmd = new SqlCommand("spListarCliente", cn);
                cmd.CommandType = CommandType.StoredProcedure;
                cn.Open();
                SqlDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    entCliente cl = new entCliente();
                    cl.Id = Convert.ToInt32(dr["Id"]);
                    cl.Nombre = dr["Nombre"].ToString();
                    cl.Dni = dr["Dni"].ToString();
                    cl.Telefono = dr["Telefono"].ToString();
                    cl.Correo = dr["Correo"].ToString();
                    cl.Estado = Convert.ToBoolean(dr["Estado"]);
                    lista.Add(cl);
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
        public Boolean InsertarCliente(entCliente cl)
        {
            SqlCommand cmd = null;
            Boolean inserta = false;
            try
            {
                SqlConnection cn = Conexion.Instancia.Conectar();
                cmd = new SqlCommand("spInsertarCliente", cn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@nombre", cl.Nombre);
                cmd.Parameters.AddWithValue("@dni", cl.Dni);
                cmd.Parameters.AddWithValue("@telefono", cl.Telefono);
                cmd.Parameters.AddWithValue("@correo", cl.Correo);              
                cmd.Parameters.AddWithValue("@estado", cl.Estado);
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
        public Boolean EditarCliente(entCliente cl)
        {
            SqlCommand cmd = null;
            Boolean edita = false;
            try
            {
                SqlConnection cn = Conexion.Instancia.Conectar();
                cmd = new SqlCommand("spModificarCliente", cn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@idcliente", cl.Id);
                cmd.Parameters.AddWithValue("@nombre", cl.Nombre);
                cmd.Parameters.AddWithValue("@dni", cl.Dni);
                cmd.Parameters.AddWithValue("@telefono", cl.Telefono);
                cmd.Parameters.AddWithValue("@correo", cl.Correo);
                cmd.Parameters.AddWithValue("@estado", cl.Estado);
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

        //ELIMINAR
        public Boolean EliminarCliente(entCliente cl)
        {
            SqlCommand cmd = null;
            Boolean delete = false;
            try
            {
                SqlConnection cn = Conexion.Instancia.Conectar();
                cmd = new SqlCommand("spDeshabilitarCliente", cn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@idcliente", cl.Id);
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

        public entCliente BuscarCliente(string DniCliente)
        {
            SqlCommand cmd = null;
            entCliente cl = new entCliente();
            try
            {
                SqlConnection cn = Conexion.Instancia.Conectar();
                cmd = new SqlCommand("spBuscarCliente", cn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@dni", DniCliente);
                cn.Open();
                SqlDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    
                    cl.Id = Convert.ToInt32(dr["Id"]);
                    cl.Nombre = dr["Nombre"].ToString();
                    cl.Dni = dr["Dni"].ToString();
                    cl.Telefono = dr["Telefono"].ToString();
                    cl.Correo = dr["Correo"].ToString();
                    cl.Estado = Convert.ToBoolean(dr["Estado"]);                   

                }
            }
            catch (Exception e)
            {

                throw e;
            }
            finally { cmd.Connection.Close(); }
            return cl;
        }

        //LEER
        public List<entCliente> LeerCliente()
        {
            SqlCommand cmd = null;
            List<entCliente> leer = new List<entCliente>();
            try
            {
                SqlConnection cn = Conexion.Instancia.Conectar(); //singleton
                cmd = new SqlCommand("spLeerCliente", cn);
                cmd.CommandType = CommandType.StoredProcedure;
                cn.Open();
                SqlDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {

                    entCliente cl = new entCliente();
                    cl.Id = Convert.ToInt32(dr["Id"]);
                    cl.Nombre = dr["Nombre"].ToString();
                    cl.Estado = Convert.ToBoolean(dr["Estado"]);
                    leer.Add(cl);
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
