namespace prySistemaEscolar
{
    partial class frmCarreras
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmCarreras));
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle4 = new DataGridViewCellStyle();
            pcbLogo = new PictureBox();
            lblTitulo = new Label();
            pnlAgrupaControles = new Panel();
            btnEliminar = new Button();
            btnGuardar = new Button();
            btnNuevo = new Button();
            txtDescripcion = new TextBox();
            txtNombre = new TextBox();
            dgvCarreras = new DataGridView();
            txtNombreCarreras = new TextBox();
            ((System.ComponentModel.ISupportInitialize)pcbLogo).BeginInit();
            pnlAgrupaControles.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvCarreras).BeginInit();
            SuspendLayout();
            // 
            // pcbLogo
            // 
            pcbLogo.Image = (Image)resources.GetObject("pcbLogo.Image");
            pcbLogo.Location = new Point(802, 46);
            pcbLogo.Name = "pcbLogo";
            pcbLogo.Size = new Size(83, 104);
            pcbLogo.SizeMode = PictureBoxSizeMode.StretchImage;
            pcbLogo.TabIndex = 0;
            pcbLogo.TabStop = false;
            // 
            // lblTitulo
            // 
            lblTitulo.AutoSize = true;
            lblTitulo.Font = new Font("Segoe UI", 36F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTitulo.Location = new Point(374, 36);
            lblTitulo.Name = "lblTitulo";
            lblTitulo.Size = new Size(214, 65);
            lblTitulo.TabIndex = 1;
            lblTitulo.Text = "Carreras";
            // 
            // pnlAgrupaControles
            // 
            pnlAgrupaControles.Controls.Add(btnEliminar);
            pnlAgrupaControles.Controls.Add(btnGuardar);
            pnlAgrupaControles.Controls.Add(btnNuevo);
            pnlAgrupaControles.Controls.Add(txtDescripcion);
            pnlAgrupaControles.Controls.Add(txtNombre);
            pnlAgrupaControles.Location = new Point(172, 104);
            pnlAgrupaControles.Name = "pnlAgrupaControles";
            pnlAgrupaControles.Size = new Size(624, 193);
            pnlAgrupaControles.TabIndex = 2;
            // 
            // btnEliminar
            // 
            btnEliminar.BackgroundImage = Properties.Resources.botoneliminar;
            btnEliminar.BackgroundImageLayout = ImageLayout.Stretch;
            btnEliminar.Location = new Point(391, 139);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new Size(96, 46);
            btnEliminar.TabIndex = 4;
            btnEliminar.UseVisualStyleBackColor = true;
            // 
            // btnGuardar
            // 
            btnGuardar.BackgroundImage = Properties.Resources.botonguardar;
            btnGuardar.BackgroundImageLayout = ImageLayout.Stretch;
            btnGuardar.Location = new Point(254, 139);
            btnGuardar.Name = "btnGuardar";
            btnGuardar.Size = new Size(96, 46);
            btnGuardar.TabIndex = 3;
            btnGuardar.UseVisualStyleBackColor = true;
            // 
            // btnNuevo
            // 
            btnNuevo.BackgroundImage = Properties.Resources.botonnuevo;
            btnNuevo.BackgroundImageLayout = ImageLayout.Stretch;
            btnNuevo.Location = new Point(110, 139);
            btnNuevo.Name = "btnNuevo";
            btnNuevo.Size = new Size(96, 46);
            btnNuevo.TabIndex = 2;
            btnNuevo.UseVisualStyleBackColor = true;
            // 
            // txtDescripcion
            // 
            txtDescripcion.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold);
            txtDescripcion.Location = new Point(110, 77);
            txtDescripcion.Name = "txtDescripcion";
            txtDescripcion.PlaceholderText = "Escribir una descripción de la carrera";
            txtDescripcion.Size = new Size(377, 35);
            txtDescripcion.TabIndex = 1;
            // 
            // txtNombre
            // 
            txtNombre.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txtNombre.Location = new Point(110, 26);
            txtNombre.Name = "txtNombre";
            txtNombre.PlaceholderText = "Escribir el nombre de la carrera";
            txtNombre.Size = new Size(377, 35);
            txtNombre.TabIndex = 0;
            // 
            // dgvCarreras
            // 
            dgvCarreras.AllowUserToAddRows = false;
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = Color.FromArgb(255, 224, 192);
            dataGridViewCellStyle3.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dataGridViewCellStyle3.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = Color.Teal;
            dataGridViewCellStyle3.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.True;
            dgvCarreras.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle3;
            dgvCarreras.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle4.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = Color.Teal;
            dataGridViewCellStyle4.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dataGridViewCellStyle4.ForeColor = Color.White;
            dataGridViewCellStyle4.SelectionBackColor = Color.FromArgb(192, 192, 255);
            dataGridViewCellStyle4.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = DataGridViewTriState.False;
            dgvCarreras.DefaultCellStyle = dataGridViewCellStyle4;
            dgvCarreras.EnableHeadersVisualStyles = false;
            dgvCarreras.Location = new Point(172, 336);
            dgvCarreras.Name = "dgvCarreras";
            dgvCarreras.RowTemplate.Height = 35;
            dgvCarreras.Size = new Size(624, 114);
            dgvCarreras.TabIndex = 3;
            // 
            // txtNombreCarreras
            // 
            txtNombreCarreras.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold);
            txtNombreCarreras.Location = new Point(632, 300);
            txtNombreCarreras.Name = "txtNombreCarreras";
            txtNombreCarreras.PlaceholderText = "Buscar Carrera";
            txtNombreCarreras.Size = new Size(164, 35);
            txtNombreCarreras.TabIndex = 4;
            txtNombreCarreras.TextChanged += txtNombreCarrera_TextChanged;
            // 
            // frmCarreras
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.fondocarrerass;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(939, 491);
            Controls.Add(txtNombreCarreras);
            Controls.Add(dgvCarreras);
            Controls.Add(pnlAgrupaControles);
            Controls.Add(lblTitulo);
            Controls.Add(pcbLogo);
            DoubleBuffered = true;
            Name = "frmCarreras";
            Text = "Registro de Carreras";
            ((System.ComponentModel.ISupportInitialize)pcbLogo).EndInit();
            pnlAgrupaControles.ResumeLayout(false);
            pnlAgrupaControles.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvCarreras).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pcbLogo;
        private Label lblTitulo;
        private Panel pnlAgrupaControles;
        private TextBox txtDescripcion;
        private TextBox txtNombre;
        private Button btnEliminar;
        private Button btnGuardar;
        private Button btnNuevo;
        private DataGridView dgvCarreras;
        private TextBox txtNombreCarreras;
    }
}