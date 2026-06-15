using MySqlConnector;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace prySistemaEscolar
{
    internal class clsLogin
    {
        private string usuario;
        private string password;

        public string Usuario { get => usuario; set => usuario = value; }
        public string Password { get => password; set => password = value; }

        //Atributo estático
        private static string perfil;
        private static bool esAdministrador;
        private static bool esDocente;

        //Propiedad estático
        public static bool EsAdministrador { get => esAdministrador; }
        public static bool EsDocente { get => esDocente; }

        public void AsignarPermisos()
        {
            switch (perfil)
            {
                case "Administrador":
                    esAdministrador = true;
                    esDocente = false;
                    break;
                case "Docente":
                    esAdministrador = false;
                    esDocente = true;
                    break;
                default:
                    esAdministrador = false;
                    esDocente = false;
                    break;

            }
        }

        public bool ValidarAcceso()
        {
            try
            {
                clsConexion conexionBD = new clsConexion();
                using (var conexion = conexionBD.AbrirConexion())
                {
                    string sql = "SELECT perfil FROM tblUsuarios " +
                                 "WHERE nombreUsuario = @usuario AND password = @password;";

                    using (var consulta = new MySqlCommand(sql, conexion))
                    {
                        consulta.Parameters.AddWithValue("@usuario", usuario);
                        consulta.Parameters.AddWithValue("@password", password);

                        using (var resultado = consulta.ExecuteReader())
                        {
                            if (resultado.Read())
                            {
                                perfil = resultado.GetString("perfil");
                                AsignarPermisos();
                                if (!esAdministrador && !esDocente)
                                {
                                    throw new Exception($"El perfil{perfil} no tiene permisos para acceder");
                                }
                                MessageBox.Show("Tu perfil es: " + perfil, "Sistema");
                                return true;
                            }
                            else
                            {
                                throw new Exception("Usuario o contraseña incorrectos.");
                            }
                        }// Liberar MySqlDateReader
                    }// Liberar MySqlCommand
                }// liberar MySqlConnection a través de tu clase 

            }
            catch (Exception ex)
            {
                //Si ocurre un error, lo relanzamos para que lo capture el formulario
                throw new Exception(ex.Message, ex);
            }
        }


    }
}
