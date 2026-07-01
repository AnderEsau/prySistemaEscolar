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

        //Adaptador y tabla virtuales de la clase
        private MySqlDataAdapter consulta;
        private DataTable tabla;

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

                    string sql = "SELECT A.matricula AS Matricula, " +
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


    }
}
