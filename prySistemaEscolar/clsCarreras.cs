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
        private string nombreCarrera;
        private string descripcion;
        private int idCarrera;//Este atributo es para referencia en update y delete
        //usamos un adaptador
        private MySqlDataAdapter consulta;
        //Usamos un command para insertar o actualizar
        private MySqlCommand comando;
        //Usamos una tabla temporal
        private DataTable tabla;  


        //propiedad para el atributo nombreCarrera  
        public string NombreCarrera { get => nombreCarrera; set => nombreCarrera = value; }
        public string Descripcion { get => descripcion; set => descripcion = value; }
        public int IdCarrera { get => idCarrera; set => idCarrera = value; }

        //Metodo para cargar datos en el DataGrid
        public DataTable CargarDataGrid()
        {
            tabla = new DataTable();

            try
            {
                clsConexion conexionBD = new clsConexion();
                using (var conexion = conexionBD.AbrirConexion())
                {
                    string sql = "select idCarrera AS Clave,nombreCarrera AS Carrera,descripcion AS Descripción from tblCarreras;";
                    using (consulta = new MySqlDataAdapter(sql, conexion))
                    {
                        consulta.Fill(tabla);
                    }//Liberar la consulta

                }//Liberar la conexión 
            }
            catch (Exception ex)
            {
                throw new Exception("Error en la conexion " + ex.Message);
            }
            return tabla;


        }

        //Metodo para consultar por coincidencia 
        public DataTable Consultar()
        {
            tabla = new DataTable();
            try
            {
                clsConexion conexionBD = new clsConexion();
                using (var conexion = conexionBD.AbrirConexion())
                {
                    string sql = "SELECT idCarrera AS Clave,nombreCarrera AS Carrera,descripcion AS Descripción FROM tblCarreras WHERE nombreCarrera LIKE @carrera;";
                    using (var consultar = new MySqlCommand(sql, conexion))
                    {
                        consultar.Parameters.AddWithValue("@carrera", "%" + nombreCarrera + "%");
                        using (consulta = new MySqlDataAdapter(consultar))
                        {
                            consulta.Fill(tabla);
                        }//Libera el adaptador
                    }//Libera la consulta
                }//Libera la conexión
            }
            catch (Exception ex)
            {
                throw new Exception("Error en la conexión de la base de datos " + ex.Message);
            }
            return tabla;
        }
        //metodo para consultar
        public string GuardarActualizar(int tipoOperacion)
        {
            string msg = "";
            try
            {
                clsConexion conexionBD = new clsConexion();
                using (var conexion = conexionBD.AbrirConexion())
                {
                    switch (tipoOperacion)
                    {
                        case 0://Insertar new
                            string sqlN = "INSERT INTO tblCarreras(nombreCarrera,descripcion) VALUES(@nombreCarrera,@descripcion);";
                            using (comando = new MySqlCommand(sqlN, conexion))
                            {
                                comando.Parameters.AddWithValue("nombreCarrera", nombreCarrera);
                                comando.Parameters.AddWithValue("descripcion", descripcion);

                                int filasAfectadas = comando.ExecuteNonQuery();
                                if (filasAfectadas > 0)
                                {
                                    msg = "EL registro se guardo correctamente";
                                }
                                else
                                {
                                    msg = "Error, No se guardaron los datos...";
                                }
                            }//Libera la operacion de inserción
                            break;
                        case 1://Actualizar old
                            string sqlA = "UPDATE tblCarreras C SET C.nombreCarrera=@nombreCarrera,C.descripcion=@descripcion WHERE C.idCarrera=@idCarrera;";
                            using (comando = new MySqlCommand(sqlA, conexion))
                            {
                                comando.Parameters.AddWithValue("idCarrera", idCarrera);
                                comando.Parameters.AddWithValue("nombreCarrera", nombreCarrera);
                                comando.Parameters.AddWithValue("descripcion", descripcion);

                                int filasAfectadas = comando.ExecuteNonQuery();
                                if (filasAfectadas > 0)
                                {
                                    msg = "EL registro se guardo correctamente";
                                }
                                else
                                {
                                    msg = "Error, No se guardaron los datos...";
                                }
                            }//Libera la operacion de actualización
                            break;
                    }
                }//Libera la conexión
            }
            catch (Exception ex)
            {
                throw new Exception("Error" + ex.Message);
            }
            return msg;
        }
    }
}      
