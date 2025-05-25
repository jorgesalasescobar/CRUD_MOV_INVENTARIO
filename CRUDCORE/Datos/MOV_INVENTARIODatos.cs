using CRUD_MOV_INVENTARIO.Models;
using CRUDCORE.Datos;
using System.Data;
using System.Data.SqlClient;

namespace CRUD_MOV_INVENTARIO.Datos
{
    public class MOV_INVENTARIODatos
    {
        public List<MOV_INVENTARIOModel> Listar()
        {
            var oLista = new List<MOV_INVENTARIOModel>();

            var cn = new Conexion();

            using (var conexion = new SqlConnection(cn.getCadenaSQL()))
            {

                conexion.Open();
                SqlCommand cmd = new SqlCommand("usp_MovConsultar", conexion);

                cmd.CommandType = CommandType.StoredProcedure;

                using (var dr = cmd.ExecuteReader())
                {
                    while (dr.Read())
                    {
                        oLista.Add(new MOV_INVENTARIOModel()
                        {
                            COD_CIA = dr["COD_CIA"].ToString(),
                            COMPANIA_VENTA_3 = dr["COMPANIA_VENTA_3"].ToString(),
                            ALMACEN_VENTA = dr["ALMACEN_VENTA"].ToString(),
                            TIPO_MOVIMIENTO = dr["TIPO_MOVIMIENTO"].ToString(),
                            TIPO_DOCUMENTO = dr["TIPO_DOCUMENTO"].ToString(),
                            NRO_DOCUMENTO = dr["NRO_DOCUMENTO"].ToString(),
                            COD_ITEM_2 = dr["COD_ITEM_2"].ToString(),
                            PROVEEDOR = dr["PROVEEDOR"].ToString(),
                            ALMACEN_DESTINO = dr["ALMACEN_DESTINO"].ToString(),
                            CANTIDAD = Convert.ToInt32(dr["CANTIDAD"].ToString()),
                            DOC_REF_1 = dr["DOC_REF_1"].ToString(),
                            DOC_REF_2 = dr["DOC_REF_2"].ToString(),
                            DOC_REF_3 = dr["DOC_REF_3"].ToString(),
                            DOC_REF_4 = dr["DOC_REF_4"].ToString(),
                            DOC_REF_5 = dr["DOC_REF_5"].ToString()
                        });
                    }
                }
            }
            return oLista;
        }
        public bool Guardar(MOV_INVENTARIOModel oMOV_INVENTARIO)
        {
            bool rpta;

            try
            {
                var cn = new Conexion();
                using (var conexion = new SqlConnection(cn.getCadenaSQL()))
                {
                    conexion.Open();
                    SqlCommand cmd = new SqlCommand("usp_MovRegistrar", conexion);
                    cmd.Parameters.AddWithValue("COD_CIA", oMOV_INVENTARIO.COD_CIA);
                    cmd.Parameters.AddWithValue("COMPANIA_VENTA_3", oMOV_INVENTARIO.COMPANIA_VENTA_3);
                    cmd.Parameters.AddWithValue("ALMACEN_VENTA", oMOV_INVENTARIO.ALMACEN_VENTA);
                    cmd.Parameters.AddWithValue("TIPO_MOVIMIENTO", oMOV_INVENTARIO.TIPO_MOVIMIENTO);
                    cmd.Parameters.AddWithValue("TIPO_DOCUMENTO", oMOV_INVENTARIO.TIPO_DOCUMENTO);
                    cmd.Parameters.AddWithValue("NRO_DOCUMENTO", oMOV_INVENTARIO.NRO_DOCUMENTO);
                    cmd.Parameters.AddWithValue("COD_ITEM_2", oMOV_INVENTARIO.COD_ITEM_2);
                    cmd.Parameters.AddWithValue("PROVEEDOR", oMOV_INVENTARIO.PROVEEDOR);
                    cmd.Parameters.AddWithValue("ALMACEN_DESTINO", oMOV_INVENTARIO.ALMACEN_DESTINO);
                    cmd.Parameters.AddWithValue("CANTIDAD", oMOV_INVENTARIO.CANTIDAD);
                    cmd.Parameters.AddWithValue("DOC_REF_1", oMOV_INVENTARIO.DOC_REF_1);
                    cmd.Parameters.AddWithValue("DOC_REF_2", oMOV_INVENTARIO.DOC_REF_2);
                    cmd.Parameters.AddWithValue("DOC_REF_3", oMOV_INVENTARIO.DOC_REF_3);
                    cmd.Parameters.AddWithValue("DOC_REF_4", oMOV_INVENTARIO.DOC_REF_4);
                    cmd.Parameters.AddWithValue("DOC_REF_5", oMOV_INVENTARIO.DOC_REF_5);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.ExecuteNonQuery();
                }
                rpta = true;

            }
            catch (Exception e)
            {
                string error = e.Message;
                rpta = false;
            }

            return rpta;
        }

