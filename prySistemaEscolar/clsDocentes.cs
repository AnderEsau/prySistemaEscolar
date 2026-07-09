using MySqlConnector;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace prySistemaEscolar
{
    internal class clsDocentes
    {
        //Atributos
        private int clave;
        private string nombreDocente;
        private string puesto;
        private string correo;
        private string telefono;
        private int idUsuario; //Clave foranea

        //Estos atributos agregamos para registrar el usuario
        private string nombreUsuario;
        private string password;
        private string perfil;

        //Adaptador y tabla virtuales de la clase
        private MySqlDataAdapter consulta;
        private DataTable tabla;
        private MySqlCommand comando;


        //Propiedades
        public int Clave { get => clave; set => clave = value; }
        public string NombreDocente { get => nombreDocente; set => nombreDocente = value; }
        public string Puesto { get => puesto; set => puesto = value; }
        public string Correo { get => correo; set => correo = value; }
        public string Telefono { get => telefono; set => telefono = value; }
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
                    // Unimos las 2 tablas mediante INNER JOIN para mostrar descripciones claras en el Grid

                    string sql = "SELECT D.claveDocente AS Clave, " +
                                 "D.nombreDocente AS Nombre, " +
                                 "D.puesto AS Puesto, " +
                                 "U.vchpassword, " + // < - - AQUI SE AGREGA EL PASSWORD
                                 "U.vchperfil, " +   // < - - AQUI SE AGREGA EL PERFIL
                                 "U.vchnombreUsuario AS Usuario, " +
                                 " D.telefono, D.correo, D.idUsuario " +
                                 "FROM tblDocentes D " +
                                 "INNER JOIN tblUsuarios U ON D.idUsuario = U.intidUsuario;";
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
                    string sql = "SELECT D.claveDocente AS Clave, " +
                                 "D.nombreDocente AS Nombre, " +
                                 "D.puesto AS Puesto, " +
                                 "U.vchpassword, " + // < - - AQUI SE AGREGA EL PASSWORD
                                 "U.vchperfil, " +   // < - - AQUI SE AGREGA EL PERFIL
                                 "U.vchnombreUsuario AS Usuario, " +
                                 " D.telefono, D.correo, D.idUsuario " +
                                 "FROM tblDocentes D " +
                                 "INNER JOIN tblUsuarios U ON D.idUsuario = U.intidUsuario WHERE D.claveDocente LIKE @claveD;";
                    using (var consultar = new MySqlCommand(sql, conexion))
                    {
                        consultar.Parameters.AddWithValue("@claveD", "%" + clave + "%");
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
                                        //1.- Insertamos en la tabla tblusuarios
                                    string sqlInsUser = "INSERT INTO tblUsuarios(vchnombreUsuario, vchpassword, vchperfil,vchestado) " +
                                                        "VALUES(@nomUser, MD5(@pass), @perfil,'Activo'); SELECT LAST_INSERT_ID();";
                                    int nuevoIdUsuario = 0;
                                    using (comando = new MySqlCommand(sqlInsUser, conexion, transaccion))
                                    {
                                        comando.Parameters.AddWithValue("@nomUser", nombreUsuario);
                                        comando.Parameters.AddWithValue("@pass", password);
                                        comando.Parameters.AddWithValue("@perfil", perfil);
                                        nuevoIdUsuario = Convert.ToInt32(comando.ExecuteScalar()); //2.- Recuperamos el id de usuario
                                    }

                                    //PASO 3: Insertar el docente en tbldocentes vinculando el ID de usuario obtenido
                                    string sqlInsAlumno = "INSERT INTO tbldocentes(claveDocente, idUsuario, nombreDocente, puesto, telefono, correo) " +
                                                          "VALUES (@claveD, @idUsuario, @nombre, @puestoD, @tel, @correo);";

                                    using (comando = new MySqlCommand(sqlInsAlumno, conexion, transaccion))
                                    {
                                        comando.Parameters.AddWithValue("@claveD", clave);
                                        comando.Parameters.AddWithValue("@idUsuario", nuevoIdUsuario);
                                        comando.Parameters.AddWithValue("@nombre", nombreDocente);
                                        comando.Parameters.AddWithValue("@puestoD", puesto);
                                        comando.Parameters.AddWithValue("@tel", telefono);
                                        comando.Parameters.AddWithValue("@correo", correo);

                                        comando.ExecuteNonQuery();//Paso 4
                                    }
                                    msg = "El docente y sus credenciales se guardaron correctamente.";
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

                                    // Paso B: Actualizar los datos del expediente en tbldocentes mediante su clave
                                    string sqlUpdAlumno = "UPDATE tbldocentes SET nombreDocente = @nombre,telefono = @tel, correo = @correo, " +
                                                          "puesto = @puestoD WHERE claveDocente = @clave; ";

                                    using (comando = new MySqlCommand(sqlUpdAlumno, conexion, transaccion))
                                    {
                                        comando.Parameters.AddWithValue("@clave", clave);
                                        comando.Parameters.AddWithValue("@nombre", nombreDocente);
                                        comando.Parameters.AddWithValue("@tel", telefono);
                                        comando.Parameters.AddWithValue("@correo", correo);
                                        comando.Parameters.AddWithValue("@puestoD", puesto);
                                        comando.ExecuteNonQuery();
                                    }

                                    msg = "Los datos del Docente se actualizaron correctamente.";
                                    break;


                            }

                            // Si todo se ejectó sin errores en el switch, confirmamos los cambios en la BD
                            //5.- Se valida que todo haya sido correcto
                            transaccion.Commit();//6.- Se confirma el guardado en las dos tablas

                        }
                        catch (Exception ex)
                        {
                            // Si algo falló (en el usuario o en el docente), deshacemos todo para evitar inconsistencias
                            transaccion.Rollback();
                            throw new Exception("Error en la operación. Se cancelaron los cambios: " + ex.Message);
                        }
                    }//Se finaliza la transacción
                }
            }
            catch (Exception ex)
            {
                msg = "Error al guardar o actualizar el registro: " + ex.Message;
            }
            return msg;

        }//Finaliza el método de guardar nuevo o alguna modificación 


    }
}
