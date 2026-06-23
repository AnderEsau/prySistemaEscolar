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
    public partial class frmCarreras : Form
    {
        clsCarreras carreras;
        int idCarrera;
        public frmCarreras()
        {
            InitializeComponent();
            CargarGrid();
        }
        public void CargarGrid()
        {
            carreras = new clsCarreras();
            dgvCarreras.DataSource = null;
            dgvCarreras.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            try
            {
                dgvCarreras.DataSource = carreras.CargarDataGrid();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void txtNombreCarrera_TextChanged(object sender, EventArgs e)
        {
            carreras = new clsCarreras();
            dgvCarreras.DataSource = null;
            dgvCarreras.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            try
            {
                carreras.NombreCarrera = txtNombreCarrera.Text;
                dgvCarreras.DataSource = carreras.Consultar();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void dgvCarreras_SelectionChanged(object sender, EventArgs e)
        {
            //Este es el campo oculto que me servirá de referencia para actualizar y eliminar
            idCarrera = int.Parse(dgvCarreras.CurrentRow.Cells[0].Value.ToString());
            //Estos son los campos visibles
            txtNombre.Text = dgvCarreras.CurrentRow.Cells[1].Value.ToString();
            txtDescripcion.Text = dgvCarreras.CurrentRow.Cells[2].Value.ToString();

        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            try
            {

                int tipoOperacion = idCarrera == 0 ? 0 : 1;
                carreras.IdCarrera = idCarrera;
                carreras.NombreCarrera = txtNombre.Text;
                carreras.Descripcion = txtDescripcion.Text;
                string msg = "";
                if (tipoOperacion != 0)
                {
                    var resp = MessageBox.Show("Confirmar que se desea actualizar el dato seleccionado", "ALERTA!!", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                    if (resp == DialogResult.Yes)
                    {
                        msg = carreras.GuardarActualizar(tipoOperacion);
                        MessageBox.Show(msg);
                    }
                }
                else
                {
                    msg = carreras.GuardarActualizar(tipoOperacion);
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
            idCarrera = 0;
            txtNombre.Clear();
            txtDescripcion.Clear();
            txtNombre.Focus();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            try
            {
                carreras.IdCarrera = idCarrera;
                var resp = MessageBox.Show("Confirmar que se desea eliminar el dato seleccionado", "ALERTA!!", MessageBoxButtons.YesNo, MessageBoxIcon.Stop);
                if (resp == DialogResult.Yes)
                {
                    string msg = carreras.Eliminar();
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
