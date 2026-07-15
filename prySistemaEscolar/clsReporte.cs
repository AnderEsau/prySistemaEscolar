using MySqlConnector;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace prySistemaEscolar
{
    internal class clsReporte
    {
        DataTable tabla;
        MySqlDataAdapter consulta;
        public DataTable ConsultarAlumnosRiesgo() 
        {
            tabla = new DataTable();
            try
            {
                clsConexion conexionBD = new clsConexion();
                using(var conexion = conexionBD.AbrirConexion())
                {
                    string sql = "SELEC A.matricula AS Matricula, " +
                                "A.nombreAlumno AS Nombre, " +
                                "A.apellidoP AS 'A. Paterno, " +
                                "A.apellidoM AS 'A. Materno, " +
                                "C.nombreCarrera AS Carrera, " +
                                "A.promedioBachillerato AS Promedio " +
                                "FROM tblAlumnos A " +
                                "INNER JOIN tblcarreras C ON A.idCarrera = C.idCarrera " +
                                "WHERE A.promedioBachillerato <= 8.0;";

                   using(consulta=new MySqlDataAdapter (sql, conexion))//CONDICION
                   {
                        consulta.Fill(tabla);
                   }//se libera la consulta

                }
            }
            catch (Exception ex)
            {
                throw new Exception("Error al consultar alumnos en riesgo:" + ex.Message);
            }
            return tabla;
        }

        public DataTable consultarAlumnosTutores()
        {
            tabla = new DataTable();
            try
            {
                clsConexion conexionBD = new clsConexion();
                using (var conexion = conexionBD.AbrirConexion())
                {
                    string sql = "SELEC A.matricula AS Matricula, " +
                                "A.nombreAlumno AS Nombre, " +
                                "A.apellidoP AS 'A. Paterno, " +
                                "A.apellidoM AS 'A. Materno, " +
                                "A.promedioBachillerato AS Promedio " +
                                "T.nombreTutor"+
                                "FROM tblAlumnos A"+
                                "INNER JOIN tbltutores T ON A.idTutor = T.idTutor"+
                                "WHERE A.promedioBachillerato >= 9.0;";

                    using (consulta = new MySqlDataAdapter(sql, conexion))//CONDICION
                    {
                        consulta.Fill(tabla);
                    }//se libera la consulta

                }
            }
            catch (Exception ex)
            {
                throw new Exception("Error al consultar alumnos y tutores:" + ex.Message);
            }
            return tabla;
        }
    }
}