        public bool Editar(MOV_INVENTARIOModel oMOV_INVENTARIO)
        {
            bool rpta;

            try
            {
                var cn = new Conexion();
                using (var conexion = new SqlConnection(cn.getCadenaSQL()))
                {
                    conexion.Open();
                    SqlCommand cmd = new SqlCommand("usp_MovEditar", conexion);
                    cmd.Parameters.AddWithValue("COD_CIA", oMOV_INVENTARIO.COD_CIA);
                    cmd.Parameters.AddWithValue("COMPANIA_VENTA_3", oMOV_INVENTARIO.COMPANIA_VENTA_3);
                    cmd.Parameters.AddWithValue("ALMACEN_VENTA", oMOV_INVENTARIO.ALMACEN_VENTA);
                    cmd.Parameters.AddWithValue("TIPO_MOVIMIENTO", oMOV_INVENTARIO.TIPO_MOVIMIENTO);
                    cmd.Parameters.AddWithValue("TIPO_DOCUMENTO", oMOV_INVENTARIO.TIPO_DOCUMENTO);
                    cmd.Parameters.AddWithValue("NRO_DOCUMENTO", oMOV_INVENTARIO.NRO_DOCUMENTO);
                    cmd.Parameters.AddWithValue("COD_ITEM_2", oMOV_INVENTARIO.COD_ITEM_2);
                    cmd.Parameters.AddWithValue("PROVEEDOR", oMOV_INVENTARIO.PROVEEDOR);
                    cmd.Parameters.AddWithValue("ALMACEN_DESTINO", oMOV_INVENTARIO.ALMACEN_DESTINO);
                    cmd.Parameters.AddWithValue("CANTIDAD", oMOV_INVENTARIO.CANTIDAD);
                    cmd.Parameters.AddWithValue("DOC_REF_1", oMOV_INVENTARIO.DOC_REF_1);
                    cmd.Parameters.AddWithValue("DOC_REF_2", oMOV_INVENTARIO.DOC_REF_2);
                    cmd.Parameters.AddWithValue("DOC_REF_3", oMOV_INVENTARIO.DOC_REF_3);
                    cmd.Parameters.AddWithValue("DOC_REF_4", oMOV_INVENTARIO.DOC_REF_4);
                    cmd.Parameters.AddWithValue("DOC_REF_5", oMOV_INVENTARIO.DOC_REF_5);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.ExecuteNonQuery();
                }
                rpta = true;

            }
            catch (Exception e)
            {
                string error = e.Message;
                rpta = false;
            }

            return rpta;
        }

        public bool Eliminar(MOV_INVENTARIOModel oMOV_INVENTARIO)
        {
            bool rpta;

            try
            {
                var cn = new Conexion();
                using (var conexion = new SqlConnection(cn.getCadenaSQL()))
                {
                    conexion.Open();
                    SqlCommand cmd = new SqlCommand("usp_MovEliminar", conexion);
                    cmd.Parameters.AddWithValue("COD_CIA", oMOV_INVENTARIO.COD_CIA);
                    cmd.Parameters.AddWithValue("COMPANIA_VENTA_3", oMOV_INVENTARIO.COMPANIA_VENTA_3);
                    cmd.Parameters.AddWithValue("ALMACEN_VENTA", oMOV_INVENTARIO.ALMACEN_VENTA);
                    cmd.Parameters.AddWithValue("TIPO_MOVIMIENTO", oMOV_INVENTARIO.TIPO_MOVIMIENTO);
                    cmd.Parameters.AddWithValue("TIPO_DOCUMENTO", oMOV_INVENTARIO.TIPO_DOCUMENTO);
                    cmd.Parameters.AddWithValue("NRO_DOCUMENTO", oMOV_INVENTARIO.NRO_DOCUMENTO);
                    cmd.Parameters.AddWithValue("COD_ITEM_2", oMOV_INVENTARIO.COD_ITEM_2);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.ExecuteNonQuery();
                }
                rpta = true;

            }
            catch (Exception e)
            {
                string error = e.Message;
                rpta = false;
            }

            return rpta;
        }

    }
}
