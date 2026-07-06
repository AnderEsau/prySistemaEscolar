using MySqlConnector;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace prySistemaEscolar
{
    internal class clsAlumnos
    {
        private int matricula;
        private string nombreAlumno;
        private string apellidoP;
        private string apellidoM;
        private string direccion;
        private string telefono;
        private string correo;
        private decimal promedioBachillerato;
        private int idTutor; //Foraneo
        private int idCarrera; //Foraneo
        private int idUsuario;
        //Estos atributos agregamos para registrar el usuario
        private string nombreUsuario;
        private string password;
        private string perfil;


        //Adaptador y tabla virtuales de la clase
        private MySqlDataAdapter consulta;
        private DataTable tabla;
        private MySqlCommand comando;


        //Propiedades
        public int Matricula { get => matricula; set => matricula = value; }
        public string NombreAlumno { get => nombreAlumno; set => nombreAlumno = value; }
        public string ApellidoP { get => apellidoP; set => apellidoP = value; }
        public string ApellidoM { get => apellidoM; set => apellidoM = value; }
        public string Direccion { get => direccion; set => direccion = value; }
        public string Telefono { get => telefono; set => telefono = value; }
        public string Correo { get => correo; set => correo = value; }
        public decimal PromedioBachillerato { get => promedioBachillerato; set => promedioBachillerato = value; }
        public int IdTutor { get => idTutor; set => idTutor = value; }
        public int IdCarrera { get => idCarrera; set => idCarrera = value; }
        public int IdUsuario { get => idUsuario; set => idUsuario = value; }
        public string NombreUsuario { get => nombreUsuario; set => nombreUsuario = value; }
        public string Password { get => password; set => password = value; }
        public string Perfil { get => perfil; set => perfil = value; }



        //Metodo para cargar datos en el DataGrid
        public DataTable CargarDataGrid()
        {
            tabla = new DataTable();

            try
            {
                clsConexion conexionBD = new clsConexion();
                using (var conexion = conexionBD.AbrirConexion())
                {
                    // Unimos las 4 tablas mediante INNER JOIN para mostrar descripciones claras en el Grid

                    string sql = "SELECT A.matricula AS Matrícula, " +
                                 "A.nombreAlumno AS Nombre, " +
                                 "A.apellidoP AS 'A. Paterno', " +
                                 "A.apellidoM AS 'A. Materno', " +
                                 "C.nombreCarrera AS Carrera, " +
                                 "T.nombreTutor AS Tutor, " +
                                 "U.vchpassword, " + // < - - AQUI SE AGREGA EL PASSWORD
                                 "U.vchperfil, " +   // < - - AQUI SE AGREGA EL PERFIL
                                 "U.vchnombreUsuario AS Usuario, " +
                                 "A.direccion, A.telefono, A.correo, A.promedioBachillerato, A.idTutor, A.idCarrera, A.idUsuario " +
                                 "FROM tblAlumnos A " +
                                 "INNER JOIN tblCarreras C ON A.idCarrera = C.idCarrera " +
                                 "INNER JOIN tblTutores T ON A.idTutor = T.idTutor " +
                                 "INNER JOIN tblUsuarios U ON A.idUsuario = U.intidUsuario;";
                    using (consulta = new MySqlDataAdapter(sql, conexion))
                    {
                        consulta.Fill(tabla);
                    }//Liberar la consulta

                }//Liberar la conexión externa automáticamente
            }
            catch (Exception ex)
            {
                throw new Exception("Error en la conexión al cargar catálogo de alumnos: " + ex.Message);
            }
            return tabla;
        }

        //Método para obtener todas las carreras disponibles

        //Para el combo de carreras
        public DataTable ObtenerCarreras()
        {
            tabla = new DataTable();
            try
            {
                clsConexion conexionBD = new clsConexion();
                using (var conexion = conexionBD.AbrirConexion())
                {
                    //Valuemember es el idCarrera y DisplayMember es el nombreCarrera
                    string sql = "SELECT idCarrera, nombreCarrera FROM tblCarreras;";
                    using (consulta = new MySqlDataAdapter(sql, conexion))
                    {
                        consulta.Fill(tabla);
                    }
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Error al obtener el catálogo de carreras: " + ex.Message);
            }
            return tabla;
        }

        // Método para el combo de tutores
        public DataTable ObtenerTutores()
        {
            tabla = new DataTable();
            try
            {
                clsConexion conexionBD = new clsConexion();
                using (var conexion = conexionBD.AbrirConexion())
                {
                    //Valuemember es el idCarrera y DisplayMember es el nombreCarrera
                    string sql = "SELECT idTutor, nombreTutor FROM tbltutores;";
                    using (consulta = new MySqlDataAdapter(sql, conexion))
                    {
                        consulta.Fill(tabla);
                    }
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Error al obtener el catálogo de tutores: " + ex.Message);
            }
            return tabla;
        }
        public void LimpiarPanel(Panel panelDestino)
        {
            foreach (Control control in panelDestino.Controls)
            {
                if (control is TextBox)
                {
                    ((TextBox)control).Clear();
                }
                else if (control is ComboBox)
                {
                    ((ComboBox)control).SelectedIndex = 0;
                }
            }
        }
        public DataTable Consultar()
        {
            tabla = new DataTable();
            try
            {
                clsConexion conexionBD = new clsConexion();
                using (var conexion = conexionBD.AbrirConexion())
                {
                    string sql = "SELECT A.matricula AS Matrícula, " +
                                 "A.nombreAlumno AS Nombre, " +
                                 "A.apellidoP AS 'A. Paterno', " +
                                 "A.apellidoM AS 'A. Materno', " +
                                 "C.nombreCarrera AS Carrera, " +
                                 "T.nombreTutor AS Tutor, " +
                                 "U.vchnombreUsuario AS Usuario, " +
                                 "U.vchpassword, " + // < - - AQUI SE AGREGA EL PASSWORD
                                 "U.vchperfil, " +   // < - - AQUI SE AGREGA EL PERFIL
                                 "A.direccion, A.telefono, A.correo, A.promedioBachillerato, A.idTutor, A.idCarrera, A.idUsuario " +
                                 "FROM tblAlumnos A " +
                                 "INNER JOIN tblCarreras C ON A.idCarrera = C.idCarrera " +
                                 "INNER JOIN tblTutores T ON A.idTutor = T.idTutor " +
                                 "INNER JOIN tblUsuarios U ON A.idUsuario = U.intidUsuario WHERE A.matricula LIKE @matricula;";
                    using (var consultar = new MySqlCommand(sql, conexion))
                    {
                        consultar.Parameters.AddWithValue("@matricula", "%" + matricula + "%");
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

        public string GuardarActualizar(int tipoOperacion)
        {
            string msg = "";
            clsConexion conexionBD = new clsConexion();

            try
            {
                using (var conexion = conexionBD.AbrirConexion())
                {
                    using (var transaccion = conexion.BeginTransaction())
                    {
                        try
                        {
                            switch (tipoOperacion)
                            {
                                case 0: //NUEVO E INSERTAR
                                        //Insertamos en la tabla tblusuarios
                                    string sqlInsUser = "INSERT INTO tblUsuarios(vchnombreUsuario, vchpassword, vchperfil,vchestado) " +
                                                        "VALUES(@nomUser, MD5(@pass), @perfil,'Activo'); SELECT LAST_INSERT_ID();";
                                    int nuevoIdUsuario = 0;
                                    using (comando = new MySqlCommand(sqlInsUser, conexion, transaccion))
                                    {
                                        comando.Parameters.AddWithValue("@nomUser", nombreUsuario);
                                        comando.Parameters.AddWithValue("@pass", password);
                                        comando.Parameters.AddWithValue("@perfil", perfil);
                                        nuevoIdUsuario = Convert.ToInt32(comando.ExecuteScalar());
                                    }

                                    //PASO B: Insertar el alumno en tblalumnos vinculando el ID de usuario obtenido
                                    string sqlInsAlumno = "INSERT INTO tblalumnos(matricula, idUsuario, nombreAlumno, apellidoP, apellidoM, direccion, telefono, correo, promedioBachillerato, idTutor, idCarrera) " +
                                                          "VALUES (@matricula, @idUsuario, @nombre, @apP, @apM, @dir, @tel, @correo, @prom, @idTutor, @idCarrera);";

                                    using (comando = new MySqlCommand(sqlInsAlumno, conexion, transaccion))
                                    {
                                        comando.Parameters.AddWithValue("@matricula", matricula);
                                        comando.Parameters.AddWithValue("@idUsuario", nuevoIdUsuario);
                                        comando.Parameters.AddWithValue("@nombre", nombreAlumno);
                                        comando.Parameters.AddWithValue("@apP", apellidoP);
                                        comando.Parameters.AddWithValue("@apM", apellidoM);
                                        comando.Parameters.AddWithValue("@dir", direccion);
                                        comando.Parameters.AddWithValue("@tel", telefono);
                                        comando.Parameters.AddWithValue("@correo", correo);
                                        comando.Parameters.AddWithValue("@prom", promedioBachillerato);
                                        comando.Parameters.AddWithValue("@idTutor", idTutor);
                                        comando.Parameters.AddWithValue("@idCarrera", idCarrera);

                                        comando.ExecuteNonQuery();
                                    }
                                    msg = "El alumno y sus credenciales se guardaron correctamente.";
                                    break;

                                case 1: // ACTUALIZAR
                                        // Paso A: Actualizar la tabla de usuarios utilizando el ID que recuperamos en el clic del Grid
                                    string sqlUpdUser = "UPDATE tblusuarios SET vchnombreUsuario = @nomUser, vchperfil = @perfil " +
                                                            "WHERE intidUsuario = @idUsuario;";

                                    using (comando = new MySqlCommand(sqlUpdUser, conexion, transaccion))
                                    {
                                        comando.Parameters.AddWithValue("@idUsuario", idUsuario);
                                        comando.Parameters.AddWithValue("@nomUser", nombreUsuario);
                                        comando.Parameters.AddWithValue("@perfil", perfil);

                                        comando.ExecuteNonQuery();
                                    }

                                    // Paso B: Actualizar los datos del expediente en tblalumnos mediante su matrícula
                                    string sqlUpdAlumno = "UPDATE tblalumnos SET nombreAlumno = @nombre, apellidoP = @apP, apellidoM = @apM, " +
                                                          "direccion = @dir, telefono = @tel, correo = @correo, promedioBachillerato = @prom, " +
                                                          "idTutor = @idTutor, idCarrera = @idCarrera WHERE matricula = @matricula;";

                                    using (comando = new MySqlCommand(sqlUpdAlumno, conexion, transaccion))
                                    {
                                        comando.Parameters.AddWithValue("@matricula", matricula);
                                        comando.Parameters.AddWithValue("@nombre", nombreAlumno);
                                        comando.Parameters.AddWithValue("@apP", apellidoP);
                                        comando.Parameters.AddWithValue("@apM", apellidoM);
                                        comando.Parameters.AddWithValue("@dir", direccion);
                                        comando.Parameters.AddWithValue("@tel", telefono);
                                        comando.Parameters.AddWithValue("@correo", correo);
                                        comando.Parameters.AddWithValue("@prom", promedioBachillerato);
                                        comando.Parameters.AddWithValue("@idTutor", idTutor);
                                        comando.Parameters.AddWithValue("@idCarrera", idCarrera);
                                        comando.ExecuteNonQuery();
                                    }

                                    msg = "Los datos del alumno se actualizaron correctamente.";
                                    break;


                            }

                            // Si todo se ejectó sin errores en el switch, confirmamos los cambios en la BD
                            transaccion.Commit();

                        }
                        catch (Exception ex)
                        {
                            // Si algo falló (en el usuario o en el alumno), deshacemos todo para evitar inconsistencias
                            transaccion.Rollback();
                            throw new Exception("Error en la operación. Se cancelaron los cambios: " + ex.Message);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                msg = "Error al guardar o actualizar el registro: " + ex.Message;
            }
            return msg;

        }//Finaliza el método de guardar nuevo o alguna modificación


        public string Eliminar()
        {
            string msg = "";
            clsConexion conexionBD = new clsConexion();

            try
            {
                using (var conexion = conexionBD.AbrirConexion())
                {
                    using (var transaccion = conexion.BeginTransaction())
                    {
                        try
                        {
                            //Eliminamos alumnos
                            string sqlDelAlumno = "DELETE FROM tblalumnos WHERE matricula = @matricula;";
                            using (comando = new MySqlCommand(sqlDelAlumno, conexion, transaccion))
                            {
                                comando.Parameters.AddWithValue("@matricula", matricula);
                                comando.ExecuteNonQuery();
                            }
                            //Eliminamos el usuario
                            string sqlDelUsuario = "DELETE FROM tblusuarios WHERE intidUsuario = @idUsuario;";
                            using (comando = new MySqlCommand(sqlDelUsuario, conexion, transaccion))
                            {
                                comando.Parameters.AddWithValue("@idUsuario", idUsuario);
                                comando.ExecuteNonQuery();
                            }
                            //Si en ambas se elimina correctamente
                            transaccion.Commit();
                            msg = "El alumno y sus credenciales de usuario han sido eliminados del sistema.";


                        }
                        catch (Exception ex)
                        {

                            //Si algo falla, deshacemos la operación para no dejar datos huérfanos
                            transaccion.Rollback();
                            throw new Exception("No se pudo completar la eliminación. Cambios revertidos: " + ex.Message);
                        }
                    }
                }

            }
            catch (Exception ex)
            {
                msg = "Error de conexión al eliminar: " + ex.Message;
            }

            return msg;
        }
      

    }

}
