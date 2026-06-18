using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace prySistemaEscolar
{
    internal class clsPrincipal
    {
        //este es un objeto de tipo Form
        private Form misformsabiertos;

        public void agregarAlContenedor(Form formulario, Panel panel)
        {
            //Verifico si esta abierto
            if (misformsabiertos != null)
            {
                misformsabiertos.Close(); //Cierra la instancia
                misformsabiertos.Dispose();//Libera de memoria
            }

            //Esto es para abrir el formulario en caso de no estar abierto
            misformsabiertos = formulario;
            panel.Controls.Clear();

            formulario.TopLevel = false; //Esto indica que el formulario no es independiente
            formulario.FormBorderStyle = FormBorderStyle.Sizable;
            formulario.Dock = DockStyle.Fill;//Esto indica que el formulario va a ocupar todo el espacio

            panel.Controls.Add(formulario);
            panel.Tag = formulario;
            formulario.Show();
        }
    }
}
