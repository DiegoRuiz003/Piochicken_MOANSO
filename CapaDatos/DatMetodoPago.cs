using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using CapaEntidad;

namespace CapaDatos
{
    public class DatMetodoPago
    {
        #region sigleton    
        private static readonly DatMetodoPago _instancia = new DatMetodoPago();
        public static DatMetodoPago Instancia
        {
            get
            {
                return DatMetodoPago._instancia;
            }
        }
        #endregion singleton
        #region metodos
        //LISTAR
        public List<EntMetodoPago> ListarMetodoPago()
        {
            SqlCommand cmd = null;
            List<EntMetodoPago> lista = new List<EntMetodoPago>();
            try
            {
                SqlConnection cn = Conexion.Instancia.Conectar(); //singleton
                cmd = new SqlCommand("spListarMetodoPago", cn);
                cmd.CommandType = CommandType.StoredProcedure;
                cn.Open();
                SqlDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    EntMetodoPago mp = new EntMetodoPago();
                    mp.Id = Convert.ToInt32(dr["Id"]);
                    mp.MetodoPago = dr["MetodoPago"].ToString();
                    mp.Estado = Convert.ToBoolean(dr["Estado"]);
                    lista.Add(mp);
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
        public Boolean InsertarMetodoPago(EntMetodoPago mp)
        {
            SqlCommand cmd = null;
            Boolean inserta = false;
            try
            {
                SqlConnection cn = Conexion.Instancia.Conectar();
                cmd = new SqlCommand("spInsertarMetodoPago", cn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@metodopago", mp.MetodoPago);
                cmd.Parameters.AddWithValue("@estado", mp.Estado);
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

        //EDITAR
        public Boolean EditarMetodoPago(EntMetodoPago mp)
        {
            SqlCommand cmd = null;
            Boolean edita = false;
            try
            {
                SqlConnection cn = Conexion.Instancia.Conectar();
                cmd = new SqlCommand("spModificarMetodoPago", cn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@idmetodopago", mp.Id);
                cmd.Parameters.AddWithValue("@metodopago", mp.MetodoPago);
                cmd.Parameters.AddWithValue("@estado", mp.Estado);
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
        public Boolean EliminarMetodoPago(EntMetodoPago mp)
        {
            SqlCommand cmd = null;
            Boolean delete = false;
            try
            {
                SqlConnection cn = Conexion.Instancia.Conectar();
                cmd = new SqlCommand("spDeshabilitarMetodoPago", cn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@idmetodopago", mp.Id);
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
        #endregion metodos
    }
}
