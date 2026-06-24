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
            lblTutores.Location = new Point(376, 73);
            lblTutores.Margin = new Padding(4, 0, 4, 0);
            lblTutores.Name = "lblTutores";
            lblTutores.Size = new Size(293, 96);
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
            pnlAgrupaControles.Location = new Point(84, 183);
            pnlAgrupaControles.Margin = new Padding(4, 5, 4, 5);
            pnlAgrupaControles.Name = "pnlAgrupaControles";
            pnlAgrupaControles.Size = new Size(596, 480);
            pnlAgrupaControles.TabIndex = 4;
            // 
            // txtCorreo
            // 
            txtCorreo.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txtCorreo.Location = new Point(4, 278);
            txtCorreo.Margin = new Padding(4, 5, 4, 5);
            txtCorreo.Name = "txtCorreo";
            txtCorreo.PlaceholderText = "Escribe el correo";
            txtCorreo.Size = new Size(581, 49);
            txtCorreo.TabIndex = 10;
            // 
            // txtTelefono
            // 
            txtTelefono.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txtTelefono.Location = new Point(4, 210);
            txtTelefono.Margin = new Padding(4, 5, 4, 5);
            txtTelefono.Name = "txtTelefono";
            txtTelefono.PlaceholderText = "Escribe el telefono";
            txtTelefono.Size = new Size(581, 49);
            txtTelefono.TabIndex = 9;
            // 
            // txtDireccion
            // 
            txtDireccion.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txtDireccion.Location = new Point(4, 142);
            txtDireccion.Margin = new Padding(4, 5, 4, 5);
            txtDireccion.Name = "txtDireccion";
            txtDireccion.PlaceholderText = "Escribe la dirección";
            txtDireccion.Size = new Size(581, 49);
            txtDireccion.TabIndex = 8;
            // 
            // txtParentesco
            // 
            txtParentesco.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txtParentesco.Location = new Point(4, 73);
            txtParentesco.Margin = new Padding(4, 5, 4, 5);
            txtParentesco.Name = "txtParentesco";
            txtParentesco.PlaceholderText = "Escribe el parentesco";
            txtParentesco.Size = new Size(581, 49);
            txtParentesco.TabIndex = 7;
            // 
            // txtNombreT
            // 
            txtNombreT.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txtNombreT.Location = new Point(4, 5);
            txtNombreT.Margin = new Padding(4, 5, 4, 5);
            txtNombreT.Name = "txtNombreT";
            txtNombreT.PlaceholderText = "Escribe el nombre del tutor";
            txtNombreT.Size = new Size(581, 49);
            txtNombreT.TabIndex = 6;
            // 
            // btnNuevo
            // 
            btnNuevo.BackgroundImage = (Image)resources.GetObject("btnNuevo.BackgroundImage");
            btnNuevo.BackgroundImageLayout = ImageLayout.Stretch;
            btnNuevo.Location = new Point(21, 365);
            btnNuevo.Margin = new Padding(4, 5, 4, 5);
            btnNuevo.Name = "btnNuevo";
            btnNuevo.Size = new Size(137, 77);
            btnNuevo.TabIndex = 5;
            btnNuevo.UseVisualStyleBackColor = true;
            // 
            // btnGuardar
            // 
            btnGuardar.BackgroundImage = (Image)resources.GetObject("btnGuardar.BackgroundImage");
            btnGuardar.BackgroundImageLayout = ImageLayout.Stretch;
            btnGuardar.Location = new Point(226, 365);
            btnGuardar.Margin = new Padding(4, 5, 4, 5);
            btnGuardar.Name = "btnGuardar";
            btnGuardar.Size = new Size(137, 77);
            btnGuardar.TabIndex = 4;
            btnGuardar.UseVisualStyleBackColor = true;
            // 
            // btnEliminar
            // 
            btnEliminar.BackgroundImage = (Image)resources.GetObject("btnEliminar.BackgroundImage");
            btnEliminar.BackgroundImageLayout = ImageLayout.Stretch;
            btnEliminar.Location = new Point(436, 365);
            btnEliminar.Margin = new Padding(4, 5, 4, 5);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new Size(137, 77);
            btnEliminar.TabIndex = 3;
            btnEliminar.UseVisualStyleBackColor = true;
            // 
            // dgvTutores
            // 
            dgvTutores.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvTutores.Location = new Point(701, 257);
            dgvTutores.Margin = new Padding(4, 5, 4, 5);
            dgvTutores.Name = "dgvTutores";
            dgvTutores.RowHeadersWidth = 62;
            dgvTutores.Size = new Size(560, 407);
            dgvTutores.TabIndex = 11;
            // 
            // txtNombreTutor
            // 
            txtNombreTutor.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold);
            txtNombreTutor.Location = new Point(868, 188);
            txtNombreTutor.Margin = new Padding(4, 5, 4, 5);
            txtNombreTutor.Name = "txtNombreTutor";
            txtNombreTutor.PlaceholderText = "Buscar Tutor";
            txtNombreTutor.Size = new Size(233, 49);
            txtNombreTutor.TabIndex = 12;
            // 
            // pcbLogo
            // 
            pcbLogo.Image = (Image)resources.GetObject("pcbLogo.Image");
            pcbLogo.Location = new Point(663, 73);
            pcbLogo.Margin = new Padding(4, 5, 4, 5);
            pcbLogo.Name = "pcbLogo";
            pcbLogo.Size = new Size(215, 133);
            pcbLogo.SizeMode = PictureBoxSizeMode.StretchImage;
            pcbLogo.TabIndex = 13;
            pcbLogo.TabStop = false;
            // 
            // frmTutores
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.fondocarrerass;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1343, 748);
            Controls.Add(pnlAgrupaControles);
            Controls.Add(txtNombreTutor);
            Controls.Add(pcbLogo);
            Controls.Add(dgvTutores);
            Controls.Add(lblTutores);
            DoubleBuffered = true;
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