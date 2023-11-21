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
    public class datPago
    {
        #region sigleton    
        private static readonly datPago _instancia = new datPago();
        public static datPago Instancia
        {
            get
            {
                return datPago._instancia;
            }
        }
        #endregion singleton

        #region metodos
        //LISTAR
        public List<entDetNotaVenta> ListarDetNotaVenta(int idnotaventa)
        {
            SqlCommand cmd = null;
            List<entDetNotaVenta> lista = new List<entDetNotaVenta>();
            try
            {
                SqlConnection cn = Conexion.Instancia.Conectar(); //singleton
                cmd = new SqlCommand("spListarDetalleNotaVenta", cn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@idnotaventa", idnotaventa);
                cn.Open();
                SqlDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    entDetNotaVenta dventa = new entDetNotaVenta();
                    EntPlato plato = new EntPlato();


                    dventa.IdNotaventa = Convert.ToInt32(dr["IdNotaVenta"]);
                    //dventa.Id= Convert.ToInt16(dr["Id"]);
                    plato.Id = dr["IdPlato"].ToString();
                    //plato.Nombre = dr["Nombre"].ToString();
                    //plato.Descripcion = dr["Descripcion"].ToString();
                    dventa.IdPlato = plato;                   
                    dventa.Cantidad = Convert.ToInt32(dr["Cantidad"]);
                    dventa.Precio = Convert.ToDecimal(dr["Precio"]);
                    dventa.SubTotal = Convert.ToDecimal(dr["SubTotal"]);

                    lista.Add(dventa);
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
        //BUSCAR

        public EntNotaVenta BuscarNotaVenta(int idventa)
        {
            SqlCommand cmd = null;
            EntNotaVenta nv = new EntNotaVenta();
            entCliente cl = new entCliente();
            try
            {
                SqlConnection cn = Conexion.Instancia.Conectar();
                cmd = new SqlCommand("spBuscarNotaVenta", cn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@idnotaventa", idventa);
                cn.Open();
                SqlDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {

                    cl.Nombre = dr["Nombre"].ToString();
                    cl.Dni = dr["Dni"].ToString();
                    nv.IdCliente = cl;
                    nv.Total= Convert.ToDecimal(dr["Total"]);
                    nv.Estado = Convert.ToBoolean(dr["Estado"]);

                }
            }
            catch (Exception e)
            {

                throw e;
            }
            finally { cmd.Connection.Close(); }
            return nv;
        }

        //INSERTAR
        public Boolean InsertarPago(entPago pl)
        {
            SqlCommand cmd = null;
            Boolean inserta = false;
            try
            {
                SqlConnection cn = Conexion.Instancia.Conectar();
                cmd = new SqlCommand("spInsertarPago", cn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@idmetodopago", pl.IdMetodoPago);
                cmd.Parameters.AddWithValue("@idnotaventa", pl.IdNotaVenta);
                cmd.Parameters.AddWithValue("@fecha", pl.Fecha);
                cmd.Parameters.AddWithValue("@total", pl.Total);
                cmd.Parameters.AddWithValue("@estado", pl.Estado);
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






        #endregion metodos
    }
}
