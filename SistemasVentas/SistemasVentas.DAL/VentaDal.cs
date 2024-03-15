using SistemasVentas.Modelos;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemasVentas.DAL
{
    public class VentaDal
    {
        public DataTable ListarVentaDal()
        {
            string consulta = "select * from venta";
            DataTable Lista = conexion.EjecutarDataTabla(consulta, "tabla");
            return Lista;
        }
        public void InsertarVentaDal(Venta venta)
        {
            string consulta = "insert into venta values(" + venta.IdCliente + "," +
                                                        "" + venta.IdVendedor + "," +
                                                        "'" + venta.Fecha.ToString("yyyy-MM-dd HH:mm:ss") + "'," +
                                                        "'" + venta.Total + "'," +
                                                        "'Exitoso')";
            conexion.Ejecutar(consulta);
        }

    }
}
