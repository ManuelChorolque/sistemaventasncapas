﻿using SistemasVentas.Modelos;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemasVentas.DAL
{
    public class DetalleIngDal
    {
        public DataTable ListarDetalleIngDal()
        {
            string consulta = "select * from detalleing";
            DataTable Lista = conexion.EjecutarDataTabla(consulta, "tabla");
            return Lista;
        }
        public void InsertarDetalleIngDal(DetalleIng detalleIng)
        {
            string consulta = "insert into detalleing values(" + detalleIng.IdIngreso + "," +
                                                        "" + detalleIng.IdProducto + "," +
                                                        "'" + detalleIng.FechaVenc.ToString("yyyy-MM-dd HH:mm:ss") + "'," +
                                                        "" + detalleIng.Cantidad + "," +
                                                        "" + detalleIng.PrecioCosto + "," +
                                                        "" + detalleIng.PrecioVenta + "," +
                                                        "" + detalleIng.Subtotal + "," +
                                                        "'Exitoso')";
            conexion.Ejecutar(consulta);
        }
        public DetalleIng ObtenerDetalleIngId(int id)
        {
            string consulta = "select * from detalleing where iddetalleing=" + id;
            DataTable tabla = conexion.EjecutarDataTabla(consulta, "asdas");
            DetalleIng d = new DetalleIng();

            if (tabla.Rows.Count > 0)
            {
                d.IdDetalleIng = Convert.ToInt32(tabla.Rows[0]["iddetalleing"]);
                d.IdProducto = Convert.ToInt32(tabla.Rows[0]["idproducto"]);
                d.IdIngreso = Convert.ToInt32(tabla.Rows[0]["idingreso"]);
                d.FechaVenc = Convert.ToDateTime(tabla.Rows[0]["fechavenc"]);
                d.Cantidad = Convert.ToInt32(tabla.Rows[0]["cantidad"]);
                d.PrecioCosto = Convert.ToDecimal(tabla.Rows[0]["preciocosto"]);
                d.PrecioVenta = Convert.ToDecimal(tabla.Rows[0]["precioventa"]);
                d.Subtotal = Convert.ToDecimal(tabla.Rows[0]["subtotal"]);
                d.Estado = tabla.Rows[0]["estado"].ToString();
            }
            return d;

        }
        public void EditarDetalleIngDal(DetalleIng d)
        {
            string consulta = "update detalleing set idingreso=" + d.IdIngreso + "," +
                                                  "idproducto=" + d.IdProducto + "," +
                                                  "fechavenc='" + d.FechaVenc.ToString("yyyy-MM-dd HH:mm:ss") + "'," +
                                                  "cantidad=" + d.Cantidad + "," +
                                                  "preciocosto=" + d.PrecioCosto + "," +
                                                  "precioventa=" + d.PrecioVenta + "," +
                                                  "subtotal=" + d.Subtotal + "" +
                                              "where iddetalleing=" + d.IdDetalleIng;
            conexion.Ejecutar(consulta);
        }
        public void EliminarDetalleIngDal(int id)
        {
            string consulta = "delete from detalleing where iddetalleing=" + id;
            conexion.Ejecutar(consulta);
        }
        public DataTable DetalleIngDatosDal()
        {
            string consulta = "SELECT DETALLEING.IDDETALLEING, PRODUCTO.NOMBRE PRODUCTO, INGRESO.FECHAINGRESO, DETALLEING.FECHAVENC, INGRESO.TOTAL, DETALLEING.CANTIDAD, DETALLEING.PRECIOCOSTO, " +
                              "DETALLEING.PRECIOVENTA, DETALLEING.SUBTOTAL, DETALLEING.ESTADO " +
                              "FROM DETALLEING INNER JOIN PRODUCTO ON DETALLEING.IDPRODUCTO = PRODUCTO.IDPRODUCTO INNER JOIN " +
                              "INGRESO ON DETALLEING.IDINGRESO = INGRESO.IDINGRESO";
            return conexion.EjecutarDataTabla(consulta, "fsdf");
        }
    }
}
