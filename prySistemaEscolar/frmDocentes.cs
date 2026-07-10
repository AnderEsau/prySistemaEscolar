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
    public partial class frmDocentes : Form
    {
        clsDocentes docentes;
        int idClave;
        int idUsuario;

        public frmDocentes()
        {
            InitializeComponent();
            CargarGrid();
        }

        //Metodo para cargar el DataGridView
        public void CargarGrid()
        {
            docentes = new clsDocentes();
            dgvDocentes.DataSource = null;
            dgvDocentes.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            try
            {
                //Asignamos la tabla virtual de la clase directamente al control visual
                dgvDocentes.DataSource = docentes.CargarDataGrid();
                dgvDocentes.Columns["Usuario"].Visible = false;
                dgvDocentes.Columns["vchpassword"].Visible = false;
                dgvDocentes.Columns["vchperfil"].Visible = false;
                dgvDocentes.Columns["idUsuario"].Visible = false;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }


        private void txtClaveDocente_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtClaveDocente.Text))
            {
                CargarGrid();
                return;
            }
            docentes = new clsDocentes();
            dgvDocentes.DataSource = null;
            dgvDocentes.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            try
            {
                docentes.Clave = int.Parse(txtClaveDocente.Text);
                dgvDocentes.DataSource = docentes.Consultar();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Requiere asignar datos ", ex.Message);
            }
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            try
            {
                // Determinamos el tipo de operación
                int tipoOperacion = idClave == 0 ? 0 : 1;

                docentes = new clsDocentes();

                // 1. Llenamos las propiedades del bloque docente
                docentes.Clave = int.Parse(txtClave.Text);
                docentes.NombreDocente = string.IsNullOrEmpty(txtNombre.Text) ? null : txtNombre.Text;
                docentes.Puesto = string.IsNullOrEmpty(txtPuesto.Text) ? null : txtPuesto.Text;
                docentes.Telefono = txtTelefono.Text;
                docentes.Correo = txtCorreo.Text;

                // 2. Llenamos las propiedades del bloque Usuario
                docentes.IdUsuario = idUsuario; //Será 0 si es nuevo, o el ID real si es update
                docentes.NombreUsuario = string.IsNullOrEmpty(txtUsuario.Text) ? null : txtUsuario.Text;
                docentes.Password = string.IsNullOrEmpty(txtPassword.Text) ? null : txtPassword.Text;
                docentes.Perfil = string.IsNullOrEmpty(cmbPerfil.Text) ? null : cmbPerfil.Text;

                string msg = "";

                // Si es una modificación (tipoOperacion = 1), pedimos confimación como en carreras y alumnos
                if (tipoOperacion == 1)
                {
                    var resp = MessageBox.Show("¿Confirmar que deseas actualizar los datos de este docente?", "ALERTA", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                    if (resp == DialogResult.Yes)
                    {
                        msg = docentes.GuardarActualizar(tipoOperacion);
                        MessageBox.Show(msg, "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    }
                }
                else //Si es nuevo (tipoOperacion = 0), se guarda directo
                {
                    msg = docentes.GuardarActualizar(tipoOperacion);
                    MessageBox.Show(msg, "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

                CargarGrid(); //Refrescamos la tabla del formulario para ver los cambios



            }
            catch (Exception ex)
            {
                MessageBox.Show("No se pudieron guardar los datos: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void dgvDocentes_SelectionChanged(object sender, EventArgs e)
        {
            try
            {
                //Esto es para poder saber si es nuevo o vamos a actualizar
                idClave = int.Parse(dgvDocentes.CurrentRow.Cells["Clave"].Value.ToString());
                idUsuario = int.Parse(dgvDocentes.CurrentRow.Cells["idUsuario"].Value.ToString());

                //Esto es para la tabla Docentes
                txtClave.Text = idClave.ToString();
                txtNombre.Text = dgvDocentes.CurrentRow.Cells["Nombre"].Value.ToString();
                txtPuesto.Text = dgvDocentes.CurrentRow.Cells["Puesto"].Value.ToString();
                txtTelefono.Text = dgvDocentes.CurrentRow.Cells["telefono"].Value.ToString();
                txtCorreo.Text = dgvDocentes.CurrentRow.Cells["correo"].Value.ToString();

                //Esto es para la tabla Usuarios
                txtUsuario.Text = dgvDocentes.CurrentRow.Cells["Usuario"].Value.ToString();
                txtPassword.Text = dgvDocentes.CurrentRow.Cells["vchpassword"].Value.ToString();
                cmbPerfil.Text = dgvDocentes.CurrentRow.Cells["vchperfil"].Value.ToString();

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al mapear los datos seleccionados: " + ex.Message);
            }
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            idClave = 0;
            idUsuario = 0;
            docentes.LimpiarPanel(pnlDocente);
            docentes.LimpiarPanel(pnlUsuario);
            txtClave.Focus();
            


        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            var respuesta = MessageBox.Show($"¿Estás completamente seguro de eliminar permanentemente al docente con Clave :{idClave}?\nEsta acción borrará también su cuenta de usuario.",
                         "¡ADVERTENCIA!", MessageBoxButtons.YesNo, MessageBoxIcon.Stop);

            if (respuesta == DialogResult.Yes)
            {
                try
                {
                    docentes = new clsDocentes();

                    docentes.Clave = idClave;
                    docentes.IdUsuario = idUsuario;

                    string resultado = docentes.Eliminar();

                    MessageBox.Show(resultado, "Registro Eliminado", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    CargarGrid();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Ocurrió un error al intentar eliminar el registro: " + ex.Message,
                                    "Error Operacional", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
    }
}
