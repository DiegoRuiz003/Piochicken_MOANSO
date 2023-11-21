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
     public class DatPlato
     {
        #region sigleton    
        private static readonly DatPlato _instancia = new DatPlato();
        public static DatPlato Instancia
        {
            get
            {
                return DatPlato._instancia;
            }
        }
        #endregion singleton
        #region metodos
        //LISTADO
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
                    EntPlato p = new EntPlato();
                     //---------------------------------------//
                    EntTipoPlato tp = new EntTipoPlato();

                    p.Id = dr["Id"].ToString();
                    p.Nombre = dr["Nombre"].ToString();
                    p.Descripcion = dr["Descripcion"].ToString();
                    //TIPO PLATO
                    tp.Id = Convert.ToInt32(dr["Id"]);
                    //-----------------------------------------""
                    p.IdTipoPlato = tp;
                    p.Precio= Convert.ToDecimal(dr["Precio"]);
                    p.Estado = Convert.ToBoolean(dr["Estado"]);
                    lista.Add(p);
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

        //LISTAR PLATO_TIPO
        public List<EntPlato> ListarPlato_Tipo(int idtipoplato)
        {
            SqlCommand cmd = null;
            List<EntPlato> lista = new List<EntPlato>();
            try
            {
                SqlConnection cn = Conexion.Instancia.Conectar();
                cmd = new SqlCommand("spListarPlato_Tipo", cn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@idtipoplato", idtipoplato);
                cn.Open();
                SqlDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    EntPlato p = new EntPlato();
                    //---------------------------------------//
                    //EntTipoPlato tp = new EntTipoPlato();

                    p.Id = dr["Id"].ToString();
                    p.Nombre = dr["Nombre"].ToString();
                    p.Descripcion = dr["Descripcion"].ToString();
                    //TIPO PLATO
                    //tp.Id = Convert.ToInt32(dr["Id"]);
                    //-----------------------------------------""
                    //p.IdTipoPlato = tp;
                    p.Precio = Convert.ToDecimal(dr["Precio"]);
                    p.Estado = Convert.ToBoolean(dr["Estado"]);
                    lista.Add(p);

                }
            }
            catch (Exception e)
            {

                throw e;
            }
            finally { cmd.Connection.Close(); }
            return lista;
        }

        public EntPlato BuscarPlato(string idplato)
        {
            SqlCommand cmd = null;
            EntPlato p = new EntPlato();
            EntTipoPlato tp = new EntTipoPlato();
            try
            {
                SqlConnection cn = Conexion.Instancia.Conectar();
                cmd = new SqlCommand("spBuscarPlato", cn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@idplato", idplato);
                cn.Open();
                SqlDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    p.Id = dr["Id"].ToString();
                    p.Nombre = dr["Nombre"].ToString();
                    p.Descripcion = dr["Descripcion"].ToString();
                    //TIPO PLATO
                    tp.Id = Convert.ToInt32(dr["IdTipoPlato"]);
                    //-----------------------------------------""
                    p.IdTipoPlato = tp;
                    p.Precio = Convert.ToDecimal(dr["Precio"]);
                    p.Estado = Convert.ToBoolean(dr["Estado"]);

                }
            }
            catch (Exception e)
            {

                throw e;
            }
            finally { cmd.Connection.Close(); }
            return p;
        }


        #endregion metodos

    }
}
