namespace prySistemaEscolar
{
    partial class reporte
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(reporte));
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            gpbOpciones = new GroupBox();
            rdbOpcion2 = new RadioButton();
            rdbOpcion1 = new RadioButton();
            pictureBox1 = new PictureBox();
            dgvReportes = new DataGridView();
            btnGenerarPdf = new Button();
            btnVer = new Button();
            gpbOpciones.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvReportes).BeginInit();
            SuspendLayout();
            // 
            // gpbOpciones
            // 
            gpbOpciones.Controls.Add(rdbOpcion2);
            gpbOpciones.Controls.Add(rdbOpcion1);
            gpbOpciones.FlatStyle = FlatStyle.Popup;
            gpbOpciones.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            gpbOpciones.Location = new Point(147, 146);
            gpbOpciones.Name = "gpbOpciones";
            gpbOpciones.Size = new Size(649, 130);
            gpbOpciones.TabIndex = 0;
            gpbOpciones.TabStop = false;
            gpbOpciones.Text = "Opciones";
            // 
            // rdbOpcion2
            // 
            rdbOpcion2.AutoSize = true;
            rdbOpcion2.Font = new Font("Segoe UI Emoji", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            rdbOpcion2.Location = new Point(17, 87);
            rdbOpcion2.Name = "rdbOpcion2";
            rdbOpcion2.Size = new Size(354, 21);
            rdbOpcion2.TabIndex = 1;
            rdbOpcion2.TabStop = true;
            rdbOpcion2.Text = "Mostrar los tutores de los alumons con promedios >=9";
            rdbOpcion2.UseVisualStyleBackColor = true;
            // 
            // rdbOpcion1
            // 
            rdbOpcion1.AutoSize = true;
            rdbOpcion1.Font = new Font("Segoe UI Emoji", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            rdbOpcion1.Location = new Point(17, 38);
            rdbOpcion1.Name = "rdbOpcion1";
            rdbOpcion1.Size = new Size(454, 21);
            rdbOpcion1.TabIndex = 0;
            rdbOpcion1.TabStop = true;
            rdbOpcion1.Text = "Mostrar los alumnos y su carrera con los promedios de bachillerato <=8";
            rdbOpcion1.UseVisualStyleBackColor = true;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(147, 1);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(649, 117);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 1;
            pictureBox1.TabStop = false;
            // 
            // dgvReportes
            // 
            dgvReportes.AllowUserToAddRows = false;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = Color.FromArgb(255, 224, 192);
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dataGridViewCellStyle1.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = Color.Teal;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dgvReportes.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dgvReportes.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = Color.Teal;
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dataGridViewCellStyle2.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = Color.FromArgb(192, 192, 255);
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.False;
            dgvReportes.DefaultCellStyle = dataGridViewCellStyle2;
            dgvReportes.EnableHeadersVisualStyles = false;
            dgvReportes.Location = new Point(51, 358);
            dgvReportes.Name = "dgvReportes";
            dgvReportes.RowHeadersWidth = 62;
            dgvReportes.RowTemplate.Height = 35;
            dgvReportes.Size = new Size(870, 239);
            dgvReportes.TabIndex = 29;
            // 
            // btnGenerarPdf
            // 
            btnGenerarPdf.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnGenerarPdf.Location = new Point(321, 616);
            btnGenerarPdf.Name = "btnGenerarPdf";
            btnGenerarPdf.Size = new Size(319, 33);
            btnGenerarPdf.TabIndex = 30;
            btnGenerarPdf.Text = "Generar PDF";
            btnGenerarPdf.UseVisualStyleBackColor = true;
            // 
            // btnVer
            // 
            btnVer.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnVer.Location = new Point(394, 303);
            btnVer.Name = "btnVer";
            btnVer.Size = new Size(109, 34);
            btnVer.TabIndex = 31;
            btnVer.Text = "Ver";
            btnVer.UseVisualStyleBackColor = true;
            btnVer.Click += btnVer_Click;
            // 
            // reporte
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Azure;
            ClientSize = new Size(984, 661);
            Controls.Add(btnVer);
            Controls.Add(btnGenerarPdf);
            Controls.Add(dgvReportes);
            Controls.Add(pictureBox1);
            Controls.Add(gpbOpciones);
            Name = "reporte";
            Text = "reporte";
            TransparencyKey = Color.White;
            gpbOpciones.ResumeLayout(false);
            gpbOpciones.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvReportes).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox gpbOpciones;
        private RadioButton rdbOpcion1;
        private RadioButton rdbOpcion2;
        private PictureBox pictureBox1;
        private DataGridView dgvReportes;
        private Button btnGenerarPdf;
        private Button btnVer;
    }
}