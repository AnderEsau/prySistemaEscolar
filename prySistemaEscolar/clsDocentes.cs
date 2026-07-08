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

      
    }
}
