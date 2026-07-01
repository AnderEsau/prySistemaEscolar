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

        private void dgvAlumnos_SelectionChanged(object sender, EventArgs e)
        {
            try
            {
                //Esto es para poder saber si es nuevo o vamos a actualizar
                idMatricula = int.Parse(dgvAlumnos.CurrentRow.Cells["Matrícula"].Value.ToString());
                idUsuario = int.Parse(dgvAlumnos.CurrentRow.Cells["idUsuario"].Value.ToString());

                //Esto es para la tabla alumnos
                txtMatricula.Text = idMatricula.ToString();
                txtNombre.Text = dgvAlumnos.CurrentRow.Cells["Nombre"].Value.ToString();
                txtAPaterno.Text = dgvAlumnos.CurrentRow.Cells["A. Paterno"].Value.ToString();
                txtAMaterno.Text = dgvAlumnos.CurrentRow.Cells["A. Materno"].Value.ToString();
                txtDireccion.Text = dgvAlumnos.CurrentRow.Cells["direccion"].Value.ToString();
                txtTelefono.Text = dgvAlumnos.CurrentRow.Cells["telefono"].Value.ToString();
                txtCorreo.Text = dgvAlumnos.CurrentRow.Cells["correo"].Value.ToString();
                txtPromedioBachiller.Text = dgvAlumnos.CurrentRow.Cells["promedioBachillerato"].Value.ToString();

                //Esto es para la tabla Usuarios
                txtUsuario.Text = dgvAlumnos.CurrentRow.Cells["Usuario"].Value.ToString();
                txtPassword.Text = dgvAlumnos.CurrentRow.Cells["vchpassword"].Value.ToString();
                cmbPerfil.Text = dgvAlumnos.CurrentRow.Cells["vchperfil"].Value.ToString();

                //Usar selected value para apuntar al dato preciso de cada registro
                cmbCarrera.SelectedValue = int.Parse(dgvAlumnos.CurrentRow.Cells["idCarrera"].Value.ToString());
                cmbTutor.SelectedValue = int.Parse(dgvAlumnos.CurrentRow.Cells["idTutor"].Value.ToString());
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al mapear los datos seleccionados: " + ex.Message);
            }
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            idMatricula = 0;
            idUsuario = 0;
            alumnos.LimpiarPanel(pnlAlumno);
            alumnos.LimpiarPanel(pnlUsuario);
            txtMatricula.Focus();
        }

        private void txtNombreAlumno_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtMatriculaAlumno.Text))
            {
                CargarGrid();
                return;
            }
            alumnos = new clsAlumnos();
            dgvAlumnos.DataSource = null;
            dgvAlumnos.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            try
            {
                alumnos.Matricula =int.Parse(txtMatriculaAlumno.Text);
                dgvAlumnos.DataSource = alumnos.Consultar();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Requiere asignar datos ",ex.Message);
            }
        }
    }
}
