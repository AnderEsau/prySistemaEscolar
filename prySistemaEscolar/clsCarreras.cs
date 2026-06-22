using MySqlConnector;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace prySistemaEscolar
{
    internal class clsCarreras
    {
        //Usamos un adaptador
        private MySqlDataAdapter consulta;
        //Usamos una tabla temporal
        private DataTable tabla;

        //Metodo para cargar datos en el DataGrid
        public DataTable CargarDataGrid()
        {
            tabla = new DataTable();

            clsConexion conexionBD = new clsConexion();
            var conexion = conexionBD.AbrirConexion();
            string sql = "select idCarrera AS Clave,nombreCarrera AS Carrera,descripcion AS Descripción from tblCarreras;";
            consulta = new MySqlDataAdapter(sql, conexion);
            consulta.Fill(tabla);
            return tabla;
        }
    }
}
