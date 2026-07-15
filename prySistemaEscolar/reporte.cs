using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace prySistemaEscolar
{
    public partial class reporte : Form
    {
        clsReporte reportes;//objeto
        DataTable tabla;
        public reporte()
        {
            InitializeComponent();
        }

        private void btnVer_Click(object sender, EventArgs e)
        {

            reportes = new clsReporte();
            dgvReportes.DataSource = null;
            dgvReportes.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            try
            {
                if (rdbOpcion1.Checked == true)
                {
                    //llamar la consulta para cargar en el grid 

                    tabla = reportes.ConsultarAlumnosRiesgo();
                    dgvReportes.DataSource = tabla;
                }
                else if (rdbOpcion2.Checked == true)
                {
                    //llamar la consulta para cargar en el grid 
                    tabla = reportes.consultarAlumnosTutores();
                    dgvReportes.DataSource = tabla;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void btnGenerarPdf_Click(object sender, EventArgs e)
        {
            reportes = new clsReporte();
            if (rdbOpcion1.Checked == true)
            {
                reportes.ExportarPDF(tabla,"reporte de alumnos de todas la carreras con promedio de bachillerato <=8","AlumnosRiesgos.pdf");
            }
            else if (rdbOpcion2.Checked == true)
            {
                reportes.ExportarPDF(tabla, "reporte de alumnos con sus tutores promedio de bachillerato >=9", "AlumnosTutores.pdf");
            }


        }
    }
}
