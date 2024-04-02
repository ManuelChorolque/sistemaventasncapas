using SistemasVentas.Modelos;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemasVentas.DAL
{
    public class DetalleVentaDal
    {
        public DataTable ListarDetalleVentaDal()
        {
            string consulta = "select * from detalleventa";
            DataTable Lista = conexion.EjecutarDataTabla(consulta, "tabla");
            return Lista;
        }
        public void InsertarDetalleVentaDal(DetalleVenta detalleVenta)
        {
            string consulta = "insert into detalleVenta values(" + detalleVenta.IdVenta + "," +
                                                        "" + detalleVenta.IdProducto + "," +
                                                        "" + detalleVenta.Cantidad + "," +
                                                        "" + detalleVenta.PrecioVenta + "," +
                                                        "" + detalleVenta.Subtotal + "," +
                                                        "'Exitoso')";
            conexion.Ejecutar(consulta);
        }
        public DetalleVenta ObtenerDetalleVentaId(int id)
        {
            string consulta = "select * from detalleventa where iddetalleventa=" + id;
            DataTable tabla = conexion.EjecutarDataTabla(consulta, "asdas");
            DetalleVenta d = new DetalleVenta();

            if (tabla.Rows.Count > 0)
            {
                d.IdDetalleVenta = Convert.ToInt32(tabla.Rows[0]["iddetalleventa"]);
                d.IdVenta = Convert.ToInt32(tabla.Rows[0]["idventa"]);
                d.IdProducto = Convert.ToInt32(tabla.Rows[0]["idproducto"]);
                d.Cantidad = Convert.ToInt32(tabla.Rows[0]["cantidad"]);
                d.PrecioVenta = Convert.ToDecimal(tabla.Rows[0]["precioventa"]);
                d.Subtotal = Convert.ToDecimal(tabla.Rows[0]["subtotal"]);
                d.Estado = tabla.Rows[0]["estado"].ToString();
            }
            return d;

        }
        public void EditarDetalleVentaDal(DetalleVenta d)
        {
            string consulta = "update detalleventa set idventa=" + d.IdVenta + "," +
                                                  "idproducto=" + d.IdProducto + "," +
                                                  "cantidad=" + d.Cantidad + "," +
                                                  "precioventa=" + d.PrecioVenta + "," +
                                                  "subtotal=" + d.Subtotal + "" +
                                              "where iddetalleventa=" + d.IdDetalleVenta;
            conexion.Ejecutar(consulta);
        }
        public void EliminarDetalleVentaDal(int id)
        {
            string consulta = "delete from detalleventa where iddetalleventa=" + id;
            conexion.Ejecutar(consulta);
        }
        public DataTable DetalleVentaDatosDal()
        {
            string consulta = "SELECT DETALLEVENTA.IDDETALLEVENTA, VENTA.FECHA FECHA_VENTA, PRODUCTO.NOMBRE NOMBRE_PRODUCTO, PRODUCTO.CODIGOBARRA, DETALLEVENTA.CANTIDAD, DETALLEVENTA.PRECIOVENTA, DETALLEVENTA.SUBTOTAL, DETALLEVENTA.ESTADO " +
                              "FROM DETALLEVENTA INNER JOIN VENTA ON DETALLEVENTA.IDVENTA = VENTA.IDVENTA INNER JOIN " +
                              "PRODUCTO ON DETALLEVENTA.IDPRODUCTO = PRODUCTO.IDPRODUCTO";
            return conexion.EjecutarDataTabla(consulta, "fsdf");
        }
    }
}
