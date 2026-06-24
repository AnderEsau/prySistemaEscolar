using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySqlConnector;

namespace prySistemaEscolar
{
    internal class clsTutores
    {
        //Atributos de la clase
        private string nombreTutor;
        private string parentesco;
        private string direccion;
        private string telefono;
        private string correo;

        //Atributo para referencia en update y delete
        private int idTutor;


        //Propiedades
        public string NombreTutor { get => nombreTutor; set => nombreTutor = value; }
        public string Parentesco { get => parentesco; set => parentesco = value; }
        public string Direccion { get => direccion; set => direccion = value; }
        public string Telefono { get => telefono; set => telefono = value; }
        public string Correo { get => correo; set => correo = value; }
        public int IdTutor { get => idTutor; set => idTutor = value; }

        //Usamos un adaptador
        private MySqlDataAdapter consulta;
        //Usamos un command para insertar o actualizar
        private MySqlCommand comando;
        //Usamos una tabla temporal
        private DataTable tabla;




        public DataTable CargarDataGrid()
        {
            tabla = new DataTable();
            try
            {
                clsConexion conexionBD = new clsConexion();
                using (var conexion = conexionBD.AbrirConexion())
                {
                    string sql = "SELECT idTutor AS Clave, nombreTutor AS Tutor, parentesco AS Parentesco, direccion AS Dirección, telefono AS Teléfono, correo AS Correo FROM tblTutores;";
                    using (consulta = new MySqlConnector.MySqlDataAdapter(sql, conexion))
                    {
                        consulta.Fill(tabla);
                    }//Liberar la consulta
                }//Liberar la conexión
            }
            catch (Exception ex)
            {
                throw new Exception("Error en la conexión: " + ex.Message);
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
                    string sql = "SELECT idTutor AS Clave, nombreTutor AS Tutor, parentesco AS Parentesco, direccion AS Dirección, telefono AS Teléfono, correo AS Correo FROM tblTutores WHERE nombreTutor LIKE @tutor;";
                    using (var consultar = new MySqlCommand(sql, conexion))
                    {
                        consultar.Parameters.AddWithValue("@tutor", "%" + nombreTutor + "%");
                        using (consulta = new MySqlDataAdapter(consultar))
                        {
                            consulta.Fill(tabla);
                        }//Libera el adaptador
                    }//Liberar la consulta
                }//Liberar la conexión
            }
            catch (Exception ex)
            {
                throw new Exception("Error en la conexión de la base de datos " + ex.Message);
            }
            return tabla;
        }

        //Metodo para ya sea guardar o actualizar
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
                            string sqlN = "INSERT INTO tblTutores(nombreTutor,parentesco,direccion,telefono,correo) VALUES(@nombreTutor,@parentesco,@direccion,@telefono,@correo);";
                            using (comando = new MySqlCommand(sqlN, conexion))
                            {
                                comando.Parameters.AddWithValue("nombreTutor", nombreTutor);
                                comando.Parameters.AddWithValue("parentesco", parentesco);
                                comando.Parameters.AddWithValue("direccion", direccion);
                                comando.Parameters.AddWithValue("telefono", telefono);
                                comando.Parameters.AddWithValue("correo", correo);

                                int filasAfectadas = comando.ExecuteNonQuery();
                                if (filasAfectadas > 0)
                                {
                                    msg = "El registro se guardo correctamente";
                                }
                                else
                                {
                                    msg = "Error, No se guardaron los datos...";
                                }
                            }//Libera la operacion de la insercion

                            break;
                        case 1://Actualizar old
                            string sqlA = "UPDATE tblTutores C SET C.nombreTutor=@nombreTutor,C.parentesco=@parentesco,C.direccion=@direccion,C.telefono=@telefono,C.correo=@correo WHERE C.idTutor=@idTutor;";
                            using (comando = new MySqlCommand(sqlA, conexion))
                            {
                                comando.Parameters.AddWithValue("idTutor", idTutor);
                                comando.Parameters.AddWithValue("nombreTutor", nombreTutor);
                                comando.Parameters.AddWithValue("parentesco", parentesco);
                                comando.Parameters.AddWithValue("direccion", direccion);
                                comando.Parameters.AddWithValue("telefono", telefono);
                                comando.Parameters.AddWithValue("correo", correo);

                                int filasAfectadas = comando.ExecuteNonQuery();
                                if (filasAfectadas > 0)
                                {
                                    msg = "El registro se guardo correctamente";
                                }
                                else
                                {
                                    msg = "Error, No se guardaron los datos...";
                                }
                                break;
                            }//Libera la operacion de actualizacion
                    }

                }//Libera la conexión

            }
            catch (Exception ex)
            {
                throw new Exception("Error" + ex.Message);
            }
            return msg;
        }

        public string Eliminar()
        {
            string msg = "";
            try
            {
                clsConexion conexionBD = new clsConexion();
                using (var conexion = conexionBD.AbrirConexion())
                {
                    string sql = "DELETE FROM tblTutores C WHERE C.idTutor=@idTutor;";
                    using (comando = new MySqlCommand(sql, conexion))
                    {
                        comando.Parameters.AddWithValue("idTutor", idTutor);
                        int filasAfectadas = comando.ExecuteNonQuery();
                        if (filasAfectadas > 0)
                        {
                            msg = "Datos eliminados correctamente";
                        }
                        else
                        {
                            msg = "Los datos no se pudieron eliminar";
                        }
                    }//Libera la eliminación

                }//Libera la conexión
            }
            catch (Exception ex)
            {
                throw new Exception ("Error" + ex.Message);
            }
            return msg ;

        }
    }
}
