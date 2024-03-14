using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SistemasVentas.Modelos;

namespace SistemasVentas.DAL
{
    public class PersonaDal
    {
        public DataTable ListarPersonasDal()
        {
            string consulta = "select * from persona";
            DataTable Lista = conexion.EjecutarDataTabla(consulta, "tabla");
            return Lista;
        }
        public void InsertarPersonDal(Persona persona)
        {
            string consulta = "insert into persona values('" + persona.Nombre + "'," +
                                                  "'" + persona.Apellido + "'," +
                                                  "'" + persona.Telefono + "'," +
                                                  "'" + persona.Ci + "'," +
                                                  "'" + persona.Correo + "'," +
                                                  "'Activo')";
            conexion.Ejecutar(consulta);
        }
    }
}
