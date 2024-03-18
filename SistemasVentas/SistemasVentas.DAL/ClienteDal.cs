using SistemasVentas.Modelos;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemasVentas.DAL
{
    public class ClienteDal
    {
        public DataTable ListarClienteDal()
        {
            string consulta = "select * from cliente";
            DataTable Lista = conexion.EjecutarDataTabla(consulta, "tabla");
            return Lista;
        }
        public void InsertarClienteDal(Cliente cliente)
        {
            string consulta = "insert into cliente values(" + cliente.IdPersona + "," +
                                                        "'" + cliente.TipoCliente + "'," +
                                                        "'" + cliente.CodigoCliente + "'," +
                                                        "'Activo')";
            conexion.Ejecutar(consulta);
        }
        Cliente c = new Cliente();
        public Cliente ObtenerPersonaId(int id)
        {
            string consulta = "select * from cliente where idcliente=" + id;
            DataTable tabla = conexion.EjecutarDataTabla(consulta, "asdas");

            if (tabla.Rows.Count > 0)
            {
                c.IdPersona = Convert.ToInt32(tabla.Rows[0]["idpersona"]);
                c.TipoCliente = tabla.Rows[0]["nombre"].ToString();
                c.CodigoCliente = tabla.Rows[0]["apellido"].ToString();
                c.Estado = tabla.Rows[0]["telefono"].ToString(); 
            }
            return c;

        }
        public void EditarClienteDal(Cliente c)
        {
            string consulta = "update persona set idpersona=" + c.IdPersona + "," +
                                                  "apellido='" + c.TipoCliente + "'," +
                                                  "telefono='" + c.CodigoCliente + "'" +
                                          "where idpersona=" + c.IdCliente;
            conexion.Ejecutar(consulta);
        }
        public void EliminarClienteDal(int id)
        {
            string consulta = "delete from cliente where idcliente=" + id;
            conexion.Ejecutar(consulta);
        }
    }
}
