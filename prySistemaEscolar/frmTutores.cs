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
    public partial class frmTutores : Form
    {
        clsTutores tutores;
        int idTutor;
        public frmTutores()
        {
            InitializeComponent();
            CargarGrid();
        }

        public void CargarGrid()
        {
            tutores = new clsTutores();
            dgvTutores.DataSource = null;
            dgvTutores.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            try
            {
                dgvTutores.DataSource = tutores.CargarDataGrid();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void txt.Tutor_TextChanged(object sender, EventArgs e)
        {
            tutores = new clsTutores();
            dgvTutores.DataSource = null;
            dgvTutores.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            try
            {
                tutores.NombreTutor = txt.NombreTutor.Text;
                dgvTutores.DataSource = tutores.Consultar();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void dgvTutores_SelectionChanged(object sender, EventArgs e)
        {
            //Este es el campo oculto que me servirá de referencia para actualizar y eliminar
            idTutor = int.Parse(dgvTutores.CurrentRow.Cells[0].Value.ToString());
            //Estos son los campos visibles
            txtNombre.Text = dgvTutores.CurrentRow.Cells[1].Value.ToString();
            txtParentesco.Text = dgvTutores.CurrentRow.Cells[2].Value.ToString();
            txtDireccion.text = dgvTutores.CurrentRow.Cells[3].Value.ToString();
            txtTelefono.Text = dgvTutores.CurrentRow.Cells[4].Value.ToString();
            txtCorreo.Text = dgvTutores.CurrentRow.Cells[5].Value.ToString();
            txtBuscarTutor.text = dgvTutores.CurrentRow.Cells[6].Value.ToString();
        }
        private void btnGuardar_Click(object sender, EventArgs e)
        {

            try
            {
                int tipoOperacion = idTutor == 0 ? 0 : 1;
                tutores.idTutor = idTutor;
                tutores.Nombre = txtNombreTutor.Text;
                tutores.Parentesco = txtParentesco.Text;
                tutores.Direccion = txtDireccion.Text;
                tutores.Telefono = txtTelefono.Text;
                tutores.Correo = txtCorreo.Text;
                tutores.BuscarTutor = txtNombreTutor.Text;
                string msg = "";

                if (tipoOperacion !== 0)
                {
                    var resp = MessageBox.Show("Confirmar que se desea actualizar el dato seleccionado", "ALERTA!!", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                    if (resp == DialogResult.Yes)
                    {
                        msg = tutores.GuardarActualizar(tipoOperacion);
                        MessageBox.Show(msg);
                    }
                }
                else
                {
                    msg = tutores.GuardarActualizar(tipoOperacion);
                    MessageBox.Show(msg);
                }
                CargarGrid();
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void btnNuevo_Click(object sender, EventArgs e)
        {
            idTutor = 0;
            txtTutor.Clear();
            txtParentesco.Clear();
            txtDireccion.Focus();
            txtTelefono.Clear();
            txtCorreo.Clear();
            txtNombreTutor.Focus();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            try
            {
                tutores.idTutor = idTutor;
                var resp = MessageBox.Show("Confirmar que se desea eliminar el dato seleccionado", "ALERTA!!", MessageBoxButtons.YesNo, MessageBoxIcon.Stop);
                if (resp == DialogResult.Yes)
                {
                    string msg = tutores.Eliminar();
                    MessageBox.Show(msg);
                    CargarGrid();
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }

}
