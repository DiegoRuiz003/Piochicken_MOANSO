using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaEntidad;
using System.Data.SqlClient;
using System.Data;
using System.Windows.Forms;

namespace CapaDatos
{
    public class DatNotaVenta
    {
        #region sigleton    
        private static readonly DatNotaVenta _instancia = new DatNotaVenta();
        public static DatNotaVenta Instancia
        {
            get
            {
                return DatNotaVenta._instancia;
            }
        }
        #endregion singleton
        #region metodos
        //LISTADO
        public List<EntNotaVenta> ListarNotaVenta()
        {
            SqlCommand cmd = null;
            List<EntNotaVenta> lista = new List<EntNotaVenta>();
            try
            {
                SqlConnection cn = Conexion.Instancia.Conectar(); //singleton
                cmd = new SqlCommand("spListarNotaVenta", cn);
                cmd.CommandType = CommandType.StoredProcedure;
                cn.Open();
                SqlDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    EntNotaVenta nv = new EntNotaVenta();
                    //---------------------------------------//
                    entCliente cl = new entCliente();

                    nv.Id = Convert.ToInt32(dr["Id"]);
                    //-------------------CLIENTE----------------//
                    cl.Id= Convert.ToInt32(dr["IdCliente"]);
                    nv.IdCliente=cl;
                    //------------------------------------------//
                    nv.Fecha = Convert.ToDateTime(dr["Fecha"]);
                    nv.Total= Convert.ToDecimal(dr["Total"]);
                    nv.Estado = Convert.ToBoolean(dr["Estado"]);
                    lista.Add(nv);
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
        public int InsertarNotaVenta(EntNotaVenta nv)
        {

            SqlCommand cmd = null;
            int idnotaventa = 0;
            //Boolean inserta = false;
            try
            {
                SqlConnection cn = Conexion.Instancia.Conectar();
                cmd = new SqlCommand("spInsertarNotaVenta", cn);
                cmd.CommandType = CommandType.StoredProcedure;

                //////cmd.Parameters.AddWithValue("@prmintidPedido", c.IdPedido);


                cmd.Parameters.AddWithValue("@idcliente", nv.IdCliente.Id);
                cmd.Parameters.AddWithValue("@fecha", nv.Fecha);
                cmd.Parameters.AddWithValue("@total", nv.Total);
                cmd.Parameters.AddWithValue("@estado", nv.Estado);

                SqlParameter m = new SqlParameter("@retorno", DbType.Int32);
                m.Direction = ParameterDirection.ReturnValue;
                cmd.Parameters.Add(m);
                cn.Open();
                cmd.ExecuteNonQuery();
                idnotaventa = Convert.ToInt16(cmd.Parameters["@retorno"].Value);
                return idnotaventa;

            }
            catch (Exception e)
            {
                throw e;
            }
            finally { cmd.Connection.Close(); }

        }

        //DETALLE_VENTA
        public Boolean InsertarDetNotaVenta(entDetNotaVenta dnv)
        {
            SqlCommand cmd = null;
            Boolean inserta = false;
            try
            {
                SqlConnection cn = Conexion.Instancia.Conectar();
                cmd = new SqlCommand("spInsertarDetNotaVenta", cn);
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.AddWithValue("@idnotaventa", dnv.IdNotaventa);
                cmd.Parameters.AddWithValue("@idplato", dnv.IdPlato.Id);
                cmd.Parameters.AddWithValue("@cantidad", dnv.Cantidad);
                cmd.Parameters.AddWithValue("@precio", dnv.Precio);
                cmd.Parameters.AddWithValue("@subtotal", dnv.SubTotal   );
                //cmd.Parameters.AddWithValue("@igv", dPed. );

                cn.Open();
                int i = cmd.ExecuteNonQuery();
                if (i > 0)
                { inserta = true; }
            }
            catch (Exception e)
            {
                MessageBox.Show("EXITOS" );
                //throw e;
            }
            finally { cmd.Connection.Close(); }
            return inserta;
        }

        #endregion metodos
    }
}
