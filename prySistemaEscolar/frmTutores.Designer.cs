namespace prySistemaEscolar
{
    partial class frmTutores
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmTutores));
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            lblTutores = new Label();
            pnlAgrupaControles = new Panel();
            txtCorreo = new TextBox();
            txtTelefono = new TextBox();
            txtDireccion = new TextBox();
            txtParentesco = new TextBox();
            txtNombreT = new TextBox();
            btnNuevo = new Button();
            btnGuardar = new Button();
            btnEliminar = new Button();
            dgvTutores = new DataGridView();
            txtNombreTutor = new TextBox();
            pcbLogo = new PictureBox();
            pnlAgrupaControles.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvTutores).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pcbLogo).BeginInit();
            SuspendLayout();
            // 
            // lblTutores
            // 
            lblTutores.AutoSize = true;
            lblTutores.Font = new Font("Segoe UI", 36F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTutores.Location = new Point(388, 35);
            lblTutores.Name = "lblTutores";
            lblTutores.Size = new Size(196, 65);
            lblTutores.TabIndex = 3;
            lblTutores.Text = "Tutores";
            // 
            // pnlAgrupaControles
            // 
            pnlAgrupaControles.Controls.Add(txtCorreo);
            pnlAgrupaControles.Controls.Add(txtTelefono);
            pnlAgrupaControles.Controls.Add(txtDireccion);
            pnlAgrupaControles.Controls.Add(txtParentesco);
            pnlAgrupaControles.Controls.Add(txtNombreT);
            pnlAgrupaControles.Controls.Add(btnNuevo);
            pnlAgrupaControles.Controls.Add(btnGuardar);
            pnlAgrupaControles.Controls.Add(btnEliminar);
            pnlAgrupaControles.Location = new Point(59, 110);
            pnlAgrupaControles.Name = "pnlAgrupaControles";
            pnlAgrupaControles.Size = new Size(417, 288);
            pnlAgrupaControles.TabIndex = 4;
            // 
            // txtCorreo
            // 
            txtCorreo.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txtCorreo.Location = new Point(3, 167);
            txtCorreo.Name = "txtCorreo";
            txtCorreo.PlaceholderText = "Escribe el correo";
            txtCorreo.Size = new Size(408, 35);
            txtCorreo.TabIndex = 10;
            // 
            // txtTelefono
            // 
            txtTelefono.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txtTelefono.Location = new Point(3, 126);
            txtTelefono.Name = "txtTelefono";
            txtTelefono.PlaceholderText = "Escribe el telefono";
            txtTelefono.Size = new Size(408, 35);
            txtTelefono.TabIndex = 9;
            // 
            // txtDireccion
            // 
            txtDireccion.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txtDireccion.Location = new Point(3, 85);
            txtDireccion.Name = "txtDireccion";
            txtDireccion.PlaceholderText = "Escribe la dirección";
            txtDireccion.Size = new Size(408, 35);
            txtDireccion.TabIndex = 8;
            // 
            // txtParentesco
            // 
            txtParentesco.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txtParentesco.Location = new Point(3, 44);
            txtParentesco.Name = "txtParentesco";
            txtParentesco.PlaceholderText = "Escribe el parentesco";
            txtParentesco.Size = new Size(408, 35);
            txtParentesco.TabIndex = 7;
            // 
            // txtNombreT
            // 
            txtNombreT.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txtNombreT.Location = new Point(3, 3);
            txtNombreT.Name = "txtNombreT";
            txtNombreT.PlaceholderText = "Escribe el nombre del tutor";
            txtNombreT.Size = new Size(408, 35);
            txtNombreT.TabIndex = 6;
            // 
            // btnNuevo
            // 
            btnNuevo.BackgroundImage = (Image)resources.GetObject("btnNuevo.BackgroundImage");
            btnNuevo.BackgroundImageLayout = ImageLayout.Stretch;
            btnNuevo.Location = new Point(15, 219);
            btnNuevo.Name = "btnNuevo";
            btnNuevo.Size = new Size(96, 46);
            btnNuevo.TabIndex = 5;
            btnNuevo.UseVisualStyleBackColor = true;
            btnNuevo.Click += btnNuevo_Click;
            // 
            // btnGuardar
            // 
            btnGuardar.BackgroundImage = (Image)resources.GetObject("btnGuardar.BackgroundImage");
            btnGuardar.BackgroundImageLayout = ImageLayout.Stretch;
            btnGuardar.Location = new Point(158, 219);
            btnGuardar.Name = "btnGuardar";
            btnGuardar.Size = new Size(96, 46);
            btnGuardar.TabIndex = 4;
            btnGuardar.UseVisualStyleBackColor = true;
            btnGuardar.Click += btnGuardar_Click;
            // 
            // btnEliminar
            // 
            btnEliminar.BackgroundImage = (Image)resources.GetObject("btnEliminar.BackgroundImage");
            btnEliminar.BackgroundImageLayout = ImageLayout.Stretch;
            btnEliminar.Location = new Point(305, 219);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new Size(96, 46);
            btnEliminar.TabIndex = 3;
            btnEliminar.UseVisualStyleBackColor = true;
            btnEliminar.Click += btnEliminar_Click;
            // 
            // dgvTutores
            // 
            dgvTutores.AllowUserToAddRows = false;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = Color.FromArgb(255, 224, 192);
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dataGridViewCellStyle1.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = Color.Teal;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dgvTutores.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dgvTutores.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = Color.Teal;
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dataGridViewCellStyle2.ForeColor = Color.White;
            dataGridViewCellStyle2.SelectionBackColor = Color.FromArgb(192, 192, 255);
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.False;
            dgvTutores.DefaultCellStyle = dataGridViewCellStyle2;
            dgvTutores.EnableHeadersVisualStyles = false;
            dgvTutores.Location = new Point(491, 154);
            dgvTutores.Name = "dgvTutores";
            dgvTutores.RowTemplate.Height = 35;
            dgvTutores.Size = new Size(392, 244);
            dgvTutores.TabIndex = 11;
            dgvTutores.SelectionChanged += dgvTutores_SelectionChanged;
            // 
            // txtNombreTutor
            // 
            txtNombreTutor.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold);
            txtNombreTutor.Location = new Point(616, 113);
            txtNombreTutor.Name = "txtNombreTutor";
            txtNombreTutor.PlaceholderText = "Buscar Tutor";
            txtNombreTutor.Size = new Size(164, 35);
            txtNombreTutor.TabIndex = 12;
            txtNombreTutor.TextChanged += txtNombreTutor_TextChanged;
            // 
            // pcbLogo
            // 
            pcbLogo.Image = (Image)resources.GetObject("pcbLogo.Image");
            pcbLogo.Location = new Point(786, 35);
            pcbLogo.Name = "pcbLogo";
            pcbLogo.Size = new Size(100, 80);
            pcbLogo.SizeMode = PictureBoxSizeMode.StretchImage;
            pcbLogo.TabIndex = 13;
            pcbLogo.TabStop = false;
            // 
            // frmTutores
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(940, 491);
            Controls.Add(pcbLogo);
            Controls.Add(txtNombreTutor);
            Controls.Add(dgvTutores);
            Controls.Add(pnlAgrupaControles);
            Controls.Add(lblTutores);
            DoubleBuffered = true;
            Margin = new Padding(2);
            Name = "frmTutores";
            Text = "Registro de Tutores";
            pnlAgrupaControles.ResumeLayout(false);
            pnlAgrupaControles.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvTutores).EndInit();
            ((System.ComponentModel.ISupportInitialize)pcbLogo).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label lblTutores;
        private Panel pnlAgrupaControles;
        private TextBox txtNombreT;
        private Button btnNuevo;
        private Button btnGuardar;
        private Button btnEliminar;
        private TextBox txtCorreo;
        private TextBox txtTelefono;
        private TextBox txtDireccion;
        private TextBox txtParentesco;
        private DataGridView dgvTutores;
        private TextBox txtNombreTutor;
        private PictureBox pcbLogo;
    }
}