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
        public reporte()
        {
            InitializeComponent();
        }

        private void btnVer_Click(object sender, EventArgs e)
        {
            reportes = new clsReporte();

             if(rdbOpcion1.Checked==true)
             {
                //llamar la consulta para cargar en el grid 
                CargarGridAlumnosRiesgo();
             }
             else if(rdbOpcion2.Checked==true)
             {
                //llamar la consulta para cargar en el grid 
                CargarGridAlumnosTutores();
             }
        }
        public void CargarGridAlumnosRiesgo()
        {
            reportes = new clsReporte();
            dgvReportes.DataSource = null;
            dgvReportes.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            try
            {
                dgvReportes.DataSource = reportes.ConsultarAlumnosRiesgo();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        public void CargarGridAlumnosTutores()
        {
            reportes = new clsReporte();
            dgvReportes.DataSource = null;
            dgvReportes.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            try
            {
                dgvReportes.DataSource = reportes.consultarAlumnosTutores();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
