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
    public partial class frmAlumnos : Form
    {
        clsAlumnos alumnos;
        int idMatricula;
        int idUsuario;

        public frmAlumnos()
        {
            InitializeComponent();
            CargarGrid();
            CargarCombos();
        }

        //Metodo para cargar el DataGridView
        public void CargarGrid()
        {
            alumnos = new clsAlumnos();
            dgvAlumnos.DataSource = null;
            dgvAlumnos.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            try
            {
                //Asignamos la tabla virtual de la clase directamente al control visual
                dgvAlumnos.DataSource = alumnos.CargarDataGrid();
                dgvAlumnos.Columns["Usuario"].Visible = false;
                dgvAlumnos.Columns["vchpassword"].Visible = false;
                dgvAlumnos.Columns["vchperfil"].Visible = false;
                dgvAlumnos.Columns["direccion"].Visible = false;
                dgvAlumnos.Columns["correo"].Visible = false;
                dgvAlumnos.Columns["telefono"].Visible = false;
                dgvAlumnos.Columns["promedioBachillerato"].Visible = false;
                dgvAlumnos.Columns["idTutor"].Visible = false;
                dgvAlumnos.Columns["idCarrera"].Visible = false;
                dgvAlumnos.Columns["idUsuario"].Visible = false;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        public void CargarCombos()
        {
            alumnos = new clsAlumnos();

            try
            {
                DataTable dtCarreras = alumnos.ObtenerCarreras();
                //Creamos la fila del placeholder para la Carrera
                DataRow filaPCarrera = dtCarreras.NewRow();
                filaPCarrera["idCarrera"] = 0;
                filaPCarrera["nombreCarrera"] = "-- Selecciona una Carrera --";
                dtCarreras.Rows.InsertAt(filaPCarrera, 0); //Insertar al inicio de la lista

                //Enlazamos los datos al ComboBox visual
                cmbCarrera.DataSource = dtCarreras;
                cmbCarrera.DisplayMember = "nombreCarrera"; // El texto visible
                cmbCarrera.ValueMember = "idCarrera";       // La llave primaria real
                cmbCarrera.SelectedIndex = 0;               // Forzar a que muestre el placeholder

                DataTable dtTutores = alumnos.ObtenerTutores();
                //Creamos la fila del placeholder para la Carrera
                DataRow filaPTutores = dtTutores.NewRow();
                filaPTutores["idTutor"] = 0;
                filaPTutores["nombreTutor"] = "-- Selecciona un tutor --";
                dtTutores.Rows.InsertAt(filaPTutores, 0); //Insertar al inicio de la lista

                //Enlazamos los datos al ComboBox visual
                cmbTutor.DataSource = dtTutores;
                cmbTutor.DisplayMember = "nombreTutor";    // El texto visible
                cmbTutor.ValueMember = "idTutor";          // La llave primaria real
                cmbTutor.SelectedIndex = 0;                // Forzar a que muestre el placeholder
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al rellenar los catálogos en los menús desplegables: " + ex.Message);
            }
        }


    }
}
