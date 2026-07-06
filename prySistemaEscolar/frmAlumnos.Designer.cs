namespace prySistemaEscolar
{
    partial class frmAlumnos
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmAlumnos));
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            txtMatricula = new TextBox();
            txtNombre = new TextBox();
            txtAPaterno = new TextBox();
            txtAMaterno = new TextBox();
            txtDireccion = new TextBox();
            txtTelefono = new TextBox();
            txtCorreo = new TextBox();
            txtPromedioBachiller = new TextBox();
            cmbTutor = new ComboBox();
            cmbCarrera = new ComboBox();
            pnlAlumno = new Panel();
            pnlUsuario = new Panel();
            cmbPerfil = new ComboBox();
            txtPassword = new TextBox();
            txtUsuario = new TextBox();
            lblAlumno = new Label();
            lblUsuario = new Label();
            btnEliminar = new Button();
            btnGuardar = new Button();
            btnNuevo = new Button();
            txtMatriculaAlumno = new TextBox();
            dgvAlumnos = new DataGridView();
            lblTitulo = new Label();
            pcbLogo = new PictureBox();
            pnlAlumno.SuspendLayout();
            pnlUsuario.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvAlumnos).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pcbLogo).BeginInit();
            SuspendLayout();
            // 
            // txtMatricula
            // 
            txtMatricula.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold);
            txtMatricula.Location = new Point(17, 9);
            txtMatricula.Name = "txtMatricula";
            txtMatricula.PlaceholderText = "Matricula";
            txtMatricula.Size = new Size(239, 33);
            txtMatricula.TabIndex = 0;
            // 
            // txtNombre
            // 
            txtNombre.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold);
            txtNombre.Location = new Point(18, 48);
            txtNombre.Name = "txtNombre";
            txtNombre.PlaceholderText = "Nombre";
            txtNombre.Size = new Size(238, 33);
            txtNombre.TabIndex = 1;
            // 
            // txtAPaterno
            // 
            txtAPaterno.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold);
            txtAPaterno.Location = new Point(18, 87);
            txtAPaterno.Name = "txtAPaterno";
            txtAPaterno.PlaceholderText = "Apellido Paterno";
            txtAPaterno.Size = new Size(238, 33);
            txtAPaterno.TabIndex = 2;
            // 
            // txtAMaterno
            // 
            txtAMaterno.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold);
            txtAMaterno.Location = new Point(18, 126);
            txtAMaterno.Name = "txtAMaterno";
            txtAMaterno.PlaceholderText = "Apellido Materno";
            txtAMaterno.Size = new Size(238, 33);
            txtAMaterno.TabIndex = 3;
            // 
            // txtDireccion
            // 
            txtDireccion.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold);
            txtDireccion.Location = new Point(18, 165);
            txtDireccion.Name = "txtDireccion";
            txtDireccion.PlaceholderText = "Dirección";
            txtDireccion.Size = new Size(238, 33);
            txtDireccion.TabIndex = 4;
            // 
            // txtTelefono
            // 
            txtTelefono.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold);
            txtTelefono.Location = new Point(269, 9);
            txtTelefono.Name = "txtTelefono";
            txtTelefono.PlaceholderText = "Teléfono";
            txtTelefono.Size = new Size(239, 33);
            txtTelefono.TabIndex = 5;
            // 
            // txtCorreo
            // 
            txtCorreo.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold);
            txtCorreo.Location = new Point(269, 48);
            txtCorreo.Name = "txtCorreo";
            txtCorreo.PlaceholderText = "Correo";
            txtCorreo.Size = new Size(239, 33);
            txtCorreo.TabIndex = 6;
            // 
            // txtPromedioBachiller
            // 
            txtPromedioBachiller.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold);
            txtPromedioBachiller.Location = new Point(269, 85);
            txtPromedioBachiller.Name = "txtPromedioBachiller";
            txtPromedioBachiller.PlaceholderText = "Promedio Bachillerato";
            txtPromedioBachiller.Size = new Size(239, 33);
            txtPromedioBachiller.TabIndex = 7;
            // 
            // cmbTutor
            // 
            cmbTutor.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold);
            cmbTutor.FormattingEnabled = true;
            cmbTutor.Location = new Point(269, 124);
            cmbTutor.Name = "cmbTutor";
            cmbTutor.Size = new Size(239, 33);
            cmbTutor.TabIndex = 8;
            // 
            // cmbCarrera
            // 
            cmbCarrera.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold);
            cmbCarrera.FormattingEnabled = true;
            cmbCarrera.Location = new Point(269, 163);
            cmbCarrera.Name = "cmbCarrera";
            cmbCarrera.Size = new Size(239, 33);
            cmbCarrera.TabIndex = 9;
            // 
            // pnlAlumno
            // 
            pnlAlumno.BackColor = SystemColors.ActiveCaption;
            pnlAlumno.BorderStyle = BorderStyle.Fixed3D;
            pnlAlumno.Controls.Add(cmbCarrera);
            pnlAlumno.Controls.Add(cmbTutor);
            pnlAlumno.Controls.Add(txtPromedioBachiller);
            pnlAlumno.Controls.Add(txtCorreo);
            pnlAlumno.Controls.Add(txtTelefono);
            pnlAlumno.Controls.Add(txtDireccion);
            pnlAlumno.Controls.Add(txtAMaterno);
            pnlAlumno.Controls.Add(txtAPaterno);
            pnlAlumno.Controls.Add(txtNombre);
            pnlAlumno.Controls.Add(txtMatricula);
            pnlAlumno.Location = new Point(35, 87);
            pnlAlumno.Name = "pnlAlumno";
            pnlAlumno.Size = new Size(522, 205);
            pnlAlumno.TabIndex = 10;
            // 
            // pnlUsuario
            // 
            pnlUsuario.BackColor = SystemColors.ActiveCaption;
            pnlUsuario.BorderStyle = BorderStyle.Fixed3D;
            pnlUsuario.Controls.Add(cmbPerfil);
            pnlUsuario.Controls.Add(txtPassword);
            pnlUsuario.Controls.Add(txtUsuario);
            pnlUsuario.Location = new Point(563, 87);
            pnlUsuario.Name = "pnlUsuario";
            pnlUsuario.Size = new Size(256, 170);
            pnlUsuario.TabIndex = 11;
            // 
            // cmbPerfil
            // 
            cmbPerfil.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold);
            cmbPerfil.FormattingEnabled = true;
            cmbPerfil.Items.AddRange(new object[] { "Administrador", "Alumno", "Docente", "Tutor" });
            cmbPerfil.Location = new Point(14, 102);
            cmbPerfil.Name = "cmbPerfil";
            cmbPerfil.Size = new Size(216, 33);
            cmbPerfil.TabIndex = 10;
            // 
            // txtPassword
            // 
            txtPassword.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold);
            txtPassword.Location = new Point(14, 48);
            txtPassword.Name = "txtPassword";
            txtPassword.PlaceholderText = "Password";
            txtPassword.Size = new Size(216, 33);
            txtPassword.TabIndex = 2;
            txtPassword.UseSystemPasswordChar = true;
            // 
            // txtUsuario
            // 
            txtUsuario.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold);
            txtUsuario.Location = new Point(14, 9);
            txtUsuario.Name = "txtUsuario";
            txtUsuario.PlaceholderText = "Usuario";
            txtUsuario.Size = new Size(216, 33);
            txtUsuario.TabIndex = 1;
            // 
            // lblAlumno
            // 
            lblAlumno.AutoSize = true;
            lblAlumno.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold);
            lblAlumno.Location = new Point(35, 55);
            lblAlumno.Name = "lblAlumno";
            lblAlumno.Size = new Size(83, 25);
            lblAlumno.TabIndex = 12;
            lblAlumno.Text = "Alumno";
            // 
            // lblUsuario
            // 
            lblUsuario.AutoSize = true;
            lblUsuario.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold);
            lblUsuario.Location = new Point(729, 55);
            lblUsuario.Name = "lblUsuario";
            lblUsuario.Size = new Size(81, 25);
            lblUsuario.TabIndex = 13;
            lblUsuario.Text = "Usuario";
            // 
            // btnEliminar
            // 
            btnEliminar.BackgroundImage = (Image)resources.GetObject("btnEliminar.BackgroundImage");
            btnEliminar.BackgroundImageLayout = ImageLayout.Stretch;
            btnEliminar.Location = new Point(387, 295);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new Size(96, 46);
            btnEliminar.TabIndex = 16;
            btnEliminar.UseVisualStyleBackColor = true;
            btnEliminar.Click += btnEliminar_Click;
            // 
            // btnGuardar
            // 
            btnGuardar.BackgroundImage = (Image)resources.GetObject("btnGuardar.BackgroundImage");
            btnGuardar.BackgroundImageLayout = ImageLayout.Stretch;
            btnGuardar.Location = new Point(236, 295);
            btnGuardar.Name = "btnGuardar";
            btnGuardar.Size = new Size(96, 46);
            btnGuardar.TabIndex = 15;
            btnGuardar.UseVisualStyleBackColor = true;
            btnGuardar.Click += btnGuardar_Click;
            // 
            // btnNuevo
            // 
            btnNuevo.BackgroundImage = (Image)resources.GetObject("btnNuevo.BackgroundImage");
            btnNuevo.BackgroundImageLayout = ImageLayout.Stretch;
            btnNuevo.Location = new Point(95, 295);
            btnNuevo.Name = "btnNuevo";
            btnNuevo.Size = new Size(96, 46);
            btnNuevo.TabIndex = 14;
            btnNuevo.UseVisualStyleBackColor = true;
            btnNuevo.Click += btnNuevo_Click;
            // 
            // txtMatriculaAlumno
            // 
            txtMatriculaAlumno.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold);
            txtMatriculaAlumno.Location = new Point(678, 306);
            txtMatriculaAlumno.Name = "txtMatriculaAlumno";
            txtMatriculaAlumno.PlaceholderText = "Buscar por matrícula";
            txtMatriculaAlumno.Size = new Size(227, 35);
            txtMatriculaAlumno.TabIndex = 18;
            txtMatriculaAlumno.TextChanged += txtNombreAlumno_TextChanged;
            // 
            // dgvAlumnos
            // 
            dgvAlumnos.AllowUserToAddRows = false;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = Color.FromArgb(255, 224, 192);
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dataGridViewCellStyle1.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = Color.Teal;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dgvAlumnos.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dgvAlumnos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = Color.Teal;
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dataGridViewCellStyle2.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = Color.FromArgb(192, 192, 255);
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.False;
            dgvAlumnos.DefaultCellStyle = dataGridViewCellStyle2;
            dgvAlumnos.EnableHeadersVisualStyles = false;
            dgvAlumnos.Location = new Point(35, 347);
            dgvAlumnos.Name = "dgvAlumnos";
            dgvAlumnos.RowHeadersWidth = 62;
            dgvAlumnos.RowTemplate.Height = 35;
            dgvAlumnos.Size = new Size(870, 117);
            dgvAlumnos.TabIndex = 17;
            dgvAlumnos.SelectionChanged += dgvAlumnos_SelectionChanged;
            // 
            // lblTitulo
            // 
            lblTitulo.AutoSize = true;
            lblTitulo.Font = new Font("Segoe UI", 36F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTitulo.Location = new Point(387, 20);
            lblTitulo.Name = "lblTitulo";
            lblTitulo.Size = new Size(228, 65);
            lblTitulo.TabIndex = 20;
            lblTitulo.Text = "Alumnos";
            // 
            // pcbLogo
            // 
            pcbLogo.Image = (Image)resources.GetObject("pcbLogo.Image");
            pcbLogo.Location = new Point(823, 25);
            pcbLogo.Name = "pcbLogo";
            pcbLogo.Size = new Size(90, 98);
            pcbLogo.SizeMode = PictureBoxSizeMode.StretchImage;
            pcbLogo.TabIndex = 19;
            pcbLogo.TabStop = false;
            // 
            // frmAlumnos
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.fondoAlumnos;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(939, 491);
            Controls.Add(lblTitulo);
            Controls.Add(pcbLogo);
            Controls.Add(txtMatriculaAlumno);
            Controls.Add(dgvAlumnos);
            Controls.Add(btnEliminar);
            Controls.Add(btnGuardar);
            Controls.Add(btnNuevo);
            Controls.Add(lblUsuario);
            Controls.Add(lblAlumno);
            Controls.Add(pnlUsuario);
            Controls.Add(pnlAlumno);
            DoubleBuffered = true;
            ForeColor = SystemColors.ControlText;
            Name = "frmAlumnos";
            Text = "Registro de Alumnos";
            pnlAlumno.ResumeLayout(false);
            pnlAlumno.PerformLayout();
            pnlUsuario.ResumeLayout(false);
            pnlUsuario.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvAlumnos).EndInit();
            ((System.ComponentModel.ISupportInitialize)pcbLogo).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtMatricula;
        private TextBox txtNombre;
        private TextBox txtAPaterno;
        private TextBox txtAMaterno;
        private TextBox txtDireccion;
        private TextBox txtTelefono;
        private TextBox txtCorreo;
        private TextBox txtPromedioBachiller;
        private ComboBox cmbTutor;
        private ComboBox cmbCarrera;
        private Panel pnlAlumno;
        private Panel pnlUsuario;
        private ComboBox cmbPerfil;
        private TextBox txtPassword;
        private TextBox txtUsuario;
        private Label lblAlumno;
        private Label lblUsuario;
        private Button btnEliminar;
        private Button btnGuardar;
        private Button btnNuevo;
        private TextBox txtMatriculaAlumno;
        private DataGridView dgvAlumnos;
        private Label lblTitulo;
        private PictureBox pcbLogo;
    }
}